// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 6).
/// </summary>
[IsoId("_FfhpgVjCEea1XpTdyimpLA")]
[DisplayName("Account Sub Level")]
public record AccountSubLevel16
{
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_F5trIVjCEea1XpTdyimpLA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_F5trI1jCEea1XpTdyimpLA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the sub-account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_F5trJVjCEea1XpTdyimpLA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; }

    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_F5trJ1jCEea1XpTdyimpLA")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public BeneficialOwner2? BeneficialOwner { get; init; }

    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account (sub-account level 6), for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    [IsoId("_IkM7cVjCEea1XpTdyimpLA")]
    [DisplayName("Balance Details")]
    [IsoXmlTag("BalDtls")]
    public AggregateHoldingBalance3? BalanceDetails { get; init; }

    /// <summary>
    /// Holdings of level 7.
    /// </summary>
    [IsoId("_F5trK1jCEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl7")]
    public AccountSubLevel17? AccountSubLevel7 { get; init; }

    /// <summary>
    /// Difference in holdings between the sub-account at level 6 and the sub-accounts of level 7.
    /// </summary>
    [IsoId("_F5trLVjCEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level 7 Difference")]
    [IsoXmlTag("AcctSubLvl7Diff")]
    public AggregateHoldingBalance2? AccountSubLevel7Difference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_F5trMVjCEea1XpTdyimpLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
