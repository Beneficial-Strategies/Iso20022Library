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
    [KnownType(typeof(InstructionProcessingStatus25Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus25Choice.Cancelled),nameof(InstructionProcessingStatus25Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus25Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus25Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus25Choice.Rejected),nameof(InstructionProcessingStatus25Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus25Choice.Pending),nameof(InstructionProcessingStatus25Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus25Choice.DefaultAction),nameof(InstructionProcessingStatus25Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus25Choice.StandingInstruction),nameof(InstructionProcessingStatus25Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus25Choice.ProprietaryStatus),nameof(InstructionProcessingStatus25Choice.ProprietaryStatus))]
    #endif
    [IsoId("_cgnRW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Processing Status 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus25Choice_
    #else
    public abstract partial class InstructionProcessingStatus25Choice_
    #endif
    {
    }
}
