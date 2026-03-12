// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide the processing status information of a deactivation instruction.
/// </summary>
[IsoId("_RkeBc9p-Ed-ak6NoX_4Aeg_1446345184")]
[DisplayName("Corporate Action Deactivation Instruction Processing Status")]
public partial record CorporateActionDeactivationInstructionProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RkeBdNp-Ed-ak6NoX_4Aeg_1449119144")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus6FormatChoice_ Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkeBddp-Ed-ak6NoX_4Aeg_1449119175")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
