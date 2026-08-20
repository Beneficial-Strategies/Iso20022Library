// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// Base class for validators of ISO 20022 external code set types (<see cref="IIsoExternalCode"/>)
/// — checks that the value is acceptable per an injected <see cref="IExternalCodeRegistry{TCode}"/>.
/// Concrete per-type validators just declare the class and the two constructors; the rule itself
/// is written once, here.
/// </summary>
/// <remarks>
/// See <see cref="IExternalCodeRegistry{TCode}"/> for why this check exists separately from the
/// struct's own format-only constructor, and <see cref="InMemoryExternalCodeRegistry{TCode}"/> for
/// the default registry's permissive-until-populated / auto-seeded-when-known-values-exist
/// behavior.
/// </remarks>
/// <typeparam name="TCode">The external code set type this validator checks.</typeparam>
public abstract class ExternalCodesetAbstractValidator<TCode> : AbstractValidator<TCode>
    where TCode : IIsoExternalCode
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the registry —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="registry">
    /// Supplies the currently-acceptable values for <typeparamref name="TCode"/>.
    /// </param>
    protected ExternalCodesetAbstractValidator(IExternalCodeRegistry<TCode> registry)
    {
        RuleFor(x => x)
            .Must(registry.IsAcceptable)
            .WithName("ExternalCodeRegistryRule")
            .WithMessage(x =>
                $"'{x.Value}' is not an acceptable value for {typeof(TCode).Name} "
                    + "(ExternalCodeRegistryRule)."
            );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: a fresh
    /// <see cref="InMemoryExternalCodeRegistry{TCode}"/> (auto-seeded from
    /// <typeparamref name="TCode"/>'s own known-value members, if it declares any). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    protected ExternalCodesetAbstractValidator()
        : this(new InMemoryExternalCodeRegistry<TCode>()) { }
}
