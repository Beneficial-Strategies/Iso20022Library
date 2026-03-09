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
/// Specifies a shipment schedule, that is the quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
/// </summary>
[IsoId("_Sp5_hdp-Ed-ak6NoX_4Aeg_-1202382033")]
[DisplayName("Shipment Date Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShipmentDateRange2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ShipmentDateRange2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShipmentDateRange2( System.UInt64 reqSubQuantityValue )
    {
        SubQuantityValue = reqSubQuantityValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sub quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
    /// </summary>
    [IsoId("_Sp5_htp-Ed-ak6NoX_4Aeg_-1202382015")]
    [DisplayName("Sub Quantity Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubQtyVal")]
    #endif
    [IsoXmlTag("SubQtyVal")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber SubQuantityValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 SubQuantityValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 SubQuantityValue { get; init; } 
    #else
    public System.UInt64 SubQuantityValue { get; set; } 
    #endif
    
    /// <summary>
    /// Earliest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_Sp5_h9p-Ed-ak6NoX_4Aeg_-876378095")]
    [DisplayName("Earliest Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstShipmntDt")]
    #endif
    [IsoXmlTag("EarlstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EarliestShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EarliestShipmentDate { get; init; } 
    #else
    public System.DateOnly? EarliestShipmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Latest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_SqDwgNp-Ed-ak6NoX_4Aeg_-1202381938")]
    [DisplayName("Latest Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatstShipmntDt")]
    #endif
    [IsoXmlTag("LatstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LatestShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LatestShipmentDate { get; init; } 
    #else
    public System.DateOnly? LatestShipmentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
