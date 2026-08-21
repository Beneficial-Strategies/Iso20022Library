// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the detailed information as provided by a payment tracking system.
/// </summary>
[IsoId("_1YwfgTEyEe6g-ffJsqGiSA")]
[Description(@"Specifies the detailed information as provided by a payment tracking system.")]
[DisplayName("Tracker Data7")]
public record TrackerData7
{
    /// <summary>
    /// Amount of money confirmed to the tracking system by the agent.
    /// </summary>
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; }

    /// <summary>
    /// Point in time when an update to the tracking system has been confirmed.
    /// Usage:
    /// This date can be the point in time when an agent provides a pending status update to the tracking system or when the creditor has been credited and can use the amount of money (as confirmed to the tracking system by the creditor agent).
    /// </summary>
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; }

    /// <summary>
    /// Provides tracker transaction information for a specific agent involved in the transaction chain.
    /// </summary>
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord5> TrackerRecord { get; init; } = [];
}
