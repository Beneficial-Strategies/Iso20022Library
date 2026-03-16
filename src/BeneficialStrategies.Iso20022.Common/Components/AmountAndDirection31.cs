// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_nAYJZfNBEeCuA5Tr22BnwA_-22079")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection31
{
    /// <summary>
    /// Currency and value.
    /// </summary>
    [IsoId("_nAYJZvNBEeCuA5Tr22BnwA_621085085")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_nAYJZ_NBEeCuA5Tr22BnwA_-1693801787")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public ShortLong1Code? ShortLongIndicator { get; init; }
}
