// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the settlement failure reason as defined in the relevant regulation or explicit no data report..
    /// </summary>
    [KnownType(typeof(SettlementDailyFailureReason1Choice.DataSetAction))]
    [KnownType(typeof(SettlementDailyFailureReason1Choice.Data))]
    [JsonDerivedType(typeof(SettlementDailyFailureReason1Choice.DataSetAction),nameof(SettlementDailyFailureReason1Choice.DataSetAction))]
    [JsonDerivedType(typeof(SettlementDailyFailureReason1Choice.Data),nameof(SettlementDailyFailureReason1Choice.Data))]
    [IsoId("_-7zQ0TOkEeqX8uoQQ3KffQ")]
    [DisplayName("Settlement Daily Failure Reason 1 Choice")]
    public abstract partial record SettlementDailyFailureReason1Choice_
    {
    }
}
