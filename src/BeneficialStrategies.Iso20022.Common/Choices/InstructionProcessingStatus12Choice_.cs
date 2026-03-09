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
    [KnownType(typeof(InstructionProcessingStatus12Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus12Choice.Cancelled),nameof(InstructionProcessingStatus12Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus12Choice.Rejected),nameof(InstructionProcessingStatus12Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus12Choice.Pending),nameof(InstructionProcessingStatus12Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus12Choice.DefaultAction),nameof(InstructionProcessingStatus12Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus12Choice.StandingInstruction),nameof(InstructionProcessingStatus12Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus12Choice.ProprietaryStatus),nameof(InstructionProcessingStatus12Choice.ProprietaryStatus))]
    #endif
    [IsoId("_lg96YRN-EeKyONjZVQUqzg")]
    [DisplayName("Instruction Processing Status 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus12Choice_
    #else
    public abstract partial class InstructionProcessingStatus12Choice_
    #endif
    {
    }
}
