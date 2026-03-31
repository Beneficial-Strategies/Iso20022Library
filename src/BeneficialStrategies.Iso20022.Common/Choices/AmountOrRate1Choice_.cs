// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(AmountOrRate1Choice.Amount))]
    [KnownType(typeof(AmountOrRate1Choice.Rate))]
    [JsonDerivedType(typeof(AmountOrRate1Choice.Amount), nameof(AmountOrRate1Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrRate1Choice.Rate), nameof(AmountOrRate1Choice.Rate))]
    [IsoId("_Q-UncNp-Ed-ak6NoX_4Aeg_458279675")]
    [DisplayName("Amount Or Rate 1 Choice")]
    public abstract record AmountOrRate1Choice_ { }
}
