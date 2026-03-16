// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Retailer Event6.
/// </summary>
[IsoId("_z5FKcZHzEe6qwqnYOGEReg")]
[DisplayName("Retailer Event6")]
public record RetailerEvent6
{
    /// <summary>
    /// Additional Event Information.
    /// </summary>
    [DisplayName("Additional Event Information")]
    [IsoXmlTag("AddtlEvtInf")]
    public IsoMax1025Text? AdditionalEventInformation { get; init; }

    /// <summary>
    /// Event Context.
    /// </summary>
    [DisplayName("Event Context")]
    [IsoXmlTag("EvtCntxt")]
    public EventContext6? EventContext { get; init; }

    /// <summary>
    /// Event Time Stamp.
    /// </summary>
    [DisplayName("Event Time Stamp")]
    [IsoXmlTag("EvtTmStmp")]
    public required IsoISODateTime EventTimeStamp { get; init; }

    /// <summary>
    /// Event To Notify.
    /// </summary>
    [DisplayName("Event To Notify")]
    [IsoXmlTag("EvtToNtfy")]
    public required EventToNotify2Code EventToNotify { get; init; }
}
