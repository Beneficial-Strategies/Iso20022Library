// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITrackerData7"/>
[IsoId("_1YwfgTEyEe6g-ffJsqGiSA")]
[Description(@"Specifies the detailed information as provided by a payment tracking system.")]
[DisplayName("Tracker Data7")]
public partial record TrackerData7
{
    /// <inheritdoc cref="ITrackerData7.ConfirmedAmount"/>
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; }

    /// <inheritdoc cref="ITrackerData7.ConfirmedDate"/>
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; }

    /// <inheritdoc cref="ITrackerData7.TrackerRecord"/>
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord5> TrackerRecord { get; init; } = [];
}
