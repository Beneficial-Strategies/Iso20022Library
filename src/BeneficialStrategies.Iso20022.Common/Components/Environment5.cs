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
[IsoId("_tBScAVaIEeeFltjJxERUxw")]
[DisplayName("Environment")]
public partial record Environment5
{
    #nullable enable
    
    /// <summary>
    /// Party in contract with an Acceptor to acquire card payment transactions.
    /// </summary>
    [IsoId("_tMveEVaIEeeFltjJxERUxw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification197? Acquirer { get; init; } 
    
    /// <summary>
    /// Originator of the transaction.
    /// </summary>
    [IsoId("_B3yJwFaJEeeFltjJxERUxw")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification197? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_tMveE1aIEeeFltjJxERUxw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from another intermediary agent.
    /// </summary>
    [IsoId("_tMveFVaIEeeFltjJxERUxw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_jxmRwc5gEeiEmaZryQQ14Q")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification203? Acceptor { get; init; } 
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_KHVlIFaJEeeFltjJxERUxw")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification197? Destination { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_tMveH1aIEeeFltjJxERUxw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData2? Card { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_rBiXofGpEeiGNursv3uE_g")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; } 
    
    
    #nullable disable
    
}
