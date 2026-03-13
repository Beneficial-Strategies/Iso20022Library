// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentCancellationReason5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _fzdu8cDQEeic67MXUoeXWA
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// <list type="table">
///   <item><term>Originator</term><description>PartyIdentification135 — optional (0..1)</description></item>
///   <item><term>Reason</term><description>CancellationReason33Choice — optional (0..1)</description></item>
///   <item><term>AdditionalInformation</term><description>Max105Text — optional (0..∞), MinLength=1, MaxLength=105 per occurrence</description></item>
/// </list>
///
/// Constraints: *(none defined in spec)*
/// </remarks>
public sealed class PaymentCancellationReason5Validator : AbstractValidator<PaymentCancellationReason5>
{
    public PaymentCancellationReason5Validator()
    {
        // AdditionalInformation: Max105Text — MinLength=1, MaxLength=105 when present
        RuleFor(x => x.AdditionalInformation)
            .MinimumLength(1)
            .MaximumLength(105)
                .WithMessage(
                    "PaymentCancellationReason5.AdditionalInformation must not exceed 105 characters (Max105Text).")
            .When(x => x.AdditionalInformation is not null);
    }
}
