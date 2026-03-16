// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the auto extend period.
    /// </summary>
    [KnownType(typeof(AutoExtend1Choice.Days))]
    [KnownType(typeof(AutoExtend1Choice.Months))]
    [KnownType(typeof(AutoExtend1Choice.Years))]
    [KnownType(typeof(AutoExtend1Choice.Date))]
    [JsonDerivedType(typeof(AutoExtend1Choice.Days), nameof(AutoExtend1Choice.Days))]
    [JsonDerivedType(typeof(AutoExtend1Choice.Months), nameof(AutoExtend1Choice.Months))]
    [JsonDerivedType(typeof(AutoExtend1Choice.Years), nameof(AutoExtend1Choice.Years))]
    [JsonDerivedType(typeof(AutoExtend1Choice.Date), nameof(AutoExtend1Choice.Date))]
    [IsoId("_95V5enltEeG7BsjMvd1mEw_-1540173231")]
    [DisplayName("Auto Extend 1 Choice")]
    public abstract record AutoExtend1Choice_ { }
}
