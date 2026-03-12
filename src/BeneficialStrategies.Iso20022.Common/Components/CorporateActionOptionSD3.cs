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
[IsoId("_1esTRjL3EeKU9IrkkToqcw_223855287")]
[DisplayName("Corporate Action Option SD")]
public partial record CorporateActionOptionSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1e2EQDL3EeKU9IrkkToqcw_72030178")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_1e2EQTL3EeKU9IrkkToqcw_-1808275462")]
    [DisplayName("Extended Option Features")]
    [IsoXmlTag("XtndedOptnFeatrs")]
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    
    /// <summary>
    /// Identifies whether the option will be processed as default by DTC (The Depository Trust Corporation) when no election is made.
    /// </summary>
    [IsoId("_1e2EQjL3EeKU9IrkkToqcw_-2125169151")]
    [DisplayName("DTC Default Option Flag")]
    [IsoXmlTag("DTCDfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCDefaultOptionFlag { get; init; } 
    
    /// <summary>
    /// Identifies whether the option is announced/supported by the issuer/agent.
    /// </summary>
    [IsoId("_1e2EQzL3EeKU9IrkkToqcw_78045457")]
    [DisplayName("Issuer Supported Flag")]
    [IsoXmlTag("IssrSpprtdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? IssuerSupportedFlag { get; init; } 
    
    /// <summary>
    /// Certain tax authorities provide control numbers to investors to instruct on Foreign Tax Relief service at DTC (The Depository Trust Corporation). This flag notes which events have these requirements and requires the DTC participant to input the control numbers.
    /// </summary>
    [IsoId("_1e2ERDL3EeKU9IrkkToqcw_-15276405")]
    [DisplayName("DTC Tax Control Number Required Flag")]
    [IsoXmlTag("DTCTaxCtrlNbReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCTaxControlNumberRequiredFlag { get; init; } 
    
    
    #nullable disable
    
}
