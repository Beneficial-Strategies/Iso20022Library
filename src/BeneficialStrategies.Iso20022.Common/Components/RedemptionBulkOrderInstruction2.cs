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
/// Information about a redemption bulk order.
/// </summary>
[IsoId("_RO293Np-Ed-ak6NoX_4Aeg_-1015929589")]
[DisplayName("Redemption Bulk Order Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionBulkOrderInstruction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RedemptionBulkOrderInstruction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionBulkOrderInstruction2( RedemptionBulkOrder3 reqBulkOrderDetails )
    {
        BulkOrderDetails = reqBulkOrderDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common information related to all the orders.
    /// </summary>
    [IsoId("_RO293dp-Ed-ak6NoX_4Aeg_-1015929545")]
    [DisplayName("Bulk Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkOrdrDtls")]
    #endif
    [IsoXmlTag("BlkOrdrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RedemptionBulkOrder3 BulkOrderDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RedemptionBulkOrder3 BulkOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionBulkOrder3 BulkOrderDetails { get; init; } 
    #else
    public RedemptionBulkOrder3 BulkOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RO293tp-Ed-ak6NoX_4Aeg_-1015929503")]
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
    [IsoId("_RPAu0Np-Ed-ak6NoX_4Aeg_-1015929468")]
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
