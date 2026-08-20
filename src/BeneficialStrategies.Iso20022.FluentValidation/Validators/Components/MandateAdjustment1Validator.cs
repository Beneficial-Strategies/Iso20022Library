// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateAdjustment1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _PJFAQGVQEeacpJ-gG9kyUQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the details for the adjustment of the mandate.
/// <list type="table">
///   <item><term>DateAdjustmentRuleIndicator</term><description>TrueFalseIndicator — required (1..1)</description></item>
///   <item><term>Category</term><description>Frequency37Choice_ — optional (0..1)</description></item>
///   <item><term>Amount</term><description>ActiveCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>Rate</term><description>PercentageRate — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Category</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class MandateAdjustment1Validator : AbstractValidator<MandateAdjustment1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>Category</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="categoryValidator">
    /// Validator for the optional <c>Category</c> building block (Frequency37Choice_, 0..1) —
    /// only invoked when present.
    /// </param>
    public MandateAdjustment1Validator(IValidator<Frequency37Choice_> categoryValidator)
    {
        // DateAdjustmentRuleIndicator: required (1..1) and already `required` C# property — no
        // rule needed.
        // Amount: ActiveCurrencyAndAmount, optional — currency/amount format enforced by the
        // Amounts-namespace type itself, no validator exists for that type (matches project
        // convention elsewhere for Amounts types — see e.g. AccountBalance3Validator).
        // Rate: PercentageRate, optional — no additional constraint beyond the type itself.

        When(
            x => x.Category is not null,
            () => RuleFor(x => x.Category).SetValidator(categoryValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Category</c> building block
    /// is validated by its own default validator (<see cref="Frequency37Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateAdjustment1Validator()
        : this(new Frequency37Choice_Validator()) { }
}
