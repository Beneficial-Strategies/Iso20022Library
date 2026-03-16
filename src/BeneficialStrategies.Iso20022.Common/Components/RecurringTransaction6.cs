// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Recurring Transaction6.
/// </summary>
[IsoId("__gWKwZE-Ee6reqfAp4CunQ")]
[DisplayName("Recurring Transaction6")]
public partial record RecurringTransaction6
{
    #nullable enable

    /// <summary>
    /// Grace Period.
    /// </summary>
    [DisplayName("Grace Period")]
    [IsoXmlTag("GracePrd")]
    public ValueList<GracePeriod1> GracePeriod { get; init; } = [];

    /// <summary>
    /// Period Unit.
    /// </summary>
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency3Code? PeriodUnit { get; init; } 

    /// <summary>
    /// Plan Identification.
    /// </summary>
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    public IsoMax35Text? PlanIdentification { get; init; } 

    /// <summary>
    /// Plan Notice.
    /// </summary>
    [DisplayName("Plan Notice")]
    [IsoXmlTag("PlanNtce")]
    public ValueList<ActionMessage11> PlanNotice { get; init; } = [];

    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoNumber? SequenceNumber { get; init; } 

    
    #nullable disable
    
}
