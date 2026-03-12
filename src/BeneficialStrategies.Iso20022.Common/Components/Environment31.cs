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
[IsoId("_XWJLIZx9EeuwYeL1lHu9zw")]
[DisplayName("Environment")]
public partial record Environment31
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// </summary>
    [IsoId("_XcGCIZx9EeuwYeL1lHu9zw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; } 
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_XcGCI5x9EeuwYeL1lHu9zw")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_XcGCJZx9EeuwYeL1lHu9zw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// </summary>
    [IsoId("_XcGCJ5x9EeuwYeL1lHu9zw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_XcGCKZx9EeuwYeL1lHu9zw")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification255? Acceptor { get; init; } 
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_XcGCK5x9EeuwYeL1lHu9zw")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_XcGCLZx9EeuwYeL1lHu9zw")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification257? Payer { get; init; } 
    
    /// <summary>
    /// The party receiving funds.
    /// </summary>
    [IsoId("_XcGCL5x9EeuwYeL1lHu9zw")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification257? Payee { get; init; } 
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_XcGCMZx9EeuwYeL1lHu9zw")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal4? Terminal { get; init; } 
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_ctEogUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_XcGCM5x9EeuwYeL1lHu9zw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData6? Card { get; init; } 
    
    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_XcGCNZx9EeuwYeL1lHu9zw")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice4? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_XcGCN5x9EeuwYeL1lHu9zw")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_XcGpMZx9EeuwYeL1lHu9zw")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token3? Token { get; init; } 
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_XcGpM5x9EeuwYeL1lHu9zw")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
