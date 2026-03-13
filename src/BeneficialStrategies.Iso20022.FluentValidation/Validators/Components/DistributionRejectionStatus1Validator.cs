// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DistributionRejectionStatus1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _RlXZUtp-Ed-ak6NoX_4Aeg_-2041243325
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// <list type="table">
///   <item><term>Reason</term><description>RejectionReason19FormatChoice — required (1..∞)</description></item>
///   <item><term>AdditionalInformation</term><description>Max350Text — optional (0..1)</description></item>
/// </list>
///
/// Model defect: <c>Reason</c> is declared as <c>ValueList&lt;T&gt; = []</c> (allows empty) but the
/// spec requires at least one element (Min=1). This validator enforces the minimum at runtime.
/// See docs/multiplicity-audit-2026-03.md — Defect 2.
///
/// Constraints: *(none defined in spec)*
/// </remarks>
public sealed class DistributionRejectionStatus1Validator : AbstractValidator<DistributionRejectionStatus1>
{
    public DistributionRejectionStatus1Validator()
    {
        // Reason is 1..∞ but the C# model allows empty (model defect — see XML doc).
        RuleFor(x => x.Reason)
            .NotEmpty()
                .WithMessage("DistributionRejectionStatus1.Reason must contain at least one element (1..∞).");

        RuleFor(x => x.AdditionalInformation)
            .MinimumLength(1)
            .MaximumLength(350)
                .WithMessage("DistributionRejectionStatus1.AdditionalInformation must not exceed 350 characters (Max350Text).")
            .When(x => x.AdditionalInformation is not null);
    }
}
