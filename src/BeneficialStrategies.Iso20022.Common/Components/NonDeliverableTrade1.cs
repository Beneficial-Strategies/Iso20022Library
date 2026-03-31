// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non Deliverable Trade1.
/// </summary>
[IsoId("_88IQQAiMEe-uqroL8NXzeA")]
[DisplayName("Non Deliverable Trade1")]
public record NonDeliverableTrade1
{
    /// <summary>
    /// Calculation Agent.
    /// </summary>
    [DisplayName("Calculation Agent")]
    [IsoXmlTag("")]
    public IsoExact4UpperCaseAlphaText? CalculationAgent { get; init; }

    /// <summary>
    /// Opening Indicator.
    /// </summary>
    [DisplayName("Opening Indicator")]
    [IsoXmlTag("")]
    public IsoYesNoIndicator? OpeningIndicator { get; init; }

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("")]
    public CurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Settlement Rate Source.
    /// </summary>
    [DisplayName("Settlement Rate Source")]
    [IsoXmlTag("")]
    public required FixingCondition1 SettlementRateSource { get; init; }

    /// <summary>
    /// Valuation Date.
    /// </summary>
    [DisplayName("Valuation Date")]
    [IsoXmlTag("")]
    public IsoISODate? ValuationDate { get; init; }
}
