// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides processing status of the movement cancellation request.
/// </summary>
[IsoId("_RlNoWNp-Ed-ak6NoX_4Aeg_1529464275")]
[DisplayName("Corporation Action Movement Processing Status")]
public partial record CorporationActionMovementProcessingStatus2
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RlXZUNp-Ed-ak6NoX_4Aeg_1888716114")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus2FormatChoice_ Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlXZUdp-Ed-ak6NoX_4Aeg_1888716340")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
