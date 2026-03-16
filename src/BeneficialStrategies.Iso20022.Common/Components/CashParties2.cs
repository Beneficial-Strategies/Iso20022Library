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
[IsoId("_URnkQNp-Ed-ak6NoX_4Aeg_-770670532")]
[DisplayName("Cash Parties")]
public record CashParties2
{
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_URxVMNp-Ed-ak6NoX_4Aeg_-338464487")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount17? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_URxVMdp-Ed-ak6NoX_4Aeg_-283975800")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount18? CreditorAgent { get; init; }

    /// <summary>
    /// Party that has reimbursed the account owner with funds to which they were legally entitled.
    /// </summary>
    [IsoId("_URxVMtp-Ed-ak6NoX_4Aeg_1496573527")]
    [DisplayName("Market Claim Counterparty")]
    [IsoXmlTag("MktClmCtrPty")]
    public PartyIdentificationAndAccount17? MarketClaimCounterparty { get; init; }
}
