// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information about a request.
/// </summary>
[IsoId("_SuAjPwEcEeCQm6a_G2yO_w_1862347907")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of additional information.
    /// </summary>
    [IsoId("_SuJtIAEcEeCQm6a_G2yO_w_1748508841")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public required ExternalInformationType1Code InformationType { get; init; } 
    
    /// <summary>
    /// Contents of the additional information.
    /// </summary>
    [IsoId("_SuJtIQEcEeCQm6a_G2yO_w_865275554")]
    [DisplayName("Information Value")]
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text InformationValue { get; init; } 
    
    
    #nullable disable
    
}
