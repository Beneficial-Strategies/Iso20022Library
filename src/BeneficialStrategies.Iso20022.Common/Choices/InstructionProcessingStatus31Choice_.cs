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
    [KnownType(typeof(InstructionProcessingStatus31Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus31Choice.Cancelled),nameof(InstructionProcessingStatus31Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus31Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus31Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus31Choice.Rejected),nameof(InstructionProcessingStatus31Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus31Choice.Pending),nameof(InstructionProcessingStatus31Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus31Choice.DefaultAction),nameof(InstructionProcessingStatus31Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus31Choice.StandingInstruction),nameof(InstructionProcessingStatus31Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus31Choice.ProprietaryStatus),nameof(InstructionProcessingStatus31Choice.ProprietaryStatus))]
    #endif
    [IsoId("_pHzPUbXTEeiTob_PrFFUxA")]
    [DisplayName("Instruction Processing Status 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus31Choice_
    #else
    public abstract partial class InstructionProcessingStatus31Choice_
    #endif
    {
    }
}
