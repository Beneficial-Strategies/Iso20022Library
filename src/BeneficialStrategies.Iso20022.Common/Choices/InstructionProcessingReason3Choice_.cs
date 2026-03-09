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
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingReason3Choice.Reason))]
    [KnownType(typeof(InstructionProcessingReason3Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingReason3Choice.Reason),nameof(InstructionProcessingReason3Choice.Reason))]
    [JsonDerivedType(typeof(InstructionProcessingReason3Choice.NoSpecifiedReason),nameof(InstructionProcessingReason3Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_x4XDpwarEe2phaVG0lYKTw")]
    [DisplayName("Instruction Processing Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingReason3Choice_
    #else
    public abstract partial class InstructionProcessingReason3Choice_
    #endif
    {
    }
}
