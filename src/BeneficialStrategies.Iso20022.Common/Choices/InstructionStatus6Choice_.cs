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
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus6Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus6Choice.RejectionStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionStatus6Choice.ProcessingStatus),nameof(InstructionStatus6Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus6Choice.RejectionStatus),nameof(InstructionStatus6Choice.RejectionStatus))]
    #endif
    [IsoId("_r15wx16uEeSyc4g_pm5hbw")]
    [DisplayName("Instruction Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionStatus6Choice_
    #else
    public abstract partial class InstructionStatus6Choice_
    #endif
    {
    }
}
