// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of counterparty type.
    /// </summary>
    [KnownType(typeof(CurrencyToBuyOrSell1Choice.CurrencyToBuy))]
    [KnownType(typeof(CurrencyToBuyOrSell1Choice.CurrencyToSell))]
    [JsonDerivedType(
        typeof(CurrencyToBuyOrSell1Choice.CurrencyToBuy),
        nameof(CurrencyToBuyOrSell1Choice.CurrencyToBuy)
    )]
    [JsonDerivedType(
        typeof(CurrencyToBuyOrSell1Choice.CurrencyToSell),
        nameof(CurrencyToBuyOrSell1Choice.CurrencyToSell)
    )]
    [IsoId("_QsvIMdp-Ed-ak6NoX_4Aeg_-947619938")]
    [DisplayName("Currency To Buy Or Sell 1 Choice")]
    public abstract record CurrencyToBuyOrSell1Choice_ { }
}
