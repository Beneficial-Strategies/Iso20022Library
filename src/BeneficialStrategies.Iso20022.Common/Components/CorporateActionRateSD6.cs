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
[IsoId("_1kW2YjL3EeKU9IrkkToqcw_1154144563")]
[DisplayName("Corporate Action Rate SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRateSD6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionRateSD6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionRateSD6( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1kW2YzL3EeKU9IrkkToqcw_1801070650")]
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
    /// Corresponding rate of the security being disbursed as a result of the corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_1kW2ZDL3EeKU9IrkkToqcw_-1766701812")]
    [DisplayName("Declared Security Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdSctyRate")]
    #endif
    [IsoXmlTag("DclrdSctyRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD6Choice_? DeclaredSecurityRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD6Choice_? DeclaredSecurityRate { get; init; } 
    #else
    public CorporateActionRateSD6Choice_? DeclaredSecurityRate { get; set; } 
    #endif
    
    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    [IsoId("_1kW2ZTL3EeKU9IrkkToqcw_1489361583")]
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
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_1kgnYDL3EeKU9IrkkToqcw_729716764")]
    [DisplayName("Declared Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdFeeRate")]
    #endif
    [IsoXmlTag("DclrdFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormatSD1Choice_? DeclaredFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormatSD1Choice_? DeclaredFeeRate { get; init; } 
    #else
    public PriceFormatSD1Choice_? DeclaredFeeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
