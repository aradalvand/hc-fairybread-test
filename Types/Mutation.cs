using FluentValidation;

namespace hc_test.Types;

[MutationType]
public static class Mutation
{
	public static string DoFoo(DoFooInput input) => "Foo done.";
}

public record DoFooInput(
	string Text
);

public class DoFooInputValidator : AbstractValidator<DoFooInput>
{
	public DoFooInputValidator()
	{
		RuleFor(x => x.Text)
			.MinimumLength(5);
	}
}
