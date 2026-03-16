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
[IsoId("_8GmhP_fREeiNZp_PtLohLw")]
[DisplayName("Cash Parties")]
public record CashParties37
{
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_8GmhQ_fREeiNZp_PtLohLw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount174? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_8GmhS_fREeiNZp_PtLohLw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount175? CreditorAgent { get; init; }

    /// <summary>
    /// Party that has reimbursed the account owner with funds to which they were legally entitled.
    /// </summary>
    [IsoId("_8GmhU_fREeiNZp_PtLohLw")]
    [DisplayName("Market Claim Counterparty")]
    [IsoXmlTag("MktClmCtrPty")]
    public PartyIdentificationAndAccount174? MarketClaimCounterparty { get; init; }
}
