// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus1Choice.Cancelled),nameof(InstructionProcessingStatus1Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus1Choice.Accepted),nameof(InstructionProcessingStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus1Choice.Rejected),nameof(InstructionProcessingStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus1Choice.Pending),nameof(InstructionProcessingStatus1Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus1Choice.DefaultAction),nameof(InstructionProcessingStatus1Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus1Choice.StandingInstruction),nameof(InstructionProcessingStatus1Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus1Choice.ProprietaryStatus),nameof(InstructionProcessingStatus1Choice.ProprietaryStatus))]
    #endif
    [IsoId("_Qy2XSdp-Ed-ak6NoX_4Aeg_-802987889")]
    [DisplayName("Instruction Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus1Choice_
    #else
    public abstract partial class InstructionProcessingStatus1Choice_
    #endif
    {
    }
}
