// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_hctRgYzREeutDIMngNCnkg")]
[DisplayName("Environment")]
public partial record Environment27
{
    #nullable enable
    
    /// <summary>
    /// financial institution (or its agent) at which the accounts are held by the parties settling. This institution, acting on information provided by the parties, transfers the appropriate funds between the accounts.
    /// </summary>
    [IsoId("_hiABMYzREeutDIMngNCnkg")]
    [DisplayName("Settlement Institution")]
    [IsoXmlTag("SttlmInstn")]
    public PartyIdentification263? SettlementInstitution { get; init; } 
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_p63JkYzREeutDIMngNCnkg")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the destination.
    /// </summary>
    [IsoId("_hiABM4zREeutDIMngNCnkg")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_hiABNYzREeutDIMngNCnkg")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_rtTXkYzREeutDIMngNCnkg")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// Financial Institution to which the settlement totals apply.
    /// </summary>
    [IsoId("_hiABN4zREeutDIMngNCnkg")]
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution6? FinancialInstitution { get; init; } 
    
    /// <summary>
    /// Additional institution involved in settlement. For example, the other party involved in bilateral settlement agreement.
    /// </summary>
    [IsoId("_hiABOYzREeutDIMngNCnkg")]
    [DisplayName("Other Institution")]
    [IsoXmlTag("OthrInstn")]
    public PartyIdentification258? OtherInstitution { get; init; } 
    
    
    #nullable disable
    
}
