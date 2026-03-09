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
    /// Type of instruction.
    /// </summary>
    [KnownType(typeof(InstructionType1Choice.InstructionIdentification))]
    [KnownType(typeof(InstructionType1Choice.InstructionCancellationIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionType1Choice.InstructionIdentification),nameof(InstructionType1Choice.InstructionIdentification))]
    [JsonDerivedType(typeof(InstructionType1Choice.InstructionCancellationIdentification),nameof(InstructionType1Choice.InstructionCancellationIdentification))]
    #endif
    [IsoId("_RCWL1Np-Ed-ak6NoX_4Aeg_869239445")]
    [DisplayName("Instruction Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionType1Choice_
    #else
    public abstract partial class InstructionType1Choice_
    #endif
    {
    }
}
