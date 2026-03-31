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
[IsoId("_Nb34KUGLEeWqy4niLuXETA")]
[DisplayName("Cash Parties")]
public record CashParties28
{
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_No9440GLEeWqy4niLuXETA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount120? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_No9460GLEeWqy4niLuXETA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount121? CreditorAgent { get; init; }

    /// <summary>
    /// Party that has reimbursed the account owner with funds to which they were legally entitled.
    /// </summary>
    [IsoId("_No9480GLEeWqy4niLuXETA")]
    [DisplayName("Market Claim Counterparty")]
    [IsoXmlTag("MktClmCtrPty")]
    public PartyIdentificationAndAccount120? MarketClaimCounterparty { get; init; }
}
