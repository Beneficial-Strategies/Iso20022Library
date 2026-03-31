// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus1Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus1Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus1Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus1Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus1Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus1Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus1Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus1Choice.Cancelled),
        nameof(InstructionProcessingStatus1Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus1Choice.Accepted),
        nameof(InstructionProcessingStatus1Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus1Choice.Rejected),
        nameof(InstructionProcessingStatus1Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus1Choice.Pending),
        nameof(InstructionProcessingStatus1Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus1Choice.DefaultAction),
        nameof(InstructionProcessingStatus1Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus1Choice.StandingInstruction),
        nameof(InstructionProcessingStatus1Choice.StandingInstruction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus1Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus1Choice.ProprietaryStatus)
    )]
    [IsoId("_Qy2XSdp-Ed-ak6NoX_4Aeg_-802987889")]
    [DisplayName("Instruction Processing Status 1 Choice")]
    public abstract record InstructionProcessingStatus1Choice_ { }
}
