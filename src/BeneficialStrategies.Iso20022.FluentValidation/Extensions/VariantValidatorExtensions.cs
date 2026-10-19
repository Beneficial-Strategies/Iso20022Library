// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>The variants of a choice and the validator of each, collected by <c>SetVariantValidators</c>.</summary>
public sealed class VariantValidators<TChoice>
    where TChoice : class
{
    internal List<Action<AbstractValidator<TChoice>>> Rules { get; } = [];

    /// <summary>Validates the choice with <paramref name="validator"/> when it is the variant <typeparamref name="TVariant"/>.</summary>
    public VariantValidators<TChoice> Add<TVariant>(IValidator<TVariant> validator)
        where TVariant : class, TChoice
    {
        Rules.Add(host =>
            host.When(
                x => x is TVariant,
                () => host.RuleFor(x => (TVariant)x).SetValidator(validator)
            )
        );
        return this;
    }
}

/// <summary>Extension methods for validating a choice by the variant it holds.</summary>
public static class VariantValidatorExtensions
{
    /// <summary>
    /// Validates a choice by the validator of the variant it holds. FluentValidation's own
    /// <c>SetInheritanceValidator</c> finds the validator of the exact runtime type, so it never finds the
    /// validator of a variant interface (<c>IOther</c>), which is all a class of someone else's can be; this
    /// one tests the variant by type, so our record and any class that implements the variant interface are validated
    /// by the same rules, with the same property names in the failures.
    /// </summary>
    public static void SetVariantValidators<T>(
        this AbstractValidator<T> choiceValidator,
        Action<VariantValidators<T>> configure
    )
        where T : class
    {
        var variants = new VariantValidators<T>();
        configure(variants);
        foreach (var rule in variants.Rules)
            rule(choiceValidator);
    }
}
