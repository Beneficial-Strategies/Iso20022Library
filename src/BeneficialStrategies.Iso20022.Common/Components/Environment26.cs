// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of a card transaction.
/// </summary>
[IsoId("_tr29sYzLEeujJfnIQ4NlpQ")]
[DisplayName("Environment")]
public partial record Environment26
{
    #nullable enable
    
    /// <summary>
    /// Party in a contractual relationship with an acceptor to acquire card payment transactions.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_txHRIYzLEeujJfnIQ4NlpQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; } 
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_7Q_9sIzLEeujJfnIQ4NlpQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_txHRI4zLEeujJfnIQ4NlpQ")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_txHRJYzLEeujJfnIQ4NlpQ")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_txHRJ4zLEeujJfnIQ4NlpQ")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification258? Acceptor { get; init; } 
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_BAIDsIzMEeujJfnIQ4NlpQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_txHRKYzLEeujJfnIQ4NlpQ")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal6? Terminal { get; init; } 
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_Tt3R0UYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_txHRK4zLEeujJfnIQ4NlpQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData9? Card { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_txHRLYzLEeujJfnIQ4NlpQ")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_txHRL4zLEeujJfnIQ4NlpQ")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; } 
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_atuTYSbUEeyhZIgCcGlTyA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
