// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITrackerData1"/>
[IsoId("_kOqpAIW2EeiDBOVr6AJAFA")]
[DisplayName("Tracker Data")]
public partial record TrackerData1
{
    /// <inheritdoc cref="ITrackerData1.ConfirmedDate"/>
    [IsoId("_n9zF0IW5EeiDBOVr6AJAFA")]
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; }

    /// <inheritdoc cref="ITrackerData1.ConfirmedAmount"/>
    [IsoId("_se8VwIW5EeiDBOVr6AJAFA")]
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; }

    /// <inheritdoc cref="ITrackerData1.TrackerRecord"/>
    [IsoId("_x5xmwIW5EeiDBOVr6AJAFA")]
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord1> TrackerRecord { get; init; } = [];
    // ID for the above is _x5xmwIW5EeiDBOVr6AJAFA
}
