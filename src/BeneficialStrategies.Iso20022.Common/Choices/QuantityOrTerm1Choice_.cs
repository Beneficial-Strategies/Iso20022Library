// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates the schedule or frequency of the derivative transactions.
    /// </summary>
    [KnownType(typeof(QuantityOrTerm1Choice.SchedulePeriod))]
    [KnownType(typeof(QuantityOrTerm1Choice.Term))]
    [JsonDerivedType(
        typeof(QuantityOrTerm1Choice.SchedulePeriod),
        nameof(QuantityOrTerm1Choice.SchedulePeriod)
    )]
    [JsonDerivedType(typeof(QuantityOrTerm1Choice.Term), nameof(QuantityOrTerm1Choice.Term))]
    [IsoId("_VVI-wCJDEe2zWP9pqvmqdw")]
    [DisplayName("Quantity Or Term 1 Choice")]
    public abstract record QuantityOrTerm1Choice_ { }
}
