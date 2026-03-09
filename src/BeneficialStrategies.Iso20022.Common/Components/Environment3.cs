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
[IsoId("_3zNAcU93EeePXdaAO32Uew")]
[DisplayName("Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Initiator of the process.
    /// </summary>
    [IsoId("_3-g4kU93EeePXdaAO32Uew")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Originator { get; init; } 
    #else
    public PartyIdentification197? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the destination.
    /// </summary>
    [IsoId("_3-g4k093EeePXdaAO32Uew")]
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
    /// Party receiving the message from the originator or another intermediary agent.
    /// </summary>
    [IsoId("_3-g4lU93EeePXdaAO32Uew")]
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
    /// Destination of the message.
    /// </summary>
    [IsoId("_Pncm0E96EeePXdaAO32Uew")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Destination { get; init; } 
    #else
    public PartyIdentification197? Destination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
