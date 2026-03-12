// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to corporate action event cancellation status and reason.
/// </summary>
[IsoId("_sToAUzLqEeGG-ord8PjoKA")]
[DisplayName("Corporate Action Cancellation 2 SD")]
public partial record CorporateActionCancellation2SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_4MsTV3JUEeG0c8Yq2arGQg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Cancellation reason information in the local language.
    /// </summary>
    [IsoId("_1s_jcDLqEeGG-ord8PjoKA")]
    [DisplayName("Local Language Cancellation Reason")]
    [IsoXmlTag("LclLangCxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    public required IsoMax450Text LocalLanguageCancellationReason { get; init; } 
    
    
    #nullable disable
    
}
