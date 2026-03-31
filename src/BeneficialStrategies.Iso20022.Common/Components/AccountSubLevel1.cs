// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (level 1).
/// </summary>
[IsoId("_Ixtl_oj1EeONZKAAW4pOaQ")]
[DisplayName("Account Sub Level")]
public record AccountSubLevel1
{
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Ixtl_4j1EeONZKAAW4pOaQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_nW3xQYj1EeONZKAAW4pOaQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the sub-account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_oTsl4Yj1EeONZKAAW4pOaQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; }

    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_n2QgATyvEeSBD_ZW60GwCQ")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public ValueList<BeneficialOwner2> BeneficialOwner { get; init; } = [];

    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    [IsoId("_IxuM4oj1EeONZKAAW4pOaQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateHoldingBalance1> BalanceForAccount { get; init; } = [];

    /// <summary>
    /// Holdings of level 2.
    /// </summary>
    [IsoId("_IxuM4Ij1EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl2")]
    public ValueList<AccountSubLevel2> AccountSubLevel2 { get; init; } = [];

    /// <summary>
    /// Difference in holdings between the sub-account at level 1 and sub-accounts of level 2.
    /// </summary>
    [IsoId("_IxuM4Yj1EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level 2 Difference")]
    [IsoXmlTag("AcctSubLvl2Diff")]
    public ValueList<AggregateHoldingBalance2> AccountSubLevel2Difference { get; init; } = [];

    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    [IsoId("_MOd04KCAEeOEyO7fCl8lLA")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public ValueList<Intermediary29> Agent { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_HPN8UW5HEeSFHPWGV34yZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
