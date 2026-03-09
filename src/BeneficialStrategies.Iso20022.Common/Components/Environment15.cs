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
/// Environment of the transaction for Inquiry.
/// </summary>
[IsoId("_YL5Y0UTKEeiHaMSBAy2r0A")]
[DisplayName("Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Environment15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Environment15( PartyIdentification197 reqAcquirer,PartyIdentification203 reqAcceptor,CardData4 reqCard )
    {
        Acquirer = reqAcquirer;
        Acceptor = reqAcceptor;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_YXp84UTKEeiHaMSBAy2r0A")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification197 Acquirer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification197 Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197 Acquirer { get; init; } 
    #else
    public PartyIdentification197 Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_YXp840TKEeiHaMSBAy2r0A")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Sender { get; init; } 
    #else
    public PartyIdentification197? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_YXp85UTKEeiHaMSBAy2r0A")]
    [DisplayName("Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvr")]
    #endif
    [IsoXmlTag("Rcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Receiver { get; init; } 
    #else
    public PartyIdentification197? Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_YXp850TKEeiHaMSBAy2r0A")]
    [DisplayName("Acceptor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accptr")]
    #endif
    [IsoXmlTag("Accptr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification203 Acceptor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification203 Acceptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification203 Acceptor { get; init; } 
    #else
    public PartyIdentification203 Acceptor { get; set; } 
    #endif
    
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_YXp86UTKEeiHaMSBAy2r0A")]
    [DisplayName("Terminal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Termnl")]
    #endif
    [IsoXmlTag("Termnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Terminal2? Terminal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Terminal2? Terminal { get; init; } 
    #else
    public Terminal2? Terminal { get; set; } 
    #endif
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_YXp860TKEeiHaMSBAy2r0A")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardData4 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardData4 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardData4 Card { get; init; } 
    #else
    public CardData4 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_YXp870TKEeiHaMSBAy2r0A")]
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
    [IsoId("_YXp88UTKEeiHaMSBAy2r0A")]
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
    
    
    #nullable disable
    
}
