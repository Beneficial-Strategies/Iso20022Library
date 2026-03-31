// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains message reconciliation data.
/// </summary>
[IsoId("_LngKISFNEey8XKHwKquEQw")]
[DisplayName("Message Reconciliation")]
public record MessageReconciliation3
{
    /// <summary>
    /// Contains the reconciliation message type.
    /// </summary>
    [IsoId("_LuaDYSFNEey8XKHwKquEQw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReconciliationMessageType2Code Type { get; init; }

    /// <summary>
    /// Other reconciliation message type defined at national or private level.
    /// </summary>
    [IsoId("_LuaDYyFNEey8XKHwKquEQw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_LuaDZSFNEey8XKHwKquEQw")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; }
}
