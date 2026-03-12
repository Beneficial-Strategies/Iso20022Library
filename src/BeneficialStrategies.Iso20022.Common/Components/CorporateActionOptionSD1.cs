// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_1jxAgzL3EeKU9IrkkToqcw_-2046343543")]
[DisplayName("Corporate Action Option SD")]
public partial record CorporateActionOptionSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1jxAhDL3EeKU9IrkkToqcw_1251551400")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_1jxAhTL3EeKU9IrkkToqcw_1817008026")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    
    /// <summary>
    /// Identifies whether the option will be processed as default by DTC (The Depository Trust Corporation) when no election is made.
    /// </summary>
    [IsoId("_1jxAhjL3EeKU9IrkkToqcw_-63297614")]
    [DisplayName("DTC Default Option Flag")]
    [IsoXmlTag("DTCDfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCDefaultOptionFlag { get; init; } 
    
    /// <summary>
    /// Certain tax authorities provide control numbers to investors to instruct on Foreign Tax Relief service at DTC (The Depository Trust Corporation). This flag notes which events have these requirements and requires the DTC participant to input the control numbers.
    /// </summary>
    [IsoId("_1j6KcDL3EeKU9IrkkToqcw_-1120148314")]
    [DisplayName("DTC Tax Control Number Required Flag")]
    [IsoXmlTag("DTCTaxCtrlNbReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCTaxControlNumberRequiredFlag { get; init; } 
    
    
    #nullable disable
    
}
