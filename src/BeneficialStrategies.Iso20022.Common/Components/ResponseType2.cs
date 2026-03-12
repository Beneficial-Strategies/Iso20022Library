// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
[IsoId("_MGZDwXuGEeSZrqGdHyoIrw")]
[DisplayName("Response Type")]
public partial record ResponseType2
{
    #nullable enable
    
    /// <summary>
    /// Result of the request message or advice message.
    /// </summary>
    [IsoId("_w3tPcHuGEeSZrqGdHyoIrw")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required Response3Code Result { get; init; } 
    
    /// <summary>
    /// Detail of the result.
    /// </summary>
    [IsoId("_vcAUMHuLEeSZrqGdHyoIrw")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public ResultDetail1Code? ResultDetails { get; init; } 
    
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_QIlfIHuMEeSZrqGdHyoIrw")]
    [DisplayName("Additional Result Information")]
    [IsoXmlTag("AddtlRsltInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalResultInformation { get; init; } 
    
    
    #nullable disable
    
}
