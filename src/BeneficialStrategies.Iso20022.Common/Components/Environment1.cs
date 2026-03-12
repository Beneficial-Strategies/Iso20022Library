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
[IsoId("_mKbarewKEeiMkKo2clXHdQ")]
[DisplayName("Environment")]
public partial record Environment1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_mKbasOwKEeiMkKo2clXHdQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification197 Acquirer { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_mKbauewKEeiMkKo2clXHdQ")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_mKbas-wKEeiMkKo2clXHdQ")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_mKbatewKEeiMkKo2clXHdQ")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification203? Acceptor { get; init; } 
    
    /// <summary>
    /// Person initiating a payment to the benefit of a payee.
    /// </summary>
    [IsoId("_mKbatuwKEeiMkKo2clXHdQ")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification211? Payer { get; init; } 
    
    /// <summary>
    /// Person to the benefit of whom a payment is performed.
    /// ISO 8583:87/93/2003 bit 98
    /// </summary>
    [IsoId("_mKbaruwKEeiMkKo2clXHdQ")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification211? Payee { get; init; } 
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_mKbatOwKEeiMkKo2clXHdQ")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal1? Terminal { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_mKbat-wKEeiMkKo2clXHdQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData1 Card { get; init; } 
    
    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_mKbar-wKEeiMkKo2clXHdQ")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice2? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_mKbauOwKEeiMkKo2clXHdQ")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet1? Wallet { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_mKbasewKEeiMkKo2clXHdQ")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; } 
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_mKbasuwKEeiMkKo2clXHdQ")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder15? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
