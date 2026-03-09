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
    [KnownType(typeof(InstructionProcessingStatus20Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus20Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus20Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus20Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus20Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus20Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus20Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus20Choice.Cancelled),nameof(InstructionProcessingStatus20Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus20Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus20Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus20Choice.Rejected),nameof(InstructionProcessingStatus20Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus20Choice.Pending),nameof(InstructionProcessingStatus20Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus20Choice.DefaultAction),nameof(InstructionProcessingStatus20Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus20Choice.StandingInstruction),nameof(InstructionProcessingStatus20Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus20Choice.ProprietaryStatus),nameof(InstructionProcessingStatus20Choice.ProprietaryStatus))]
    #endif
    [IsoId("_iMJ4UVhYEeSewsfsZR0hxA")]
    [DisplayName("Instruction Processing Status 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus20Choice_
    #else
    public abstract partial class InstructionProcessingStatus20Choice_
    #endif
    {
    }
}
