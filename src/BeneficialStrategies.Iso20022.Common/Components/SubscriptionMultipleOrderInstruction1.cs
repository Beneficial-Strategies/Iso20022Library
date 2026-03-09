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
/// Information about a subscription multiple order.
/// </summary>
[IsoId("_UzJj-tp-Ed-ak6NoX_4Aeg_-563586890")]
[DisplayName("Subscription Multiple Order Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionMultipleOrderInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionMultipleOrderInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionMultipleOrderInstruction1( SubscriptionMultipleOrder2 reqMultipleOrderDetails )
    {
        MultipleOrderDetails = reqMultipleOrderDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_UzSt4Np-Ed-ak6NoX_4Aeg_2068096907")]
    [DisplayName("Multiple Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MltplOrdrDtls")]
    #endif
    [IsoXmlTag("MltplOrdrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionMultipleOrder2 MultipleOrderDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubscriptionMultipleOrder2 MultipleOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionMultipleOrder2 MultipleOrderDetails { get; init; } 
    #else
    public SubscriptionMultipleOrder2 MultipleOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_UzSt4dp-Ed-ak6NoX_4Aeg_37627214")]
    [DisplayName("Intermediary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyDtls")]
    #endif
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = new ValueList<Intermediary4>(){};
    
    /// <summary>
    /// Message is a copy.
    /// </summary>
    [IsoId("_UzSt4tp-Ed-ak6NoX_4Aeg_-35333257")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation1? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation1? CopyDetails { get; init; } 
    #else
    public CopyInformation1? CopyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UzSt49p-Ed-ak6NoX_4Aeg_979070629")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
