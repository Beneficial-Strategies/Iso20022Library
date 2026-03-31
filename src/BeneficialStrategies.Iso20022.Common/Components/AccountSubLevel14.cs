// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 4).
/// </summary>
[IsoId("_s1xFgVjBEea1XpTdyimpLA")]
[DisplayName("Account Sub Level")]
public record AccountSubLevel14
{
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_tQ138VjBEea1XpTdyimpLA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_tQ1381jBEea1XpTdyimpLA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the sub-level account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_tQ139VjBEea1XpTdyimpLA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; }

    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_tQ1391jBEea1XpTdyimpLA")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public ValueList<BeneficialOwner2> BeneficialOwner { get; init; } = [];

    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account (sub-account level 4), for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    [IsoId("_xAhOsVjBEea1XpTdyimpLA")]
    [DisplayName("Balance Details")]
    [IsoXmlTag("BalDtls")]
    public ValueList<AggregateHoldingBalance3> BalanceDetails { get; init; } = [];

    /// <summary>
    /// Holdings of level 5.
    /// </summary>
    [IsoId("_tQ13-1jBEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl5")]
    public ValueList<AccountSubLevel15> AccountSubLevel5 { get; init; } = [];

    /// <summary>
    /// Difference in holdings between the sub-account at level 4 and the sub-accounts of level 5.
    /// </summary>
    [IsoId("_tQ13_VjBEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level 5 Difference")]
    [IsoXmlTag("AcctSubLvl5Diff")]
    public ValueList<AggregateHoldingBalance2> AccountSubLevel5Difference { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_tQ14AVjBEea1XpTdyimpLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
