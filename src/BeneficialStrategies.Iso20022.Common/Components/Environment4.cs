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
[IsoId("_Mm3j8VA5EeedyPuM0kK2EQ")]
[DisplayName("Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Environment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Environment4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Environment4( Destination1 reqDestination )
    {
        Destination = reqDestination;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Originator of the message.
    /// </summary>
    [IsoId("_Mx4hIVA5EeedyPuM0kK2EQ")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Originator1? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Originator1? Originator { get; init; } 
    #else
    public Originator1? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_Mx4hJ1A5EeedyPuM0kK2EQ")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Destination1 Destination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Destination1 Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Destination1 Destination { get; init; } 
    #else
    public Destination1 Destination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
