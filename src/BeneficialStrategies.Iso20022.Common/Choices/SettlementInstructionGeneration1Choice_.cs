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
    /// Choice of format for the settlement instruction generation.
    /// </summary>
    [KnownType(typeof(SettlementInstructionGeneration1Choice.Code))]
    [KnownType(typeof(SettlementInstructionGeneration1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementInstructionGeneration1Choice.Code),nameof(SettlementInstructionGeneration1Choice.Code))]
    [JsonDerivedType(typeof(SettlementInstructionGeneration1Choice.Proprietary),nameof(SettlementInstructionGeneration1Choice.Proprietary))]
    #endif
    [IsoId("_AbMjstokEeC60axPepSq7g_-1902988326")]
    [DisplayName("Settlement Instruction Generation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementInstructionGeneration1Choice_
    #else
    public abstract partial class SettlementInstructionGeneration1Choice_
    #endif
    {
    }
}
