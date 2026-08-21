// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

/// <summary>
/// Validates <see cref="LanguageCode"/> against the currently-acceptable language codes.
/// </summary>
/// <remarks>
/// <see cref="LanguageCode"/>'s own constructor enforces only the structural pattern (any
/// non-empty string — see the struct's own remarks for why it stays permissive: MCP publishes no
/// length/pattern facet for this type, only a "ValidationByTable" constraint referencing an
/// external table). This validator adds a real membership check via an injected
/// <see cref="IExternalCodeRegistry{TCode}"/> — see that interface's own remarks for why this
/// lives here and not in the struct itself, and <see cref="InMemoryExternalCodeRegistry{TCode}"/>
/// for the default registry's permissive-until-populated behavior (as of 2026-08-20,
/// <see cref="LanguageCode"/> declares no known-value members, so the default registry is
/// permissive for this type until a caller populates it).
/// </remarks>
public class LanguageCodeValidator : ExternalCodesetAbstractValidator<LanguageCode>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the registry —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public LanguageCodeValidator(IExternalCodeRegistry<LanguageCode> registry)
        : base(registry) { }

    /// <summary>
    /// Initializes a new instance using a default in-memory registry. Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public LanguageCodeValidator() { }
}
