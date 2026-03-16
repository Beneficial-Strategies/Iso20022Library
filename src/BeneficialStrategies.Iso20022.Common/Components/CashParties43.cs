// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Parties43.
/// </summary>
[IsoId("_ozMp2ZBPEe-COKgew96POA")]
[DisplayName("Cash Parties43")]
public record CashParties43
{
    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount225? Creditor { get; init; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount226? CreditorAgent { get; init; }

    /// <summary>
    /// Market Claim Counterparty.
    /// </summary>
    [DisplayName("Market Claim Counterparty")]
    [IsoXmlTag("MktClmCtrPty")]
    public PartyIdentificationAndAccount225? MarketClaimCounterparty { get; init; }
}
