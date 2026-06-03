// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Element related to recurring transaction.
/// </summary>
[IsoId("__7K_AbZiEfCUZfsQO4rYeA")]
[DisplayName("Recurring Transaction7")]
public record RecurringTransaction7
{
    /// <summary>
    /// Identification of the recurring plan.
    /// </summary>
    [IsoId("__8FlBbZiEfCUZfsQO4rYeA")]
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    public IsoMax35Text? PlanIdentification { get; init; }

    /// <summary>
    /// Indicates the recurring occurrence of the transaction.
    /// </summary>
    [IsoId("__8FlC7ZiEfCUZfsQO4rYeA")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Period unit between consecutive payments.
    /// </summary>
    [IsoId("__8FlEbZiEfCUZfsQO4rYeA")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency3Code? PeriodUnit { get; init; }

    /// <summary>
    /// Contains grace period details.
    /// </summary>
    [IsoId("__8FlF7ZiEfCUZfsQO4rYeA")]
    [DisplayName("Grace Period")]
    [IsoXmlTag("GracePrd")]
    public ValueList<GracePeriod1> GracePeriod { get; init; } = [];

    /// <summary>
    /// Notice related to the RecurringPlan.
    /// </summary>
    [IsoId("__8FlHbZiEfCUZfsQO4rYeA")]
    [DisplayName("Plan Notice")]
    [IsoXmlTag("PlanNtce")]
    public ValueList<ActionMessage12> PlanNotice { get; init; } = [];
}
