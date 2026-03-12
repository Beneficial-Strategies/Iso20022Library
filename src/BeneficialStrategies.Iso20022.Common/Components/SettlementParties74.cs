// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction.
/// </summary>
[IsoId("_QMUWcWpWEeipaMTLlhaKMQ")]
[DisplayName("Settlement Parties")]
public partial record SettlementParties74
{
    #nullable enable
    
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments. This party may be a transfer agent.
    /// </summary>
    [IsoId("_Qcij0WpWEeipaMTLlhaKMQ")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification141? Depository { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_Qcij2WpWEeipaMTLlhaKMQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount161? Party1 { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 1.
    /// </summary>
    [IsoId("_Qcij4WpWEeipaMTLlhaKMQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount161? Party2 { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 2.
    /// </summary>
    [IsoId("_Qcrts2pWEeipaMTLlhaKMQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount161? Party3 { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 3.
    /// </summary>
    [IsoId("_Qcrtx2pWEeipaMTLlhaKMQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount161? Party4 { get; init; } 
    
    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 4.
    /// </summary>
    [IsoId("_Qcrt1WpWEeipaMTLlhaKMQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount161? Party5 { get; init; } 
    
    
    #nullable disable
    
}
