// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for narative in the local language.
/// </summary>
[IsoId("_crFFczE6EeG99IlTgANSrw")]
[DisplayName("Corporate Action Narrative 17 SD")]
public partial record CorporateActionNarrative17SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_tnvZQFPIEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Other additional information in the local language.
    /// 備考.
    /// </summary>
    [IsoId("_3PPgoDE6EeG99IlTgANSrw")]
    [DisplayName("Other Additional Information")]
    [IsoXmlTag("OthrAddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    public required IsoMax450Text OtherAdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
