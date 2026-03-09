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
    /// Choice of instruction type status.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus3Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus3Choice.CancellationStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionTypeStatus3Choice.InstructionStatus),nameof(InstructionTypeStatus3Choice.InstructionStatus))]
    [JsonDerivedType(typeof(InstructionTypeStatus3Choice.CancellationStatus),nameof(InstructionTypeStatus3Choice.CancellationStatus))]
    #endif
    [IsoId("_7xaDIa-nEemJ1NnLPsTFaw")]
    [DisplayName("Instruction Type Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionTypeStatus3Choice_
    #else
    public abstract partial class InstructionTypeStatus3Choice_
    #endif
    {
    }
}
