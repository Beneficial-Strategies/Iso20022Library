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
/// Environment of a card transaction.
/// </summary>
[IsoId("_tr29sYzLEeujJfnIQ4NlpQ")]
[DisplayName("Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Environment26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Environment26( PartyIdentification263 reqAcquirer )
    {
        Acquirer = reqAcquirer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party in a contractual relationship with an acceptor to acquire card payment transactions.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_txHRIYzLEeujJfnIQ4NlpQ")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification263 Acquirer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification263 Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification263 Acquirer { get; init; } 
    #else
    public PartyIdentification263 Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_7Q_9sIzLEeujJfnIQ4NlpQ")]
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
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_txHRI4zLEeujJfnIQ4NlpQ")]
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
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_txHRJYzLEeujJfnIQ4NlpQ")]
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
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_txHRJ4zLEeujJfnIQ4NlpQ")]
    [DisplayName("Acceptor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accptr")]
    #endif
    [IsoXmlTag("Accptr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification258? Acceptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification258? Acceptor { get; init; } 
    #else
    public PartyIdentification258? Acceptor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_BAIDsIzMEeujJfnIQ4NlpQ")]
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
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_txHRKYzLEeujJfnIQ4NlpQ")]
    [DisplayName("Terminal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Termnl")]
    #endif
    [IsoXmlTag("Termnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Terminal6? Terminal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Terminal6? Terminal { get; init; } 
    #else
    public Terminal6? Terminal { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_Tt3R0UYvEeydPZbwOuqbJQ")]
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
    [IsoId("_txHRK4zLEeujJfnIQ4NlpQ")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardData9? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardData9? Card { get; init; } 
    #else
    public CardData9? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_txHRLYzLEeujJfnIQ4NlpQ")]
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
    [IsoId("_txHRL4zLEeujJfnIQ4NlpQ")]
    [DisplayName("Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tkn")]
    #endif
    [IsoXmlTag("Tkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Token2? Token { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Token2? Token { get; init; } 
    #else
    public Token2? Token { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_atuTYSbUEeyhZIgCcGlTyA")]
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
