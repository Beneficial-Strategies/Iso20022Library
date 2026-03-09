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
    [KnownType(typeof(InstructionProcessingStatus38Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.Cancelled),nameof(InstructionProcessingStatus38Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus38Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.Rejected),nameof(InstructionProcessingStatus38Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.Pending),nameof(InstructionProcessingStatus38Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.DefaultAction),nameof(InstructionProcessingStatus38Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.StandingInstruction),nameof(InstructionProcessingStatus38Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.ProprietaryStatus),nameof(InstructionProcessingStatus38Choice.ProprietaryStatus))]
    #endif
    [IsoId("_lbnRIeXyEemEj48jhmlA0Q")]
    [DisplayName("Instruction Processing Status 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus38Choice_
    #else
    public abstract partial class InstructionProcessingStatus38Choice_
    #endif
    {
    }
}
