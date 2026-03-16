// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 7).
/// </summary>
[IsoId("_Lnjfp4j3EeONZKAAW4pOaQ")]
[DisplayName("Account Sub Level")]
public record AccountSubLevel7
{
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Lnjfq4j3EeONZKAAW4pOaQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_LnjfqYj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the sub-account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_LnjfrYj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; }

    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_0mPZoTyvEeSBD_ZW60GwCQ")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public BeneficialOwner2? BeneficialOwner { get; init; }

    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    [IsoId("_LnjfqIj3EeONZKAAW4pOaQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateHoldingBalance1? BalanceForAccount { get; init; }

    /// <summary>
    /// Holdings of level 8.
    /// </summary>
    [IsoId("_LnjfrIj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl8")]
    public AccountSubLevel8? AccountSubLevel8 { get; init; }

    /// <summary>
    /// Difference in holdings between the sub-account at level 7 and the sub-accounts of level 8.
    /// </summary>
    [IsoId("_Lnjfqoj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level 8 Difference")]
    [IsoXmlTag("AcctSubLvl8Diff")]
    public AggregateHoldingBalance2? AccountSubLevel8Difference { get; init; }

    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    [IsoId("_MWbMIb3OEeO2FLWuu_JIqg")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public Intermediary29? Agent { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_PESbIW5HEeSFHPWGV34yZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
