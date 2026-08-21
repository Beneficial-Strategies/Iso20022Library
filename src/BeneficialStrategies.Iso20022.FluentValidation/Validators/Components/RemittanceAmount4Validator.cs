// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RemittanceAmount4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _SNLNYDH0Ee6BxvG014AZzQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides details on the amounts of the referred document.
/// <list type="table">
///   <item><term>AdjustmentAmountAndReason</term><description>DocumentAdjustment1 collection — optional (0..n)</description></item>
///   <item><term>RemittanceAmountAndType</term><description>DocumentAmount1 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: both collections are validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class RemittanceAmount4Validator : AbstractValidator<RemittanceAmount4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public RemittanceAmount4Validator(
        IValidator<DocumentAdjustment1> adjustmentAmountAndReasonValidator,
        IValidator<DocumentAmount1> remittanceAmountAndTypeValidator
    )
    {
        RuleForEach(x => x.AdjustmentAmountAndReason).SetValidator(adjustmentAmountAndReasonValidator!);
        RuleForEach(x => x.RemittanceAmountAndType).SetValidator(remittanceAmountAndTypeValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public RemittanceAmount4Validator()
        : this(new DocumentAdjustment1Validator(), new DocumentAmount1Validator()) { }
}
