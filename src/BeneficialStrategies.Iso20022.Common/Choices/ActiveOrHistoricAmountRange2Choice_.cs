// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a range of amount values with or without the currency.
    /// </summary>
    [KnownType(typeof(ActiveOrHistoricAmountRange2Choice.ImpliedCurrencyAndAmountRange))]
    [KnownType(typeof(ActiveOrHistoricAmountRange2Choice.CurrencyAndAmountRange))]
    [JsonDerivedType(
        typeof(ActiveOrHistoricAmountRange2Choice.ImpliedCurrencyAndAmountRange),
        nameof(ActiveOrHistoricAmountRange2Choice.ImpliedCurrencyAndAmountRange)
    )]
    [JsonDerivedType(
        typeof(ActiveOrHistoricAmountRange2Choice.CurrencyAndAmountRange),
        nameof(ActiveOrHistoricAmountRange2Choice.CurrencyAndAmountRange)
    )]
    [IsoId("_PHbQeZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Active Or Historic Amount Range 2 Choice")]
    public abstract record ActiveOrHistoricAmountRange2Choice_ { }
}
