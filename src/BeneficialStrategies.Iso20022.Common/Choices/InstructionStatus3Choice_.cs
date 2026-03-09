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
    /// Status applying to the instruction request received.
    /// </summary>
    [KnownType(typeof(InstructionStatus3Choice.GlobalInstructionStatus))]
    [KnownType(typeof(InstructionStatus3Choice.DetailedInstructionStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionStatus3Choice.GlobalInstructionStatus),nameof(InstructionStatus3Choice.GlobalInstructionStatus))]
    [JsonDerivedType(typeof(InstructionStatus3Choice.DetailedInstructionStatus),nameof(InstructionStatus3Choice.DetailedInstructionStatus))]
    #endif
    [IsoId("_RCpGwtp-Ed-ak6NoX_4Aeg_1720173069")]
    [DisplayName("Instruction Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionStatus3Choice_
    #else
    public abstract partial class InstructionStatus3Choice_
    #endif
    {
    }
}
