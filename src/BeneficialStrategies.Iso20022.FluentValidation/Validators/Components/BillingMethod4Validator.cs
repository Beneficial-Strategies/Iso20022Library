// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="BillingMethod4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6QGNo5qlEeGSON8vddiWzQ_288570123
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>ServiceDetail</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
///
/// Dependency injection: the <c>TaxCalculation</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class BillingMethod4Validator : AbstractValidator<BillingMethod4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>TaxCalculation</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="taxCalculationValidator">
    /// Validator for the required <c>TaxCalculation</c> building block (TaxCalculation1, 1..1).
    /// </param>
    public BillingMethod4Validator(IValidator<TaxCalculation1> taxCalculationValidator)
    {
        // TaxCalculation (TaxCalculation1): required (1..1) and already `required` C# property.
        // Now that TaxCalculation1Validator exists, wire it in — this comment previously said "no
        // validator exists yet," which had gone stale.
        RuleFor(x => x.TaxCalculation).SetValidator(taxCalculationValidator);

        // ServiceDetail: BillingServiceParameters2, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.ServiceDetail)
            .NotEmpty()
            .WithMessage("BillingMethod4.ServiceDetail must contain at least one element (1..*).");
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>TaxCalculation</c> building
    /// block is validated by its own default validator (<see cref="TaxCalculation1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public BillingMethod4Validator()
        : this(new TaxCalculation1Validator()) { }
}
