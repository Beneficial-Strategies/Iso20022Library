// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the money laundering check.
    /// </summary>
    [KnownType(typeof(MoneyLaunderingCheck1Choice.Code))]
    [KnownType(typeof(MoneyLaunderingCheck1Choice.Proprietary))]
    [JsonDerivedType(typeof(MoneyLaunderingCheck1Choice.Code),nameof(MoneyLaunderingCheck1Choice.Code))]
    [JsonDerivedType(typeof(MoneyLaunderingCheck1Choice.Proprietary),nameof(MoneyLaunderingCheck1Choice.Proprietary))]
    [IsoId("_GExWwxdDEeK5g-3oYI0_9Q")]
    [DisplayName("Money Laundering Check 1 Choice")]
    public abstract partial record MoneyLaunderingCheck1Choice_
    {
    }
}
