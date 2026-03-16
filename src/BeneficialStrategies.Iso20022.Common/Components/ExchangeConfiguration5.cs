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
[IsoId("_ywNIwTY6EeOYzMAJn8nuYA")]
[DisplayName("Exchange Configuration")]
public record ExchangeConfiguration5
{
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    [IsoId("_y_OcMTY6EeOYzMAJn8nuYA")]
    [DisplayName("Exchange Policy")]
    [IsoXmlTag("XchgPlcy")]
    public SimpleValueList<ExchangePolicy1Code> ExchangePolicy { get; init; } = [];

    // ID for the above is _y_OcMTY6EeOYzMAJn8nuYA

    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    [IsoId("_y_OcMzY6EeOYzMAJn8nuYA")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; }

    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    [IsoId("_y_OcNTY6EeOYzMAJn8nuYA")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Definition of retry process if activation of an action fails.
    /// </summary>
    [IsoId("_8LU_YDY6EeOYzMAJn8nuYA")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_y_OcNzY6EeOYzMAJn8nuYA")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming3? TimeCondition { get; init; }

    /// <summary>
    /// Failed transaction must be exchanged.
    /// </summary>
    [IsoId("_y_OcOTY6EeOYzMAJn8nuYA")]
    [DisplayName("Exchange Failed")]
    [IsoXmlTag("XchgFaild")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExchangeFailed { get; init; }

    /// <summary>
    /// Indicates that declined transaction must be exchanged.
    /// </summary>
    [IsoId("_y_OcOzY6EeOYzMAJn8nuYA")]
    [DisplayName("Exchange Declined")]
    [IsoXmlTag("XchgDclnd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExchangeDeclined { get; init; }
}
