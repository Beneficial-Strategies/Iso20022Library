// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies cash parties in the framework of a corporate action event.
/// </summary>
[IsoId("_O7Www1kxEeSiQOnYSp7BZg")]
[DisplayName("Cash Parties")]
public record CashParties21
{
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_PYhNk1kxEeSiQOnYSp7BZg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount52? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PYhNm1kxEeSiQOnYSp7BZg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount101? CreditorAgent { get; init; }

    /// <summary>
    /// Party that has reimbursed the account owner with funds to which they were legally entitled.
    /// </summary>
    [IsoId("_PYhNo1kxEeSiQOnYSp7BZg")]
    [DisplayName("Market Claim Counterparty")]
    [IsoXmlTag("MktClmCtrPty")]
    public PartyIdentificationAndAccount52? MarketClaimCounterparty { get; init; }
}
