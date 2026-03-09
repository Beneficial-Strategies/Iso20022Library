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
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_1esTRjL3EeKU9IrkkToqcw_223855287")]
[DisplayName("Corporate Action Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOptionSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOptionSD3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOptionSD3( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1e2EQDL3EeKU9IrkkToqcw_72030178")]
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
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_1e2EQTL3EeKU9IrkkToqcw_-1808275462")]
    [DisplayName("Extended Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedOptnFeatrs")]
    #endif
    [IsoXmlTag("XtndedOptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    #else
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the option will be processed as default by DTC (The Depository Trust Corporation) when no election is made.
    /// </summary>
    [IsoId("_1e2EQjL3EeKU9IrkkToqcw_-2125169151")]
    [DisplayName("DTC Default Option Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCDfltOptnFlg")]
    #endif
    [IsoXmlTag("DTCDfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCDefaultOptionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCDefaultOptionFlag { get; init; } 
    #else
    public System.String? DTCDefaultOptionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the option is announced/supported by the issuer/agent.
    /// </summary>
    [IsoId("_1e2EQzL3EeKU9IrkkToqcw_78045457")]
    [DisplayName("Issuer Supported Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrSpprtdFlg")]
    #endif
    [IsoXmlTag("IssrSpprtdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? IssuerSupportedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerSupportedFlag { get; init; } 
    #else
    public System.String? IssuerSupportedFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Certain tax authorities provide control numbers to investors to instruct on Foreign Tax Relief service at DTC (The Depository Trust Corporation). This flag notes which events have these requirements and requires the DTC participant to input the control numbers.
    /// </summary>
    [IsoId("_1e2ERDL3EeKU9IrkkToqcw_-15276405")]
    [DisplayName("DTC Tax Control Number Required Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCTaxCtrlNbReqrdFlg")]
    #endif
    [IsoXmlTag("DTCTaxCtrlNbReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCTaxControlNumberRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCTaxControlNumberRequiredFlag { get; init; } 
    #else
    public System.String? DTCTaxControlNumberRequiredFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
