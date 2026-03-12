// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information about a request (e.g. financing request).
/// </summary>
[IsoId("_RX8oYtp-Ed-ak6NoX_4Aeg_-2024158417")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of additional information.
    /// </summary>
    [IsoId("_RX8oY9p-Ed-ak6NoX_4Aeg_-2024158415")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public required InformationType1Choice_ InformationType { get; init; } 
    
    /// <summary>
    /// Contents of the additional information.
    /// </summary>
    [IsoId("_RX8oZNp-Ed-ak6NoX_4Aeg_-2024158399")]
    [DisplayName("Information Value")]
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text InformationValue { get; init; } 
    
    
    #nullable disable
    
}
