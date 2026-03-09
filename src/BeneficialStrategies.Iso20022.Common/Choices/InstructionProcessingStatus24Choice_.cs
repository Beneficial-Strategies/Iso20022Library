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
    [KnownType(typeof(InstructionProcessingStatus24Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus24Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.Cancelled),nameof(InstructionProcessingStatus24Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus24Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.Rejected),nameof(InstructionProcessingStatus24Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.Pending),nameof(InstructionProcessingStatus24Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.DefaultAction),nameof(InstructionProcessingStatus24Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.StandingInstruction),nameof(InstructionProcessingStatus24Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus24Choice.ProprietaryStatus),nameof(InstructionProcessingStatus24Choice.ProprietaryStatus))]
    #endif
    [IsoId("_wj9GAUGUEeWqy4niLuXETA")]
    [DisplayName("Instruction Processing Status 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus24Choice_
    #else
    public abstract partial class InstructionProcessingStatus24Choice_
    #endif
    {
    }
}
