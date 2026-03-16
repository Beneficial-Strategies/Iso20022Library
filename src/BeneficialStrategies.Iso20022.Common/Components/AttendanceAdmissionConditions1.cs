// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical attendance admission conditions for a meeting.
/// </summary>
[IsoId("_7HCzcK4mEemG7MmivSuE5g")]
[DisplayName("Attendance Admission Conditions")]
public record AttendanceAdmissionConditions1
{
    /// <summary>
    /// Condition for physical admittance to general meetings expressed as a code.
    /// </summary>
    [IsoId("_Tr63cK4nEemG7MmivSuE5g")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AttendanceAdmissionConditions1Code Code { get; init; }

    /// <summary>
    /// Additional information on the conditions for physical admittance to general meeting.
    /// </summary>
    [IsoId("_bJHBwK4nEemG7MmivSuE5g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
