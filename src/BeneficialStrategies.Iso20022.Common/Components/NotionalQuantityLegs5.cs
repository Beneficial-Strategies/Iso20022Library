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
/// Indicates the notional quantity of the underlying assets.
/// </summary>
[IsoId("_Wc1UsSJFEe2zWP9pqvmqdw")]
[DisplayName("Notional Quantity Legs")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotionalQuantityLegs5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Aggregate notional quantity of the underlying asset of leg 1 for the term of the transaction. Where the total notional quantity is not known when a new transaction is reported, the total notional quantity is updated as it becomes available. 
    /// </summary>
    [IsoId("_WdpNASJFEe2zWP9pqvmqdw")]
    [DisplayName("First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstLeg")]
    #endif
    [IsoXmlTag("FrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalQuantity9? FirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalQuantity9? FirstLeg { get; init; } 
    #else
    public NotionalQuantity9? FirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregate notional quantity of the underlying asset of leg 2 for the term of the transaction. Where the total notional quantity is not known when a new transaction is reported, the total notional quantity is updated as it becomes available. 
    /// </summary>
    [IsoId("_WdpNAyJFEe2zWP9pqvmqdw")]
    [DisplayName("Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLeg")]
    #endif
    [IsoXmlTag("ScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalQuantity9? SecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalQuantity9? SecondLeg { get; init; } 
    #else
    public NotionalQuantity9? SecondLeg { get; set; } 
    #endif
    
    
    #nullable disable
    
}
