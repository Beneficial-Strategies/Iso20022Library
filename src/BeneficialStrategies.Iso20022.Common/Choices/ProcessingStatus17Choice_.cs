// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the processing.
    /// </summary>
    [KnownType(typeof(ProcessingStatus17Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus17Choice.AlreadyMatchedAndAffirmed))]
    [KnownType(typeof(ProcessingStatus17Choice.DefaultAction))]
    [KnownType(typeof(ProcessingStatus17Choice.Done))]
    [KnownType(typeof(ProcessingStatus17Choice.ForcedRejection))]
    [KnownType(typeof(ProcessingStatus17Choice.FullyExecutedConfirmationSent))]
    [KnownType(typeof(ProcessingStatus17Choice.Future))]
    [KnownType(typeof(ProcessingStatus17Choice.Generated))]
    [KnownType(typeof(ProcessingStatus17Choice.InRepair))]
    [KnownType(typeof(ProcessingStatus17Choice.NoInstruction))]
    [KnownType(typeof(ProcessingStatus17Choice.OpenOrder))]
    [KnownType(typeof(ProcessingStatus17Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus17Choice.ReceivedAtIntermediary))]
    [KnownType(typeof(ProcessingStatus17Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus17Choice.SettlementInstructionSent))]
    [KnownType(typeof(ProcessingStatus17Choice.StandingInstruction))]
    [KnownType(typeof(ProcessingStatus17Choice.TradingSuspendedByStockExchange))]
    [KnownType(typeof(ProcessingStatus17Choice.Treated))]
    [KnownType(typeof(ProcessingStatus17Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus17Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.AlreadyMatchedAndAffirmed),
        nameof(ProcessingStatus17Choice.AlreadyMatchedAndAffirmed)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.DefaultAction),
        nameof(ProcessingStatus17Choice.DefaultAction)
    )]
    [JsonDerivedType(typeof(ProcessingStatus17Choice.Done), nameof(ProcessingStatus17Choice.Done))]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.ForcedRejection),
        nameof(ProcessingStatus17Choice.ForcedRejection)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.FullyExecutedConfirmationSent),
        nameof(ProcessingStatus17Choice.FullyExecutedConfirmationSent)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.Future),
        nameof(ProcessingStatus17Choice.Future)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.Generated),
        nameof(ProcessingStatus17Choice.Generated)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.InRepair),
        nameof(ProcessingStatus17Choice.InRepair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.NoInstruction),
        nameof(ProcessingStatus17Choice.NoInstruction)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.OpenOrder),
        nameof(ProcessingStatus17Choice.OpenOrder)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.PendingProcessing),
        nameof(ProcessingStatus17Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.ReceivedAtIntermediary),
        nameof(ProcessingStatus17Choice.ReceivedAtIntermediary)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.Rejected),
        nameof(ProcessingStatus17Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.SettlementInstructionSent),
        nameof(ProcessingStatus17Choice.SettlementInstructionSent)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.StandingInstruction),
        nameof(ProcessingStatus17Choice.StandingInstruction)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.TradingSuspendedByStockExchange),
        nameof(ProcessingStatus17Choice.TradingSuspendedByStockExchange)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.Treated),
        nameof(ProcessingStatus17Choice.Treated)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus17Choice.ProprietaryStatus),
        nameof(ProcessingStatus17Choice.ProprietaryStatus)
    )]
    [IsoId("_A42wEtokEeC60axPepSq7g_1414128802")]
    [DisplayName("Processing Status 17 Choice")]
    public abstract record ProcessingStatus17Choice_ { }
}
