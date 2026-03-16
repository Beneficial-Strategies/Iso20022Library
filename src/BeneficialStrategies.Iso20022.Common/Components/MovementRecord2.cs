// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Movement Record2.
/// </summary>
[IsoId("_0BP6ATEyEe6g-ffJsqGiSA")]
[DisplayName("Movement Record2")]
public partial record MovementRecord2
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection5 Amount { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; } 

    /// <summary>
    /// Participant.
    /// </summary>
    [DisplayName("Participant")]
    [IsoXmlTag("Ptcpt")]
    public PartyIdentification272? Participant { get; init; } 

    /// <summary>
    /// Participant Account.
    /// </summary>
    [DisplayName("Participant Account")]
    [IsoXmlTag("PtcptAcct")]
    public CashAccount40? ParticipantAccount { get; init; } 

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; } 

    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoNumber? SequenceNumber { get; init; } 

    /// <summary>
    /// Settlement Agent.
    /// </summary>
    [DisplayName("Settlement Agent")]
    [IsoXmlTag("SttlmAgt")]
    public PartyIdentification272? SettlementAgent { get; init; } 

    /// <summary>
    /// Settlement Agent Account.
    /// </summary>
    [DisplayName("Settlement Agent Account")]
    [IsoXmlTag("SttlmAgtAcct")]
    public CashAccount40? SettlementAgentAccount { get; init; } 

    
    #nullable disable
    
}
