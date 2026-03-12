// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Explains the status of the related request.
/// </summary>
[IsoId("_RH29-Np-Ed-ak6NoX_4Aeg_-1267403879")]
[DisplayName("Request Handling")]
public partial record RequestHandling
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the request.
    /// </summary>
    [IsoId("_RH29-dp-Ed-ak6NoX_4Aeg_-1267403878")]
    [DisplayName("Status Code")]
    [IsoXmlTag("StsCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText StatusCode { get; init; } 
    
    /// <summary>
    /// Description of the status, in free format text.
    /// </summary>
    [IsoId("_RH29-tp-Ed-ak6NoX_4Aeg_-1267403877")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
