// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the transaction type as defined in the relevant regulation or explicit no data report.
    /// </summary>
    [KnownType(typeof(SettlementFailsDailyTransactionType1Choice.DataSetAction))]
    [KnownType(typeof(SettlementFailsDailyTransactionType1Choice.Data))]
    [JsonDerivedType(
        typeof(SettlementFailsDailyTransactionType1Choice.DataSetAction),
        nameof(SettlementFailsDailyTransactionType1Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(SettlementFailsDailyTransactionType1Choice.Data),
        nameof(SettlementFailsDailyTransactionType1Choice.Data)
    )]
    [IsoId("_9tfhEzOYEeqBfed1bmSPqg")]
    [DisplayName("Settlement Fails Daily Transaction Type 1 Choice")]
    public abstract record SettlementFailsDailyTransactionType1Choice_ { }
}
