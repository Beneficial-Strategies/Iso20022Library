// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount with or without the currency.
    /// </summary>
    [KnownType(typeof(Amount2Choice.AmountWithoutCurrency))]
    [KnownType(typeof(Amount2Choice.AmountWithCurrency))]
    [JsonDerivedType(typeof(Amount2Choice.AmountWithoutCurrency),nameof(Amount2Choice.AmountWithoutCurrency))]
    [JsonDerivedType(typeof(Amount2Choice.AmountWithCurrency),nameof(Amount2Choice.AmountWithCurrency))]
    [IsoId("_75DzlKMgEeCJ6YNENx4h-w_890446015")]
    [DisplayName("Amount 2 Choice")]
    public abstract partial record Amount2Choice_
    {
    }
}
