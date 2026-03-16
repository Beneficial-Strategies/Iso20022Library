// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PEPISATransfer11"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _XE7zcfpfEeCLMa5EIHtDrg
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// <list type="table">
///   <item><term>PrimaryIndividualInvestor</term><description>IndividualPerson8 — optional (0..1)</description></item>
///   <item><term>SecondaryIndividualInvestor</term><description>IndividualPerson8 — optional (0..1)</description></item>
///   <item><term>OtherIndividualInvestor</term><description>IndividualPerson8 — optional (0..∞) [model defect: declared as 0..1]</description></item>
///   <item><term>PrimaryCorporateInvestor</term><description>Organisation4 — optional (0..1)</description></item>
///   <item><term>SecondaryCorporateInvestor</term><description>Organisation4 — optional (0..1)</description></item>
///   <item><term>OtherCorporateInvestor</term><description>Organisation4 — optional (0..∞) [model defect: declared as 0..1]</description></item>
///   <item><term>TransferorAccount</term><description>Account5 — required (1..1)</description></item>
///   <item><term>NomineeAccount</term><description>Account6 — optional (0..1)</description></item>
///   <item><term>Transferee</term><description>PartyIdentification2Choice — required (1..1)</description></item>
///   <item><term>CashAccount</term><description>CashAccount11 — optional (0..1)</description></item>
///   <item><term>ProductTransfer</term><description>ISATransfer3 — required (1..∞)</description></item>
///   <item><term>Extension</term><description>Extension1 — optional (0..∞) [model defect: declared as 0..1]</description></item>
/// </list>
///
/// Model defects (see docs/multiplicity-audit-2026-03.md — Defect 2):
/// <list type="bullet">
///   <item><c>ProductTransfer</c> is declared as <c>ValueList&lt;T&gt; = []</c> but spec requires Min=1.</item>
///   <item><c>OtherIndividualInvestor</c>, <c>OtherCorporateInvestor</c>, <c>Extension</c> are 0..∞ but declared as single nullable (Defect 1).</item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>ISARule</term>
///     <description>
///       If ProductTransfer/Portfolio/ISA or ProductTransfer/Portfolio/Portfolio is present, then
///       SecondaryIndividualInvestor and/or OtherIndividualInvestor is not allowed, and
///       PrimaryCorporateInvestor, SecondaryCorporateInvestor, OtherCorporateInvestor are not allowed.
///       Business-context constraint — cannot be enforced structurally from this component alone.
///     </description>
///   </item>
///   <item>
///     <term>PorfolioRule</term>
///     <description>
///       If ProductTransfer/Portfolio is present, then one or more individual or corporate investor
///       elements may be present. Business-context guidance only.
///     </description>
///   </item>
///   <item>
///     <term>InvestorRule</term>
///     <description>
///       If PrimaryIndividualInvestor is present, SecondaryIndividualInvestor and OtherIndividualInvestor
///       may be present. If PrimaryIndividualInvestor is not present, they are not allowed.
///     </description>
///   </item>
///   <item>
///     <term>CorporateRule</term>
///     <description>
///       If PrimaryCorporateInvestor is present, SecondaryCorporateInvestor and OtherCorporateInvestor
///       may be present. If PrimaryCorporateInvestor is not present, they are not allowed.
///     </description>
///   </item>
///   <item>
///     <term>DesignationRule</term>
///     <description>
///       If ProductTransfer/Portfolio/ISA is present, TransferorAccount/Designation is not allowed.
///       Business-context constraint — cannot be enforced structurally.
///     </description>
///   </item>
///   <item>
///     <term>NomineeAccountServicerRule</term>
///     <description>
///       NomineeAccount/Servicer must be present when and only when different from TransferorAccount/Servicer.
///       Business-context constraint — cannot be enforced structurally.
///     </description>
///   </item>
/// </list>
/// </remarks>
public sealed class PEPISATransfer11Validator : AbstractValidator<PEPISATransfer11>
{
    public PEPISATransfer11Validator()
    {
        // ProductTransfer is 1..∞ but the C# model allows empty (model defect — see XML doc).
        RuleFor(x => x.ProductTransfer)
            .NotEmpty()
            .WithMessage(
                "PEPISATransfer11.ProductTransfer must contain at least one element (1..∞)."
            );

        // ── InvestorRule ─────────────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.PrimaryIndividualInvestor is not null
                || (x.SecondaryIndividualInvestor is null && x.OtherIndividualInvestor is null)
            )
            .WithName("InvestorRule")
            .WithMessage(
                "If PrimaryIndividualInvestor is not present, SecondaryIndividualInvestor and "
                    + "OtherIndividualInvestor must also be absent (InvestorRule)."
            );

        // ── CorporateRule ─────────────────────────────────────────────────────────────
        RuleFor(x => x)
            .Must(x =>
                x.PrimaryCorporateInvestor is not null
                || (x.SecondaryCorporateInvestor is null && x.OtherCorporateInvestor is null)
            )
            .WithName("CorporateRule")
            .WithMessage(
                "If PrimaryCorporateInvestor is not present, SecondaryCorporateInvestor and "
                    + "OtherCorporateInvestor must also be absent (CorporateRule)."
            );

        // ISARule, PorfolioRule, DesignationRule, NomineeAccountServicerRule: business-context only —
        // cannot be enforced structurally. See XML doc on this class for the full constraint text.
    }
}
