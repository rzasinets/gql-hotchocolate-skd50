namespace gql_hotchocolate_skd50.Models
{
  using FluentValidation;

  public class CreateBookInputValidator:AbstractValidator<CreateBookInput>
  {
    public CreateBookInputValidator()
    {
      RuleFor(x => x.Title).MinimumLength(3);
    }
  }
}