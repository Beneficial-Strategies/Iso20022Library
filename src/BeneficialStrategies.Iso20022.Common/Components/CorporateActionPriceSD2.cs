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
/// Provides additional information regarding corporate action option securities movement price details.
/// </summary>
[IsoId("_1gVSBDL3EeKU9IrkkToqcw_-1227345487")]
[DisplayName("Corporate Action Price SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPriceSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionPriceSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionPriceSD2( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1gVSBTL3EeKU9IrkkToqcw_-229665491")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Price and currency at which cash will be paid for fractional shares (cash-in-lieu rate) by DTC (The Depository Trust Corporation). Used in conjunction with a rounding factor element.
    /// </summary>
    [IsoId("_1gfDADL3EeKU9IrkkToqcw_1074084746")]
    [DisplayName("DTC Cash In Lieu Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCCshInLieuPric")]
    #endif
    [IsoXmlTag("DTCCshInLieuPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat17Choice_? DTCCashInLieuPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat17Choice_? DTCCashInLieuPrice { get; init; } 
    #else
    public RateAndAmountFormat17Choice_? DTCCashInLieuPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
