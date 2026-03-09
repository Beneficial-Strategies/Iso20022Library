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
    [KnownType(typeof(InstructionStatus11Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus11Choice.Rejected))]
    [KnownType(typeof(InstructionStatus11Choice.Pending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionStatus11Choice.ProcessingStatus),nameof(InstructionStatus11Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(InstructionStatus11Choice.Rejected),nameof(InstructionStatus11Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionStatus11Choice.Pending),nameof(InstructionStatus11Choice.Pending))]
    #endif
    [IsoId("_hY-q3RrpEeyhRdHRjakS2w")]
    [DisplayName("Instruction Status 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionStatus11Choice_
    #else
    public abstract partial class InstructionStatus11Choice_
    #endif
    {
    }
}
