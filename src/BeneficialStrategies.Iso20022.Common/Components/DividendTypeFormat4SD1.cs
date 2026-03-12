// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to specify additional information related to the type of dividend.
/// </summary>
[IsoId("_hZyZszLOEeGkgP4mOiMAHQ")]
[DisplayName("Dividend Type Format 4 SD")]
public partial record DividendTypeFormat4SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_TTCoUFPGEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Specifies whether the dividend is provisional 予想区分.
    /// If the value is No, then the dividend is actual.
    /// ProvisionalDividendFlag can only be used with corporate action event type code DVCA.
    /// </summary>
    [IsoId("_M9HrwDLPEeGkgP4mOiMAHQ")]
    [DisplayName("Provisional Dividend Flag")]
    [IsoXmlTag("PrvsnlDvddFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ProvisionalDividendFlag { get; init; } 
    
    /// <summary>
    /// Specifies whether the dividend includes commemorative dividend. 記念配当区分
    /// CommemorativeDividendFlag can only be used with corporate action event type code DVCA.
    /// </summary>
    [IsoId("_0OHUADLREeGkgP4mOiMAHQ")]
    [DisplayName("Commemorative Dividend Flag")]
    [IsoXmlTag("CommrtvDvddFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CommemorativeDividendFlag { get; init; } 
    
    /// <summary>
    /// Specifies whether the dividend includes special dividend.
    /// 特別配当区分
    /// SpecialDividendFlag can only be used with corporate action event type code DVCA.
    /// </summary>
    [IsoId("_f6l7ADLSEeGkgP4mOiMAHQ")]
    [DisplayName("Special Dividend Flag")]
    [IsoXmlTag("SpclDvddFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SpecialDividendFlag { get; init; } 
    
    
    #nullable disable
    
}
