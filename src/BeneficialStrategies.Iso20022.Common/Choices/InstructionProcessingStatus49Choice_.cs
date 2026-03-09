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
    [KnownType(typeof(InstructionProcessingStatus49Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.Cancelled),nameof(InstructionProcessingStatus49Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus49Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.Rejected),nameof(InstructionProcessingStatus49Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.Pending),nameof(InstructionProcessingStatus49Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.DefaultAction),nameof(InstructionProcessingStatus49Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.StandingInstruction),nameof(InstructionProcessingStatus49Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.ProprietaryStatus),nameof(InstructionProcessingStatus49Choice.ProprietaryStatus))]
    #endif
    [IsoId("_piIs-ji7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Processing Status 49 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus49Choice_
    #else
    public abstract partial class InstructionProcessingStatus49Choice_
    #endif
    {
    }
}
