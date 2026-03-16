// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Parties44.
/// </summary>
[IsoId("_kv-POZt3Ee-wQIOX0djF2w")]
[DisplayName("Cash Parties44")]
public partial record CashParties44
{
    #nullable enable

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount231? Creditor { get; init; } 

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount232? CreditorAgent { get; init; } 

    /// <summary>
    /// Market Claim Counterparty.
    /// </summary>
    [DisplayName("Market Claim Counterparty")]
    [IsoXmlTag("MktClmCtrPty")]
    public PartyIdentificationAndAccount231? MarketClaimCounterparty { get; init; } 

    
    #nullable disable
    
}
