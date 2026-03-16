// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 2).
/// </summary>
[IsoId("_k54U94j2EeONZKAAW4pOaQ")]
[DisplayName("Account Sub Level")]
public record AccountSubLevel2
{
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_k548BYj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_k548AYj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the sub-account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_k548AIj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; }

    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_pxlkQTyvEeSBD_ZW60GwCQ")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public BeneficialOwner2? BeneficialOwner { get; init; }

    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    [IsoId("_k548Aoj2EeONZKAAW4pOaQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateHoldingBalance1? BalanceForAccount { get; init; }

    /// <summary>
    /// Holdings of level 3.
    /// </summary>
    [IsoId("_k548BIj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl3")]
    public AccountSubLevel3? AccountSubLevel3 { get; init; }

    /// <summary>
    /// Difference in holdings between the sub-account at level 2 and the sub-accounts of level 3.
    /// </summary>
    [IsoId("_k548A4j2EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level 3 Difference")]
    [IsoXmlTag("AcctSubLvl3Diff")]
    public AggregateHoldingBalance2? AccountSubLevel3Difference { get; init; }

    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    [IsoId("_JMltYb3OEeO2FLWuu_JIqg")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public Intermediary29? Agent { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ir58wW5HEeSFHPWGV34yZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
