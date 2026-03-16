// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details about the system availability and the related system events that might impact the availability.
/// </summary>
[IsoId("_xbmERZlcEeeE1Ya-LgRsuQ")]
[DisplayName("System Availability And Events")]
public record SystemAvailabilityAndEvents2
{
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_xkRfI5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Currency")]
    [IsoXmlTag("SysCcy")]
    public ActiveCurrencyCode? SystemCurrency { get; init; }

    /// <summary>
    /// Time window of system activity.
    /// </summary>
    [IsoId("_xkRfJZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Session Period")]
    [IsoXmlTag("SsnPrd")]
    public TimePeriod1? SessionPeriod { get; init; }

    /// <summary>
    /// Detailed information about an event occurring on a system, whether planned, such as the cut-off time for a specific type of eligible transfer, or unplanned (an unsolicited failure), as stipulated in the specifications of the system.
    /// </summary>
    [IsoId("_xkRfJ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public SystemEvent2? Event { get; init; }

    /// <summary>
    /// Information regarding the closure time of a system.
    /// </summary>
    [IsoId("_xkRfKZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Closure Information")]
    [IsoXmlTag("ClsrInf")]
    public SystemClosure2? ClosureInformation { get; init; }
}
