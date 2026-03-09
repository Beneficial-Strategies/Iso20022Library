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
    [KnownType(typeof(InstructionProcessingReason2Choice.Reason))]
    [KnownType(typeof(InstructionProcessingReason2Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingReason2Choice.Reason),nameof(InstructionProcessingReason2Choice.Reason))]
    [JsonDerivedType(typeof(InstructionProcessingReason2Choice.NoSpecifiedReason),nameof(InstructionProcessingReason2Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_Azo449okEeC60axPepSq7g_-1958453728")]
    [DisplayName("Instruction Processing Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingReason2Choice_
    #else
    public abstract partial class InstructionProcessingReason2Choice_
    #endif
    {
    }
}
