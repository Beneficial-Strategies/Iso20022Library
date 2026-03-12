// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information of an election amendment request.
/// </summary>
[IsoId("_RkUQcNp-Ed-ak6NoX_4Aeg_-1531109168")]
[DisplayName("Corporate Action Amendment Processing Status")]
public partial record CorporateActionAmendmentProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RkUQcdp-Ed-ak6NoX_4Aeg_-1503403623")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus5FormatChoice_ Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkUQctp-Ed-ak6NoX_4Aeg_-1503403592")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
