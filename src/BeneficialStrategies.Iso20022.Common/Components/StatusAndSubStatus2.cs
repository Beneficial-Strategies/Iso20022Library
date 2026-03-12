// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status and optionally the sub status.
/// </summary>
[IsoId("_Ka_gd5U7EeaYkf5FCqYMeA")]
[DisplayName("Status And Sub Status")]
public partial record StatusAndSubStatus2
{
    #nullable enable
    
    /// <summary>
    /// Status expressed as a code.
    /// </summary>
    [IsoId("_KmBEoZU7EeaYkf5FCqYMeA")]
    [DisplayName("Status Code")]
    [IsoXmlTag("StsCd")]
    public required Status27Choice_ StatusCode { get; init; } 
    
    /// <summary>
    /// Sub status expressed as a code.
    /// </summary>
    [IsoId("_KmBEo5U7EeaYkf5FCqYMeA")]
    [DisplayName("Sub Status Code")]
    [IsoXmlTag("SubStsCd")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SubStatusCode { get; init; } 
    
    
    #nullable disable
    
}
