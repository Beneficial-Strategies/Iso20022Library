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
[IsoId("_Ti1LlNp-Ed-ak6NoX_4Aeg_619121876")]
[DisplayName("Attendance Card")]
public partial record AttendanceCard1
{
    #nullable enable
    
    /// <summary>
    /// Information to be indicated on the attendance card.
    /// </summary>
    [IsoId("_Ti1Lldp-Ed-ak6NoX_4Aeg_1078113395")]
    [DisplayName("Attendance Card Labelling")]
    [IsoXmlTag("AttndncCardLbllg")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AttendanceCardLabelling { get; init; } 
    
    /// <summary>
    /// Specifies where the attendance card must be delivered.
    /// </summary>
    [IsoId("_Ti1Lltp-Ed-ak6NoX_4Aeg_-1809007332")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public required DeliveryPlace1Code DeliveryMethod { get; init; } 
    
    /// <summary>
    /// Name and address of a party.
    /// </summary>
    [IsoId("_Ti1Ll9p-Ed-ak6NoX_4Aeg_438967027")]
    [DisplayName("Other Address")]
    [IsoXmlTag("OthrAdr")]
    public NameAndAddress9? OtherAddress { get; init; } 
    
    
    #nullable disable
    
}
