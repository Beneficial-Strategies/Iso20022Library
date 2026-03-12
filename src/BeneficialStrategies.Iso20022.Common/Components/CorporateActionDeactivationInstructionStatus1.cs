// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides status of the deactivation instruction.
/// </summary>
[IsoId("_RjRuptp-Ed-ak6NoX_4Aeg_491823442")]
[DisplayName("Corporate Action Deactivation Instruction Status")]
public partial record CorporateActionDeactivationInstructionStatus1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_RjRup9p-Ed-ak6NoX_4Aeg_-5830420")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_RjbfoNp-Ed-ak6NoX_4Aeg_-5830390")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; } 
    
    /// <summary>
    /// Provides information about the processing status of the instruction.
    /// </summary>
    [IsoId("_Rjbfodp-Ed-ak6NoX_4Aeg_1462046019")]
    [DisplayName("Processed Status")]
    [IsoXmlTag("PrcdSts")]
    public required CorporateActionDeactivationInstructionProcessingStatus1 ProcessedStatus { get; init; } 
    
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Rjbfotp-Ed-ak6NoX_4Aeg_1560861725")]
    [DisplayName("Rejected Status")]
    [IsoXmlTag("RjctdSts")]
    public required CorporateActionDeactivationInstructionRejectionStatus1 RejectedStatus { get; init; } 
    
    
    #nullable disable
    
}
