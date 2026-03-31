// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of data exchanges.
/// </summary>
[IsoId("_o_pqITY5EeOYzMAJn8nuYA")]
[DisplayName("Exchange Configuration")]
public record ExchangeConfiguration4
{
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    [IsoId("_pPIQkTY5EeOYzMAJn8nuYA")]
    [DisplayName("Exchange Policy")]
    [IsoXmlTag("XchgPlcy")]
    public SimpleValueList<ExchangePolicy1Code> ExchangePolicy { get; init; } = [];

    // ID for the above is _pPIQkTY5EeOYzMAJn8nuYA

    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    [IsoId("_pPIQkzY5EeOYzMAJn8nuYA")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; }

    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    [IsoId("_pPIQlTY5EeOYzMAJn8nuYA")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Definition of retry process if activation of an action fails.
    /// </summary>
    [IsoId("_xSx98DY5EeOYzMAJn8nuYA")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_pPIQlzY5EeOYzMAJn8nuYA")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming3? TimeCondition { get; init; }
}
