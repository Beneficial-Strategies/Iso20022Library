// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide the processing status information of information advice.
/// </summary>
[IsoId("_Rknycdp-Ed-ak6NoX_4Aeg_-910103872")]
[DisplayName("Corporate Action Information Processing Status")]
public partial record CorporateActionInformationProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_Rknyctp-Ed-ak6NoX_4Aeg_6027375")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus5FormatChoice_ Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rknyc9p-Ed-ak6NoX_4Aeg_6027405")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
