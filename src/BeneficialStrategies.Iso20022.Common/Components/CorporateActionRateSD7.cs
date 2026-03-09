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
/// Provides additional information regarding corporate action option securities movement rate details.
/// </summary>
[IsoId("_1kgnYTL3EeKU9IrkkToqcw_-1578187294")]
[DisplayName("Corporate Action Rate SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRateSD7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionRateSD7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionRateSD7( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1kgnYjL3EeKU9IrkkToqcw_-753142535")]
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
    /// Corresponding rate of the security disbursed by CSD (for an example in US, DTC The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1kgnYzL3EeKU9IrkkToqcw_1661519121")]
    [DisplayName("CSD Security Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSDSctyRate")]
    #endif
    [IsoXmlTag("CSDSctyRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD6Choice_? CSDSecurityRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD6Choice_? CSDSecurityRate { get; init; } 
    #else
    public CorporateActionRateSD6Choice_? CSDSecurityRate { get; set; } 
    #endif
    
    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    [IsoId("_1kgnZDL3EeKU9IrkkToqcw_1261231895")]
    [DisplayName("Estimated Rate Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdRateFlg")]
    #endif
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EstimatedRateFlag { get; init; } 
    #else
    public System.String? EstimatedRateFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which a fee will be charged to a DTC (The Depository Trust Corporation) participant.
    /// </summary>
    [IsoId("_1kgnZTL3EeKU9IrkkToqcw_-358551397")]
    [DisplayName("DTC Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCFeeRate")]
    #endif
    [IsoXmlTag("DTCFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormatSD1Choice_? DTCFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormatSD1Choice_? DTCFeeRate { get; init; } 
    #else
    public PriceFormatSD1Choice_? DTCFeeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
