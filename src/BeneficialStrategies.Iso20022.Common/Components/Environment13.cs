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
[IsoId("_CwhA8UP8EeiFlYmBVFSxUw")]
[DisplayName("Environment")]
public partial record Environment13
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_C83a4UP8EeiFlYmBVFSxUw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification197 Acquirer { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_C83a40P8EeiFlYmBVFSxUw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_C83a5UP8EeiFlYmBVFSxUw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_C83a50P8EeiFlYmBVFSxUw")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification203? Acceptor { get; init; } 
    
    /// <summary>
    /// Person initiating a payment to the benefit of a payee.
    /// </summary>
    [IsoId("_C83a6UP8EeiFlYmBVFSxUw")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification211? Payer { get; init; } 
    
    /// <summary>
    /// Person to the benefit of whom a payment is performed.
    /// </summary>
    [IsoId("_C83a60P8EeiFlYmBVFSxUw")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification211? Payee { get; init; } 
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_C83a7UP8EeiFlYmBVFSxUw")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal2? Terminal { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_C83a70P8EeiFlYmBVFSxUw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData5 Card { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_C83a80P8EeiFlYmBVFSxUw")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet1? Wallet { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_C83a9UP8EeiFlYmBVFSxUw")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; } 
    
    
    #nullable disable
    
}
