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
[IsoId("_AcyLYY2jEeuUX8RS9eNYdA")]
[DisplayName("Environment")]
public partial record Environment29
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_AjLuUY2jEeuUX8RS9eNYdA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; } 
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_Ihu5QY2jEeuUX8RS9eNYdA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_AjLuU42jEeuUX8RS9eNYdA")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_AjLuVY2jEeuUX8RS9eNYdA")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_AjLuV42jEeuUX8RS9eNYdA")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification258? Acceptor { get; init; } 
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_JqR1sY2jEeuUX8RS9eNYdA")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_AjLuWY2jEeuUX8RS9eNYdA")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal6? Terminal { get; init; } 
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_Yh9S8UYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_AjLuW42jEeuUX8RS9eNYdA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData10 Card { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_AjLuXY2jEeuUX8RS9eNYdA")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; } 
    
    
    #nullable disable
    
}
