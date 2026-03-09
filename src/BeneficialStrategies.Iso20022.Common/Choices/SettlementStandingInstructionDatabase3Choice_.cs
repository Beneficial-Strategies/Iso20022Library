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
    /// Choice of format for the standing settlement instruction information.
    /// </summary>
    [KnownType(typeof(SettlementStandingInstructionDatabase3Choice.Code))]
    [KnownType(typeof(SettlementStandingInstructionDatabase3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStandingInstructionDatabase3Choice.Code),nameof(SettlementStandingInstructionDatabase3Choice.Code))]
    [JsonDerivedType(typeof(SettlementStandingInstructionDatabase3Choice.Proprietary),nameof(SettlementStandingInstructionDatabase3Choice.Proprietary))]
    #endif
    [IsoId("_AbWUtdokEeC60axPepSq7g_-1066698614")]
    [DisplayName("Settlement Standing Instruction Database 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStandingInstructionDatabase3Choice_
    #else
    public abstract partial class SettlementStandingInstructionDatabase3Choice_
    #endif
    {
    }
}
