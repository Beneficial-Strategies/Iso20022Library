// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies details related to the attendance card.
/// </summary>
[IsoId("_SFL9OfNrEeqRfth943bvEA")]
[DisplayName("Attendance Card")]
public partial record AttendanceCard3
{
    #nullable enable
    
    /// <summary>
    /// Information to be indicated on the attendance card.
    /// </summary>
    [IsoId("_SZHl1fNrEeqRfth943bvEA")]
    [DisplayName("Attendance Card Labelling")]
    [IsoXmlTag("AttndncCardLbllg")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AttendanceCardLabelling { get; init; } 
    
    /// <summary>
    /// Specifies where the attendance card must be delivered.
    /// </summary>
    [IsoId("_SZHl1_NrEeqRfth943bvEA")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public required DeliveryPlace3Code DeliveryMethod { get; init; } 
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_SZHl2fNrEeqRfth943bvEA")]
    [DisplayName("Other Address")]
    [IsoXmlTag("OthrAdr")]
    public NameAndAddress9? OtherAddress { get; init; } 
    
    
    #nullable disable
    
}
