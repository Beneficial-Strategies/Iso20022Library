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
[IsoId("_ZKkmEYaYEeuSbct6WWD-Ng")]
[DisplayName("Environment")]
public partial record Environment23
{
    #nullable enable
    
    /// <summary>
    /// Party in contract with an Acceptor to acquire card payment transactions.
    /// </summary>
    [IsoId("_ZPErkYaYEeuSbct6WWD-Ng")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification263? Acquirer { get; init; } 
    
    /// <summary>
    /// Originator of the transaction.
    /// </summary>
    [IsoId("_ZPErk4aYEeuSbct6WWD-Ng")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_ZPErlYaYEeuSbct6WWD-Ng")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from another intermediary agent.
    /// </summary>
    [IsoId("_ZPErl4aYEeuSbct6WWD-Ng")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_ZPErmYaYEeuSbct6WWD-Ng")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification255? Acceptor { get; init; } 
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_ZPErm4aYEeuSbct6WWD-Ng")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_Lw7QcUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_ZPErnYaYEeuSbct6WWD-Ng")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData2? Card { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_ZPErn4aYEeuSbct6WWD-Ng")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; } 
    
    
    #nullable disable
    
}
