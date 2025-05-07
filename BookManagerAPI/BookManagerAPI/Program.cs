using BookManagerAPI.Data;
using BookManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext
builder.Services.AddDbContext<BookDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// GET : Retuens all books from the database
app.MapGet("/books", async (BookDbContext db) =>
    await db.Books.ToListAsync());

// GET : Returns a book using the ID
app.MapGet("/books/{id:int}", async (int id, BookDbContext db) =>
{
    var book = await db.Books.FindAsync(id);
    // If the book is not found, return 404 Not Found
    return book is not null ? Results.Ok(book) : Results.NotFound();
});

// POST: Add new book
app.MapPost("/books", async (Book book, BookDbContext db) =>
{
    // Make sure that all fields are filled in
    if (string.IsNullOrWhiteSpace(book.Title) || string.IsNullOrWhiteSpace(book.Author) || book.Price <= 0)
        // Return 400 Bad Request for invalid input
        return Results.BadRequest("All fields are required and make sure that the book price is more than 0.");

    db.Books.Add(book);
    await db.SaveChangesAsync();
    // Return 201 Created when successfully added
    return Results.Created($"/books/{book.BookID}", book);
});

// PUT: Update book details
app.MapPut("/books/{id}", async (int id, Book input, BookDbContext db) =>
{
    var book = await db.Books.FindAsync(id);
    // Return 404 if the book is not found
    if (book == null) return Results.NotFound();

    book.Title = input.Title;
    book.Author = input.Author;
    book.Price = input.Price;
    await db.SaveChangesAsync();

    return Results.Ok(book);
});

// DELETE: Delete book
app.MapDelete("/books/{id}", async (int id, BookDbContext db) =>
{
    var book = await db.Books.FindAsync(id);
    // Return 404 if the book is not found
    if (book == null) return Results.NotFound();

    db.Books.Remove(book);
    await db.SaveChangesAsync();
    // Return 200 OK for a successful deletion
    return Results.Ok();
});

app.Run();
