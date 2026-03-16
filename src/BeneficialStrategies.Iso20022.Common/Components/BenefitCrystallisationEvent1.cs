// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the realisation of benefits taken from a pension.
/// </summary>
[IsoId("_N2Aj4LToEeiWMOV-LTfmAw")]
[DisplayName("Benefit Crystallisation Event")]
public record BenefitCrystallisationEvent1
{
    /// <summary>
    /// Type of crystallisation event.
    /// </summary>
    [IsoId("_UiBv9LToEeiWMOV-LTfmAw")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public DrawdownEventType1Choice_? EventType { get; init; }

    /// <summary>
    /// Number of the crystallisation event.
    /// </summary>
    [IsoId("_UiBv87ToEeiWMOV-LTfmAw")]
    [DisplayName("Event Number")]
    [IsoXmlTag("EvtNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EventNumber { get; init; }

    /// <summary>
    /// Date on which the crystallisation event was triggered.
    /// </summary>
    [IsoId("_UiBv8LToEeiWMOV-LTfmAw")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EventDate { get; init; }

    /// <summary>
    /// Amount of the crystallisation event.
    /// </summary>
    [IsoId("_UiBv8bToEeiWMOV-LTfmAw")]
    [DisplayName("Crystallisation Amount")]
    [IsoXmlTag("CrstllstnAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CrystallisationAmount { get; init; }

    /// <summary>
    /// Percentage of allowance used for the benefit crystallisation event.
    /// </summary>
    [IsoId("_UiBv8rToEeiWMOV-LTfmAw")]
    [DisplayName("Percentage Of Allowance")]
    [IsoXmlTag("PctgOfAllwnc")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfAllowance { get; init; }

    /// <summary>
    /// Additional information about the benefit crystallisation event.
    /// </summary>
    [IsoId("_UiBv9bToEeiWMOV-LTfmAw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
