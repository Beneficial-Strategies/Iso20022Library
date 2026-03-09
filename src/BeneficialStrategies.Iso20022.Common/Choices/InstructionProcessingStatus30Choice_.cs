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
    [KnownType(typeof(InstructionProcessingStatus30Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus30Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus30Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus30Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus30Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus30Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus30Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus30Choice.Cancelled),nameof(InstructionProcessingStatus30Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus30Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus30Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus30Choice.Rejected),nameof(InstructionProcessingStatus30Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus30Choice.Pending),nameof(InstructionProcessingStatus30Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus30Choice.DefaultAction),nameof(InstructionProcessingStatus30Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus30Choice.StandingInstruction),nameof(InstructionProcessingStatus30Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus30Choice.ProprietaryStatus),nameof(InstructionProcessingStatus30Choice.ProprietaryStatus))]
    #endif
    [IsoId("_komxq5wsEeazcsnODTksnQ")]
    [DisplayName("Instruction Processing Status 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus30Choice_
    #else
    public abstract partial class InstructionProcessingStatus30Choice_
    #endif
    {
    }
}
