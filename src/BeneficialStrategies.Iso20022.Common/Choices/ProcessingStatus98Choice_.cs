// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the processing.
    /// </summary>
    [KnownType(typeof(ProcessingStatus98Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus98Choice.AlreadyMatchedAndAffirmed))]
    [KnownType(typeof(ProcessingStatus98Choice.DefaultAction))]
    [KnownType(typeof(ProcessingStatus98Choice.Done))]
    [KnownType(typeof(ProcessingStatus98Choice.ForcedRejection))]
    [KnownType(typeof(ProcessingStatus98Choice.FullyExecutedConfirmationSent))]
    [KnownType(typeof(ProcessingStatus98Choice.Future))]
    [KnownType(typeof(ProcessingStatus98Choice.Generated))]
    [KnownType(typeof(ProcessingStatus98Choice.InRepair))]
    [KnownType(typeof(ProcessingStatus98Choice.NoInstruction))]
    [KnownType(typeof(ProcessingStatus98Choice.OpenOrder))]
    [KnownType(typeof(ProcessingStatus98Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus98Choice.ReceivedAtIntermediary))]
    [KnownType(typeof(ProcessingStatus98Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus98Choice.SettlementInstructionSent))]
    [KnownType(typeof(ProcessingStatus98Choice.StandingInstruction))]
    [KnownType(typeof(ProcessingStatus98Choice.TradingSuspendedByStockExchange))]
    [KnownType(typeof(ProcessingStatus98Choice.Treated))]
    [KnownType(typeof(ProcessingStatus98Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.AcknowledgedAccepted),nameof(ProcessingStatus98Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.AlreadyMatchedAndAffirmed),nameof(ProcessingStatus98Choice.AlreadyMatchedAndAffirmed))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.DefaultAction),nameof(ProcessingStatus98Choice.DefaultAction))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.Done),nameof(ProcessingStatus98Choice.Done))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.ForcedRejection),nameof(ProcessingStatus98Choice.ForcedRejection))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.FullyExecutedConfirmationSent),nameof(ProcessingStatus98Choice.FullyExecutedConfirmationSent))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.Future),nameof(ProcessingStatus98Choice.Future))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.Generated),nameof(ProcessingStatus98Choice.Generated))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.InRepair),nameof(ProcessingStatus98Choice.InRepair))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.NoInstruction),nameof(ProcessingStatus98Choice.NoInstruction))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.OpenOrder),nameof(ProcessingStatus98Choice.OpenOrder))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.PendingProcessing),nameof(ProcessingStatus98Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.ReceivedAtIntermediary),nameof(ProcessingStatus98Choice.ReceivedAtIntermediary))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.Rejected),nameof(ProcessingStatus98Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.SettlementInstructionSent),nameof(ProcessingStatus98Choice.SettlementInstructionSent))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.StandingInstruction),nameof(ProcessingStatus98Choice.StandingInstruction))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.TradingSuspendedByStockExchange),nameof(ProcessingStatus98Choice.TradingSuspendedByStockExchange))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.Treated),nameof(ProcessingStatus98Choice.Treated))]
    [JsonDerivedType(typeof(ProcessingStatus98Choice.ProprietaryStatus),nameof(ProcessingStatus98Choice.ProprietaryStatus))]
    [IsoId("_xnOQMQarEe2phaVG0lYKTw")]
    [DisplayName("Processing Status 98 Choice")]
    public abstract partial record ProcessingStatus98Choice_
    {
    }
}
