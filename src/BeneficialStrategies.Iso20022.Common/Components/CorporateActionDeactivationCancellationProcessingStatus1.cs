// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide the processing status information for a deactivation cancellation request.
/// </summary>
[IsoId("_RkUQdtp-Ed-ak6NoX_4Aeg_-484009564")]
[DisplayName("Corporate Action Deactivation Cancellation Processing Status")]
public partial record CorporateActionDeactivationCancellationProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RkUQd9p-Ed-ak6NoX_4Aeg_-429521886")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus2FormatChoice_ Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkUQeNp-Ed-ak6NoX_4Aeg_-429521855")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
