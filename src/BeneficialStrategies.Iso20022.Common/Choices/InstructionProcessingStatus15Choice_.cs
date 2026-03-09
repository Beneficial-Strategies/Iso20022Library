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
    [KnownType(typeof(InstructionProcessingStatus15Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus15Choice.Cancelled),nameof(InstructionProcessingStatus15Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus15Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus15Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus15Choice.Rejected),nameof(InstructionProcessingStatus15Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus15Choice.Pending),nameof(InstructionProcessingStatus15Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus15Choice.DefaultAction),nameof(InstructionProcessingStatus15Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus15Choice.StandingInstruction),nameof(InstructionProcessingStatus15Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus15Choice.ProprietaryStatus),nameof(InstructionProcessingStatus15Choice.ProprietaryStatus))]
    #endif
    [IsoId("_Rmr4ESdxEeOXAt_43VmZGw")]
    [DisplayName("Instruction Processing Status 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus15Choice_
    #else
    public abstract partial class InstructionProcessingStatus15Choice_
    #endif
    {
    }
}
