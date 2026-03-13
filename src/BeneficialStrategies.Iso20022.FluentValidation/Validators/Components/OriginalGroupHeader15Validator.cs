// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalGroupHeader15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _UG6o4W49EeiU9cctagi5ow
/// Spec source: OriginalGroupHeader15 message component.
/// <list type="table">
///   <item><term>GroupCancellationIdentification</term><description>Max35Text — optional (0..1), MinLength=1, MaxLength=35</description></item>
///   <item><term>Case</term><description>Case5 — optional (0..1)</description></item>
///   <item><term>OriginalMessageIdentification</term><description>Max35Text — required (1..1), MinLength=1, MaxLength=35</description></item>
///   <item><term>OriginalMessageNameIdentification</term><description>Max35Text — required (1..1), MinLength=1, MaxLength=35</description></item>
///   <item><term>OriginalCreationDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — optional (0..1), pattern [0-9]{1,15}</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1)</description></item>
///   <item><term>GroupCancellation</term><description>GroupCancellationIndicator — optional (0..1)</description></item>
///   <item><term>CancellationReasonInformation</term><description>PaymentCancellationReason5 — optional (0..*)</description></item>
/// </list>
/// </remarks>
public sealed class OriginalGroupHeader15Validator : AbstractValidator<OriginalGroupHeader15>
{
    public OriginalGroupHeader15Validator()
    {
        RuleFor(x => x.OriginalMessageIdentification)
            .NotEmpty()
                .WithMessage("OriginalGroupHeader15.OriginalMessageIdentification is required (Max35Text, 1..1).")
            .MinimumLength(1)
            .MaximumLength(35)
                .WithMessage("OriginalGroupHeader15.OriginalMessageIdentification must not exceed 35 characters (Max35Text).");

        RuleFor(x => x.OriginalMessageNameIdentification)
            .NotEmpty()
                .WithMessage("OriginalGroupHeader15.OriginalMessageNameIdentification is required (Max35Text, 1..1).")
            .MinimumLength(1)
            .MaximumLength(35)
                .WithMessage("OriginalGroupHeader15.OriginalMessageNameIdentification must not exceed 35 characters (Max35Text).");

        RuleFor(x => x.GroupCancellationIdentification)
            .MinimumLength(1)
            .MaximumLength(35)
                .WithMessage("OriginalGroupHeader15.GroupCancellationIdentification must not exceed 35 characters (Max35Text).")
            .When(x => x.GroupCancellationIdentification is not null);

        // NumberOfTransactions: Max15NumericText pattern when present
        RuleFor(x => x.NumberOfTransactions)
            .Matches(@"^[0-9]{1,15}$")
                .WithMessage("OriginalGroupHeader15.NumberOfTransactions must be a numeric string of 1–15 digits (Max15NumericText, pattern: [0-9]{1,15}).")
            .When(x => x.NumberOfTransactions is not null);

        // Case: validate when present
        When(x => x.Case is not null, () =>
            RuleFor(x => x.Case).SetValidator(new Case5Validator()!));
    }
}
