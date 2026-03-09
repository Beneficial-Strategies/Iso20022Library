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
    [KnownType(typeof(InstructionProcessingStatus39Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus39Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.Cancelled),nameof(InstructionProcessingStatus39Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus39Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.Rejected),nameof(InstructionProcessingStatus39Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.Pending),nameof(InstructionProcessingStatus39Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.DefaultAction),nameof(InstructionProcessingStatus39Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.StandingInstruction),nameof(InstructionProcessingStatus39Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus39Choice.ProprietaryStatus),nameof(InstructionProcessingStatus39Choice.ProprietaryStatus))]
    #endif
    [IsoId("_Pl7SQAVSEeqjd8n6wD9JVw")]
    [DisplayName("Instruction Processing Status 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus39Choice_
    #else
    public abstract partial class InstructionProcessingStatus39Choice_
    #endif
    {
    }
}
