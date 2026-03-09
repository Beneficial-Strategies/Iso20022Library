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
    [KnownType(typeof(InstructionProcessingStatus40Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus40Choice.Cancelled),nameof(InstructionProcessingStatus40Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus40Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus40Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus40Choice.Rejected),nameof(InstructionProcessingStatus40Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus40Choice.Pending),nameof(InstructionProcessingStatus40Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus40Choice.DefaultAction),nameof(InstructionProcessingStatus40Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus40Choice.StandingInstruction),nameof(InstructionProcessingStatus40Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus40Choice.ProprietaryStatus),nameof(InstructionProcessingStatus40Choice.ProprietaryStatus))]
    #endif
    [IsoId("_abidwe6BEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Processing Status 40 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus40Choice_
    #else
    public abstract partial class InstructionProcessingStatus40Choice_
    #endif
    {
    }
}
