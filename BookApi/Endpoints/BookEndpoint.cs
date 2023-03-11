

using FluentValidation;

namespace BookApi.Endpoints
{
    public static class BookEndpoint
    {
        public static void MapBook(this WebApplication app) 
        {
            app.MapPost("/book", async (IValidator<BookDto> validator ,Context db , BookDto request) => 
            {
                var validationResult = await validator.ValidateAsync(request);
                if (!validationResult.IsValid) 
                {
                    return Results.ValidationProblem(validationResult.ToDictionary());
                }
                var book = new Book() { Description = request.Description , Title = request.Title};
                db.Books.Add(book);
                await db.SaveChangesAsync();
                return Results.Ok(book);
            });
        }
    }
}
