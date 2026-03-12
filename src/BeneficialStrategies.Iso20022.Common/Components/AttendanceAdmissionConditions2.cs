// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical attendance admission conditions for a meeting.
/// </summary>
[IsoId("_eyloefNhEeqRfth943bvEA")]
[DisplayName("Attendance Admission Conditions")]
public partial record AttendanceAdmissionConditions2
{
    #nullable enable
    
    /// <summary>
    /// Condition for physical admittance to the general meeting.
    /// </summary>
    [IsoId("_fLlXQfNhEeqRfth943bvEA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AttendanceAdmissionConditions2Code Code { get; init; } 
    
    /// <summary>
    /// Additional information on the conditions for physical admittance to the general meeting.
    /// </summary>
    [IsoId("_fLlXQ_NhEeqRfth943bvEA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
