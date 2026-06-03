// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies all information related to an event.
/// </summary>
[IsoId("_4mM3YbZ0EfCUZfsQO4rYeA")]
[DisplayName("Retailer Event8")]
public record RetailerEvent8
{
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    [IsoId("_4nHdZbZ0EfCUZfsQO4rYeA")]
    [DisplayName("Event Time Stamp")]
    [IsoXmlTag("EvtTmStmp")]
    public required IsoISODateTime EventTimeStamp { get; init; }

    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    [IsoId("_4nHda7Z0EfCUZfsQO4rYeA")]
    [DisplayName("Event To Notify")]
    [IsoXmlTag("EvtToNtfy")]
    public required EventToNotify2Code EventToNotify { get; init; }

    /// <summary>
    /// Context of the Event message.
    /// </summary>
    [IsoId("_4nHdcbZ0EfCUZfsQO4rYeA")]
    [DisplayName("Event Context")]
    [IsoXmlTag("EvtCntxt")]
    public EventContext8? EventContext { get; init; }

    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    [IsoId("_4nHdd7Z0EfCUZfsQO4rYeA")]
    [DisplayName("Additional Event Information")]
    [IsoXmlTag("AddtlEvtInf")]
    public IsoMax1025Text? AdditionalEventInformation { get; init; }
}
