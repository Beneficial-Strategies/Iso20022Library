// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to specify the features that may apply to a corporate action option.
/// </summary>
[IsoId("_BAD3czFcEeGpgKb_ecoJPw")]
[DisplayName("Option Features Format 8 SD")]
public partial record OptionFeaturesFormat8SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_IjjxYFPHEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Use of pro ration when the corporate action event type code is TEND or BIDS.
    /// あん分比例方式の適用有無が「無し」「未定」「非設定」.
    /// </summary>
    [IsoId("_vc00wDFcEeGpgKb_ecoJPw")]
    [DisplayName("Pro Ration Type")]
    [IsoXmlTag("PrRatnTp")]
    public required ProrationType1Code ProRationType { get; init; } 
    
    
    #nullable disable
    
}
