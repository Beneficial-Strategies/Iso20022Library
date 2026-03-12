// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information and conditions provided for the physical attendance to the meeting.  
/// </summary>
[IsoId("_eX9h8fNhEeqRfth943bvEA")]
[DisplayName("Attendance")]
public partial record Attendance2
{
    #nullable enable
    
    /// <summary>
    /// Conditions for physical admittance to the general meeting.
    /// </summary>
    [IsoId("_eylocfNhEeqRfth943bvEA")]
    [DisplayName("Admission Conditions")]
    [IsoXmlTag("AdmssnConds")]
    [MinLength(0)]
    [MaxLength(7)]
    public ValueList<AttendanceAdmissionConditions2> AdmissionConditions { get; init; } = new ValueList<AttendanceAdmissionConditions2>(){};
    
    /// <summary>
    /// Specifies how to order the attendance card or to give notice of attendance.
    /// </summary>
    [IsoId("_eyloc_NhEeqRfth943bvEA")]
    [DisplayName("Confirmation Information")]
    [IsoXmlTag("ConfInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ConfirmationInformation { get; init; } 
    
    /// <summary>
    /// Date and time by which the beneficial owner or agent must provide notification of its intention to participate in the meeting. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_eylodfNhEeqRfth943bvEA")]
    [DisplayName("Confirmation Deadline")]
    [IsoXmlTag("ConfDdln")]
    public DateFormat58Choice_? ConfirmationDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_eylod_NhEeqRfth943bvEA")]
    [DisplayName("Confirmation Market Deadline")]
    [IsoXmlTag("ConfMktDdln")]
    public DateFormat58Choice_? ConfirmationMarketDeadline { get; init; } 
    
    
    #nullable disable
    
}
