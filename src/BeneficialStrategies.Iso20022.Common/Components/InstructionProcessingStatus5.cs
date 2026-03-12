// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the processing of the instruction.
/// </summary>
[IsoId("_MlQUUfNsEeqRfth943bvEA")]
[DisplayName("Instruction Processing Status")]
public partial record InstructionProcessingStatus5
{
    #nullable enable
    
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_M57j0fNsEeqRfth943bvEA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status9Code Status { get; init; } 
    
    /// <summary>
    /// Number of the admission ticket that has been granted by the custodian or the issuer.
    /// </summary>
    [IsoId("_f1l8kPNsEeqRfth943bvEA")]
    [DisplayName("Attendance Card Number")]
    [IsoXmlTag("AttndncCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AttendanceCardNumber { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_M57j0_NsEeqRfth943bvEA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
