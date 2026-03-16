// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies details related to the attendance card.
/// </summary>
[IsoId("_TiranNp-Ed-ak6NoX_4Aeg_-1547572395")]
[DisplayName("Attendance Card")]
public record AttendanceCard2
{
    /// <summary>
    /// Information to be indicated on the attendance card.
    /// </summary>
    [IsoId("_Tirandp-Ed-ak6NoX_4Aeg_-1547572386")]
    [DisplayName("Attendance Card Labelling")]
    [IsoXmlTag("AttndncCardLbllg")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AttendanceCardLabelling { get; init; }

    /// <summary>
    /// Specifies where the attendance card must be delivered.
    /// </summary>
    [IsoId("_Tirantp-Ed-ak6NoX_4Aeg_-1547572365")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public required DeliveryPlace1Code DeliveryMethod { get; init; }

    /// <summary>
    /// Name and address of a party.
    /// </summary>
    [IsoId("_Ti1LkNp-Ed-ak6NoX_4Aeg_-1547572073")]
    [DisplayName("Other Address")]
    [IsoXmlTag("OthrAdr")]
    public NameAndAddress9? OtherAddress { get; init; }
}
