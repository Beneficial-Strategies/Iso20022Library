// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalGroupHeader15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _UG6o4W49EeiU9cctagi5ow
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// <list type="table">
///   <item><term>GroupCancellationIdentification</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>Case</term><description>Case5 — optional (0..1)</description></item>
///   <item><term>OriginalMessageIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>OriginalMessageNameIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>OriginalCreationDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — optional (0..1), pattern [0-9]{1,15}</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1)</description></item>
///   <item><term>GroupCancellation</term><description>GroupCancellationIndicator — optional (0..1)</description></item>
///   <item><term>CancellationReasonInformation</term><description>PaymentCancellationReason5 — optional (0..∞)</description></item>
/// </list>
///
/// Constraints: *(none defined in spec)*
///
/// Dependency injection: the <c>Case</c> building block and the <c>CancellationReasonInformation</c>
/// collection are each validated by an injected <see cref="IValidator{T}"/> rather than a
/// hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class OriginalGroupHeader15Validator : AbstractValidator<OriginalGroupHeader15>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>Case</c> building block and for the <c>CancellationReasonInformation</c>
    /// collection's item type — e.g. resolved from a DI container — instead of this type
    /// constructing its own.
    /// </summary>
    /// <param name="caseValidator">
    /// Validator for the optional <c>Case</c> building block (Case5, 0..1) — only invoked when present.
    /// </param>
    /// <param name="cancellationReasonInformationValidator">
    /// Validator for each item of the <c>CancellationReasonInformation</c> collection
    /// (PaymentCancellationReason5, 0..∞).
    /// </param>
    public OriginalGroupHeader15Validator(
        IValidator<Case5> caseValidator,
        IValidator<PaymentCancellationReason5> cancellationReasonInformationValidator
    )
    {
        // Length [1..35] enforced by Max35Text constructor for all three Max35Text fields.
        RuleFor(x => x.OriginalMessageIdentification)
            .NotEmpty()
            .WithMessage(
                "OriginalGroupHeader15.OriginalMessageIdentification is required (Max35Text, 1..1)."
            );

        RuleFor(x => x.OriginalMessageNameIdentification)
            .NotEmpty()
            .WithMessage(
                "OriginalGroupHeader15.OriginalMessageNameIdentification is required (Max35Text, 1..1)."
            );

        // NumberOfTransactions: pattern [0-9]{1,15} enforced by Max15NumericText constructor.

        When(
            x => x.Case is not null,
            () => RuleFor(x => x.Case).SetValidator(caseValidator!)
        );

        RuleForEach(x => x.CancellationReasonInformation)
            .SetValidator(cancellationReasonInformationValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Case</c> building block and
    /// the <c>CancellationReasonInformation</c> collection are each validated by their own default
    /// validator (<see cref="Case5Validator"/>, <see cref="PaymentCancellationReason5Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public OriginalGroupHeader15Validator()
        : this(new Case5Validator(), new PaymentCancellationReason5Validator()) { }
}
