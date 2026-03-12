// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the error resulting from the processing of a request.
/// </summary>
[IsoId("_RIAu8Np-Ed-ak6NoX_4Aeg_-1266482168")]
[DisplayName("Error Handling")]
public partial record ErrorHandling2
{
    #nullable enable
    
    /// <summary>
    /// Specification of the error, in coded form.
    /// </summary>
    [IsoId("_RIAu8dp-Ed-ak6NoX_4Aeg_-1266482167")]
    [DisplayName("Error Code")]
    [IsoXmlTag("ErrCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ErrorCode { get; init; } 
    
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    [IsoId("_RIAu8tp-Ed-ak6NoX_4Aeg_-1266482166")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
