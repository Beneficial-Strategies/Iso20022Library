// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between time and event fund transfer.
    /// </summary>
    [KnownType(typeof(DailyFundTransfer1Choice.TransferTime))]
    [KnownType(typeof(DailyFundTransfer1Choice.TransferEvent))]
    [JsonDerivedType(typeof(DailyFundTransfer1Choice.TransferTime),nameof(DailyFundTransfer1Choice.TransferTime))]
    [JsonDerivedType(typeof(DailyFundTransfer1Choice.TransferEvent),nameof(DailyFundTransfer1Choice.TransferEvent))]
    [IsoId("_mJGJgCc6Eea7avjfd7yDAA")]
    [DisplayName("Daily Fund Transfer 1 Choice")]
    public abstract partial record DailyFundTransfer1Choice_
    {
    }
}
