// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on an event that happened in a system.
/// </summary>
[IsoId("_Uslo-dp-Ed-ak6NoX_4Aeg_376982248")]
[DisplayName("Event")]
public record Event1
{
    /// <summary>
    /// Proprietary code used to specify an event that occurred in a system.
    /// </summary>
    [IsoId("_Uslo-tp-Ed-ak6NoX_4Aeg_698369494")]
    [DisplayName("Event Code")]
    [IsoXmlTag("EvtCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText EventCode { get; init; }

    /// <summary>
    /// Describes the parameters of an event which occurred in a system.
    /// </summary>
    [IsoId("_Uslo-9p-Ed-ak6NoX_4Aeg_871066371")]
    [DisplayName("Event Parameter")]
    [IsoXmlTag("EvtParam")]
    public SimpleValueList<IsoMax35Text> EventParameter { get; init; } = [];

    /// <summary>
    /// Free text used to describe an event which occurred in a system.
    /// </summary>
    [IsoId("_Uslo_Np-Ed-ak6NoX_4Aeg_924628764")]
    [DisplayName("Event Description")]
    [IsoXmlTag("EvtDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? EventDescription { get; init; }

    /// <summary>
    /// Date and time at which the event occurred.
    /// </summary>
    [IsoId("_UsvZ8Np-Ed-ak6NoX_4Aeg_2008271246")]
    [DisplayName("Event Time")]
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EventTime { get; init; }
}
