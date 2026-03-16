// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction137"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _c-Ph0dcZEeqRFcf2R4bPBw
/// Spec source: PaymentTransaction137 message component.
/// All reference identifier fields are Max35Text (optional, MinLength=1, MaxLength=35 when present).
/// OriginalUETR follows RFC 4122 UUID v4 pattern.
/// OriginalInterbankSettlementAmount currency must be ISO 4217 (3 uppercase letters).
/// </remarks>
public sealed class PaymentTransaction137Validator : AbstractValidator<PaymentTransaction137>
{
    // UUIDv4Identifier spec pattern (ISO ID: _TQIBwHrVEeidVZmeoasaWQ):
    // [a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}
    private static readonly Regex UetrRegex =
        new(
            @"^[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant
        );

    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    public PaymentTransaction137Validator()
    {
        // ── Max35Text fields (optional, MinLength=1, MaxLength=35 when present) ──────

        RuleFor(x => x.CancellationIdentification)
            .MinimumLength(1)
            .MaximumLength(35)
            .When(x => x.CancellationIdentification is not null);

        RuleFor(x => x.OriginalInstructionIdentification)
            .MinimumLength(1)
            .MaximumLength(35)
            .When(x => x.OriginalInstructionIdentification is not null);

        RuleFor(x => x.OriginalEndToEndIdentification)
            .MinimumLength(1)
            .MaximumLength(35)
            .When(x => x.OriginalEndToEndIdentification is not null);

        RuleFor(x => x.OriginalTransactionIdentification)
            .MinimumLength(1)
            .MaximumLength(35)
            .When(x => x.OriginalTransactionIdentification is not null);

        RuleFor(x => x.OriginalClearingSystemReference)
            .MinimumLength(1)
            .MaximumLength(35)
            .When(x => x.OriginalClearingSystemReference is not null);

        // ── OriginalUETR: UUIDv4Identifier (RFC 4122) ───────────────────────────────
        RuleFor(x => x.OriginalUETR)
            .Matches(UetrRegex)
            .WithMessage(
                "PaymentTransaction137.OriginalUETR must be a valid UUID v4 identifier "
                    + "(RFC 4122, pattern: [a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12})."
            )
            .When(x => x.OriginalUETR is not null);

        // ── OriginalInterbankSettlementAmount ────────────────────────────────────────
        When(
            x => x.OriginalInterbankSettlementAmount is not null,
            () =>
            {
                RuleFor(x => x.OriginalInterbankSettlementAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "PaymentTransaction137.OriginalInterbankSettlementAmount.Currency "
                            + "must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.OriginalInterbankSettlementAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage(
                        "PaymentTransaction137.OriginalInterbankSettlementAmount.Amount must be greater than zero."
                    );
            }
        );

        // ── Nested components ────────────────────────────────────────────────────────
        When(
            x => x.Case is not null,
            () => RuleFor(x => x.Case).SetValidator(new Case5Validator()!)
        );

        When(
            x => x.CancellationReasonInformation is not null,
            () =>
                RuleFor(x => x.CancellationReasonInformation)
                    .SetValidator(new PaymentCancellationReason5Validator()!)
        );
    }
}
