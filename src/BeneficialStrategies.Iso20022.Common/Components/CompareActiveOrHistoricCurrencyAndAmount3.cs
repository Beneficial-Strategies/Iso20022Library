// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an active or historic currency and amount.
/// </summary>
[IsoId("_ZJ600a5jEeuo-IflVgGqiA")]
[DisplayName("Compare Active Or Historic Currency And Amount")]
public record CompareActiveOrHistoricCurrencyAndAmount3
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_ZZtkUa5jEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ActiveOrHistoricCurrencyAndAmount? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_ZZtkU65jEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ActiveOrHistoricCurrencyAndAmount? Value2 { get; init; }
}
