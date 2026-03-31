// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents the assignment of a case to a party. Assignment is a step in the overall process of managing a case.
/// </summary>
[IsoId("_T9Dpetp-Ed-ak6NoX_4Aeg_588710247")]
[DisplayName("Case Assignment")]
public record CaseAssignment
{
    /// <summary>
    /// Identification of an assignment within a case.
    /// </summary>
    [IsoId("_T9Dpe9p-Ed-ak6NoX_4Aeg_588710282")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party that assigns the case to another party. This is also the sender of the message.
    /// </summary>
    [IsoId("_T9NacNp-Ed-ak6NoX_4Aeg_588710299")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier Assigner { get; init; }

    /// <summary>
    /// Party that the case is assigned to. This is also the receiver of the message.
    /// </summary>
    [IsoId("_T9Nacdp-Ed-ak6NoX_4Aeg_588710607")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier Assignee { get; init; }

    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    [IsoId("_T9Nactp-Ed-ak6NoX_4Aeg_588710650")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
