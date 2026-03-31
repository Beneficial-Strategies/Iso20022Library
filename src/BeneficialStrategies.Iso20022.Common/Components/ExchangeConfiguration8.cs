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
[IsoId("_pgDf0Qu2Eeq4I6UJxZQ2Qw")]
[DisplayName("Exchange Configuration")]
public record ExchangeConfiguration8
{
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    [IsoId("_psBfQQu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Exchange Policy")]
    [IsoXmlTag("XchgPlcy")]
    public SimpleValueList<ExchangePolicy2Code> ExchangePolicy { get; init; } = [];

    // ID for the above is _psBfQQu2Eeq4I6UJxZQ2Qw

    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    [IsoId("_psBfQwu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; }

    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    [IsoId("_psBfRQu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Definition of retry process if activation of an action fails.
    /// </summary>
    [IsoId("_psBfRwu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_psBfSQu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming4? TimeCondition { get; init; }
}
