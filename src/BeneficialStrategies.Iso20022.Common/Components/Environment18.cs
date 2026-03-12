// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction for Inquiry.
/// </summary>
[IsoId("_OSRyoYENEeu6D49Gi-ZPwQ")]
[DisplayName("Environment")]
public partial record Environment18
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_OX6gkYENEeu6D49Gi-ZPwQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; } 
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_vo-FYY2hEeuUX8RS9eNYdA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_OX6gk4ENEeu6D49Gi-ZPwQ")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_OX6glYENEeu6D49Gi-ZPwQ")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_OX6gl4ENEeu6D49Gi-ZPwQ")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public required PartyIdentification255 Acceptor { get; init; } 
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_xdkPgY2hEeuUX8RS9eNYdA")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_OX6gmYENEeu6D49Gi-ZPwQ")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal4? Terminal { get; init; } 
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_Aei9QUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_OX6gm4ENEeu6D49Gi-ZPwQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData6? Card { get; init; } 
    
    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_OX6gnYENEeu6D49Gi-ZPwQ")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice4? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_OX6gn4ENEeu6D49Gi-ZPwQ")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_OX6goYENEeu6D49Gi-ZPwQ")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; } 
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_OX6go4ENEeu6D49Gi-ZPwQ")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
