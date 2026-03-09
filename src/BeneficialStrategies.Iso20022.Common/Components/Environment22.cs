// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment related to the reconciliation of the transaction.
/// </summary>
[IsoId("_CCe7QYHZEeu02oZZRFgg6A")]
[DisplayName("Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [IsoId("_L58voIHZEeu02oZZRFgg6A")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Acquirer { get; init; } 
    #else
    public PartyIdentification263? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Initiator of the process.
    /// </summary>
    [IsoId("_CHjBcYHZEeu02oZZRFgg6A")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Originator { get; init; } 
    #else
    public PartyIdentification263? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the destination.
    /// </summary>
    [IsoId("_CHjBc4HZEeu02oZZRFgg6A")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Sender { get; init; } 
    #else
    public PartyIdentification263? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Party receiving the message from the originator or another intermediary agent.
    /// </summary>
    [IsoId("_CHjBdYHZEeu02oZZRFgg6A")]
    [DisplayName("Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvr")]
    #endif
    [IsoXmlTag("Rcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Receiver { get; init; } 
    #else
    public PartyIdentification263? Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor of the payment instrument.
    /// </summary>
    [IsoId("_FQ0YIIHcEeu02oZZRFgg6A")]
    [DisplayName("Acceptor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accptr")]
    #endif
    [IsoXmlTag("Accptr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification254? Acceptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification254? Acceptor { get; init; } 
    #else
    public PartyIdentification254? Acceptor { get; set; } 
    #endif
    
    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_gqoo8YHcEeu02oZZRFgg6A")]
    [DisplayName("Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyer")]
    #endif
    [IsoXmlTag("Pyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification257? Payer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification257? Payer { get; init; } 
    #else
    public PartyIdentification257? Payer { get; set; } 
    #endif
    
    /// <summary>
    /// The party receiving funds.
    /// </summary>
    [IsoId("_jLLTEYHcEeu02oZZRFgg6A")]
    [DisplayName("Payee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyee")]
    #endif
    [IsoXmlTag("Pyee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification257? Payee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification257? Payee { get; init; } 
    #else
    public PartyIdentification257? Payee { get; set; } 
    #endif
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_nzCPAYHcEeu02oZZRFgg6A")]
    [DisplayName("Terminal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Termnl")]
    #endif
    [IsoXmlTag("Termnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Terminal4? Terminal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Terminal4? Terminal { get; init; } 
    #else
    public Terminal4? Terminal { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_I1VpEUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Issuer { get; init; } 
    #else
    public PartyIdentification263? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_wWBjwYHcEeu02oZZRFgg6A")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardData8? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardData8? Card { get; init; } 
    #else
    public CardData8? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_CHjBd4HZEeu02oZZRFgg6A")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification263? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263? Destination { get; init; } 
    #else
    public PartyIdentification263? Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the customer device.
    /// </summary>
    [IsoId("_u_t6QIKvEeu4svNQ5N-l6w")]
    [DisplayName("Customer Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDvc")]
    #endif
    [IsoXmlTag("CstmrDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice4? CustomerDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice4? CustomerDevice { get; init; } 
    #else
    public CustomerDevice4? CustomerDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_yGodUYKuEeu4svNQ5N-l6w")]
    [DisplayName("Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wllt")]
    #endif
    [IsoXmlTag("Wllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Wallet2? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Wallet2? Wallet { get; init; } 
    #else
    public Wallet2? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_0a4-8YKuEeu4svNQ5N-l6w")]
    [DisplayName("Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tkn")]
    #endif
    [IsoXmlTag("Tkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Token3? Token { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Token3? Token { get; init; } 
    #else
    public Token3? Token { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_2mpE0YKuEeu4svNQ5N-l6w")]
    [DisplayName("Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdhldr")]
    #endif
    [IsoXmlTag("Crdhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder19? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder19? Cardholder { get; init; } 
    #else
    public Cardholder19? Cardholder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
