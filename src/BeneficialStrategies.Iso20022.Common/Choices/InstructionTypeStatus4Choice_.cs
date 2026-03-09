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
    [KnownType(typeof(InstructionTypeStatus4Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus4Choice.CancellationStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionTypeStatus4Choice.InstructionStatus),nameof(InstructionTypeStatus4Choice.InstructionStatus))]
    [JsonDerivedType(typeof(InstructionTypeStatus4Choice.CancellationStatus),nameof(InstructionTypeStatus4Choice.CancellationStatus))]
    #endif
    [IsoId("_ay2uYfNfEeqRfth943bvEA")]
    [DisplayName("Instruction Type Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionTypeStatus4Choice_
    #else
    public abstract partial class InstructionTypeStatus4Choice_
    #endif
    {
    }
}
