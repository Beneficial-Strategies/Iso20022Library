// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment related to the reconciliation of the transaction.
/// </summary>
[IsoId("_CCe7QYHZEeu02oZZRFgg6A")]
[DisplayName("Environment")]
public partial record Environment22
{
    #nullable enable
    
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [IsoId("_L58voIHZEeu02oZZRFgg6A")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification263? Acquirer { get; init; } 
    
    /// <summary>
    /// Initiator of the process.
    /// </summary>
    [IsoId("_CHjBcYHZEeu02oZZRFgg6A")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the destination.
    /// </summary>
    [IsoId("_CHjBc4HZEeu02oZZRFgg6A")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the originator or another intermediary agent.
    /// </summary>
    [IsoId("_CHjBdYHZEeu02oZZRFgg6A")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Acceptor of the payment instrument.
    /// </summary>
    [IsoId("_FQ0YIIHcEeu02oZZRFgg6A")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification254? Acceptor { get; init; } 
    
    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_gqoo8YHcEeu02oZZRFgg6A")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification257? Payer { get; init; } 
    
    /// <summary>
    /// The party receiving funds.
    /// </summary>
    [IsoId("_jLLTEYHcEeu02oZZRFgg6A")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification257? Payee { get; init; } 
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_nzCPAYHcEeu02oZZRFgg6A")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal4? Terminal { get; init; } 
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_I1VpEUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_wWBjwYHcEeu02oZZRFgg6A")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData8? Card { get; init; } 
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_CHjBd4HZEeu02oZZRFgg6A")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// Details of the customer device.
    /// </summary>
    [IsoId("_u_t6QIKvEeu4svNQ5N-l6w")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice4? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_yGodUYKuEeu4svNQ5N-l6w")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_0a4-8YKuEeu4svNQ5N-l6w")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token3? Token { get; init; } 
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_2mpE0YKuEeu4svNQ5N-l6w")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
