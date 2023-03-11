using FluentValidation;

namespace BookApi.Validators
{
    public class BookValidator : AbstractValidator <BookDto>
    {
        public BookValidator()
        {
            RuleFor(x => x.Title).NotNull().MinimumLength(4);
            RuleFor(x => x.Description).NotNull().MaximumLength(200);

        }
    }
}
