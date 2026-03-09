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
    /// Choice of instruction rejection status.
    /// </summary>
    [KnownType(typeof(InstructionRejectionStatus1Choice.Code))]
    [KnownType(typeof(InstructionRejectionStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionRejectionStatus1Choice.Code),nameof(InstructionRejectionStatus1Choice.Code))]
    [JsonDerivedType(typeof(InstructionRejectionStatus1Choice.Proprietary),nameof(InstructionRejectionStatus1Choice.Proprietary))]
    #endif
    [IsoId("_RCfVxdp-Ed-ak6NoX_4Aeg_-1295104262")]
    [DisplayName("Instruction Rejection Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionRejectionStatus1Choice_
    #else
    public abstract partial class InstructionRejectionStatus1Choice_
    #endif
    {
    }
}
