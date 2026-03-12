// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the processing of the cancellation request.
/// </summary>
[IsoId("_RVkCxtp-Ed-ak6NoX_4Aeg_-1468645422")]
[DisplayName("Cancellation Processing Status")]
public partial record CancellationProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// Status of the request for cancellation.
    /// </summary>
    [IsoId("_RVkCx9p-Ed-ak6NoX_4Aeg_-1468645420")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required CancellationStatus3Code Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RVkCyNp-Ed-ak6NoX_4Aeg_-1468645405")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
