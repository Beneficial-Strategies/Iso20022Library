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
[IsoId("_RN0cCtp-Ed-ak6NoX_4Aeg_-1747169582")]
[DisplayName("Subscription Multiple Order Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionMultipleOrderInstruction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionMultipleOrderInstruction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionMultipleOrderInstruction2( SubscriptionMultipleOrder3 reqMultipleOrderDetails )
    {
        MultipleOrderDetails = reqMultipleOrderDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_RN0cC9p-Ed-ak6NoX_4Aeg_-1747169251")]
    [DisplayName("Multiple Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MltplOrdrDtls")]
    #endif
    [IsoXmlTag("MltplOrdrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionMultipleOrder3 MultipleOrderDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubscriptionMultipleOrder3 MultipleOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionMultipleOrder3 MultipleOrderDetails { get; init; } 
    #else
    public SubscriptionMultipleOrder3 MultipleOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RN-NANp-Ed-ak6NoX_4Aeg_-1747169286")]
    [DisplayName("Related Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPtyDtls")]
    #endif
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = new ValueList<Intermediary8>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RN-NAdp-Ed-ak6NoX_4Aeg_-1747169321")]
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
