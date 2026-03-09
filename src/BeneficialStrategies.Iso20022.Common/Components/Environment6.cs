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
/// Environment of the transaction.
/// </summary>
[IsoId("_cxLx8ECMEeeXpbqDpLawug")]
[DisplayName("Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Environment6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Environment6( CardData3 reqCard )
    {
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_nqpO0ECMEeeXpbqDpLawug")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification198? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification198? Acquirer { get; init; } 
    #else
    public PartyIdentification198? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_yXUz8ECMEeeXpbqDpLawug")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification198? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification198? Sender { get; init; } 
    #else
    public PartyIdentification198? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_5M6LsECMEeeXpbqDpLawug")]
    [DisplayName("Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvr")]
    #endif
    [IsoXmlTag("Rcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification198? Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification198? Receiver { get; init; } 
    #else
    public PartyIdentification198? Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_8miZ8ECMEeeXpbqDpLawug")]
    [DisplayName("Acceptor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accptr")]
    #endif
    [IsoXmlTag("Accptr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification199? Acceptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification199? Acceptor { get; init; } 
    #else
    public PartyIdentification199? Acceptor { get; set; } 
    #endif
    
    /// <summary>
    /// Person initiating a payment to the benefit of a payee.
    /// </summary>
    [IsoId("_Oa8PsECNEeeXpbqDpLawug")]
    [DisplayName("Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyer")]
    #endif
    [IsoXmlTag("Pyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification211? Payer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification211? Payer { get; init; } 
    #else
    public PartyIdentification211? Payer { get; set; } 
    #endif
    
    /// <summary>
    /// Person to the benefit of whom a payment is performed.
    /// </summary>
    [IsoId("_QE_WsECNEeeXpbqDpLawug")]
    [DisplayName("Payee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyee")]
    #endif
    [IsoXmlTag("Pyee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification211? Payee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification211? Payee { get; init; } 
    #else
    public PartyIdentification211? Payee { get; set; } 
    #endif
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_bB90QEqWEeenp6hmNprBHg")]
    [DisplayName("Terminal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Termnl")]
    #endif
    [IsoXmlTag("Termnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Terminal3? Terminal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Terminal3? Terminal { get; init; } 
    #else
    public Terminal3? Terminal { get; set; } 
    #endif
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_0Z1wkEqYEeenp6hmNprBHg")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardData3 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardData3 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardData3 Card { get; init; } 
    #else
    public CardData3 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_RrdQgEqZEeenp6hmNprBHg")]
    [DisplayName("Customer Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDvc")]
    #endif
    [IsoXmlTag("CstmrDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice2? CustomerDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice2? CustomerDevice { get; init; } 
    #else
    public CustomerDevice2? CustomerDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_VjLhEFHNEeeRzt0J6TBeaA")]
    [DisplayName("Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wllt")]
    #endif
    [IsoXmlTag("Wllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Wallet1? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Wallet1? Wallet { get; init; } 
    #else
    public Wallet1? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_tXZzIEqZEeenp6hmNprBHg")]
    [DisplayName("Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tkn")]
    #endif
    [IsoXmlTag("Tkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Token1? Token { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Token1? Token { get; init; } 
    #else
    public Token1? Token { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_XQw2sEqaEeenp6hmNprBHg")]
    [DisplayName("Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdhldr")]
    #endif
    [IsoXmlTag("Crdhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder15? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder15? Cardholder { get; init; } 
    #else
    public Cardholder15? Cardholder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
