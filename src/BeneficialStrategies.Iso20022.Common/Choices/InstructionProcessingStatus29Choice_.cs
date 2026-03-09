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
    [KnownType(typeof(InstructionProcessingStatus29Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus29Choice.Cancelled),nameof(InstructionProcessingStatus29Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus29Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus29Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus29Choice.Rejected),nameof(InstructionProcessingStatus29Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus29Choice.Pending),nameof(InstructionProcessingStatus29Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus29Choice.DefaultAction),nameof(InstructionProcessingStatus29Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus29Choice.StandingInstruction),nameof(InstructionProcessingStatus29Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus29Choice.ProprietaryStatus),nameof(InstructionProcessingStatus29Choice.ProprietaryStatus))]
    #endif
    [IsoId("_GZT1MYlqEeavwKddCbm3hg")]
    [DisplayName("Instruction Processing Status 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus29Choice_
    #else
    public abstract partial class InstructionProcessingStatus29Choice_
    #endif
    {
    }
}
