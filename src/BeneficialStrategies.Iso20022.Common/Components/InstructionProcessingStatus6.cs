// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction Processing Status6.
/// </summary>
[IsoId("_YxFiR4Y_Ee-5eN4DwJpixA")]
[DisplayName("Instruction Processing Status6")]
public partial record InstructionProcessingStatus6
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax350Text? AdditionalInformation { get; init; } 

    /// <summary>
    /// Attendance Card Number.
    /// </summary>
    [DisplayName("Attendance Card Number")]
    [IsoXmlTag("AttndncCardNb")]
    public IsoMax35Text? AttendanceCardNumber { get; init; } 

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status11Code Status { get; init; } 

    
    #nullable disable
    
}
