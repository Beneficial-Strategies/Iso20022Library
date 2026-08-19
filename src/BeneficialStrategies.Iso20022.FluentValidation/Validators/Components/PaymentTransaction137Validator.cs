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
///
/// Dependency injection: the <c>Case</c> building block and the <c>CancellationReasonInformation</c>
/// collection are each validated by an injected <see cref="IValidator{T}"/> rather than a
/// hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class PaymentTransaction137Validator : AbstractValidator<PaymentTransaction137>
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
    public PaymentTransaction137Validator(
        IValidator<Case5> caseValidator,
        IValidator<PaymentCancellationReason5> cancellationReasonInformationValidator
    )
    {
        // Max35Text optional fields: length [1..35] enforced by Max35Text constructor — no FV rules needed.

        // ── OriginalUETR: UUIDv4Identifier (RFC 4122) ───────────────────────────────
        // UUID v4 pattern enforced by UUIDv4Identifier constructor — no FV Matches() needed.

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
    public PaymentTransaction137Validator()
        : this(new Case5Validator(), new PaymentCancellationReason5Validator()) { }
}
