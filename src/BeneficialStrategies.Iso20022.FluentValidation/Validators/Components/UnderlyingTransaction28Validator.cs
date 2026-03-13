// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="UnderlyingTransaction28"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// Spec source: UnderlyingTransaction28 message component.
/// Both fields are optional (0..1) individually, but at least one must be present
/// for the message to have meaningful cancellation content.
/// <list type="table">
///   <item><term>OriginalGroupInformationAndCancellation</term><description>OriginalGroupHeader15 — optional (0..1)</description></item>
///   <item><term>TransactionInformation</term><description>PaymentTransaction137 — optional (0..1)</description></item>
/// </list>
/// </remarks>
public sealed class UnderlyingTransaction28Validator : AbstractValidator<UnderlyingTransaction28>
{
    public UnderlyingTransaction28Validator()
    {
        // At least one cancellation target must be specified
        RuleFor(x => x)
            .Must(x => x.OriginalGroupInformationAndCancellation is not null
                    || x.TransactionInformation is not null)
                .WithName("UnderlyingTransaction28")
                .WithMessage(
                    "UnderlyingTransaction28: at least one of OriginalGroupInformationAndCancellation " +
                    "or TransactionInformation must be present.");

        When(x => x.OriginalGroupInformationAndCancellation is not null, () =>
            RuleFor(x => x.OriginalGroupInformationAndCancellation)
                .SetValidator(new OriginalGroupHeader15Validator()!));

        When(x => x.TransactionInformation is not null, () =>
            RuleFor(x => x.TransactionInformation)
                .SetValidator(new PaymentTransaction137Validator()!));
    }
}
