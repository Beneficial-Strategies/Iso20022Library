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
    [KnownType(typeof(InstructionTypeStatus1Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus1Choice.CancellationStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionTypeStatus1Choice.InstructionStatus),nameof(InstructionTypeStatus1Choice.InstructionStatus))]
    [JsonDerivedType(typeof(InstructionTypeStatus1Choice.CancellationStatus),nameof(InstructionTypeStatus1Choice.CancellationStatus))]
    #endif
    [IsoId("_RCWL19p-Ed-ak6NoX_4Aeg_1310681941")]
    [DisplayName("Instruction Type Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionTypeStatus1Choice_
    #else
    public abstract partial class InstructionTypeStatus1Choice_
    #endif
    {
    }
}
