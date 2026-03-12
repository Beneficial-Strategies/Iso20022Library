// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the options for the time to maturity.
    /// </summary>
    [KnownType(typeof(TimeToMaturity1Choice.Period))]
    [KnownType(typeof(TimeToMaturity1Choice.Special))]
    [JsonDerivedType(typeof(TimeToMaturity1Choice.Period),nameof(TimeToMaturity1Choice.Period))]
    [JsonDerivedType(typeof(TimeToMaturity1Choice.Special),nameof(TimeToMaturity1Choice.Special))]
    [IsoId("_r8FOkMVaEeiYpLQka876sg")]
    [DisplayName("Time To Maturity 1 Choice")]
    public abstract partial record TimeToMaturity1Choice_
    {
    }
}
