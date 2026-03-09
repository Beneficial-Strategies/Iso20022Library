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
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status15Choice.Proprietary))]
    [KnownType(typeof(Status15Choice.MatchingStatus))]
    [KnownType(typeof(Status15Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status15Choice.SettlementStatus))]
    [KnownType(typeof(Status15Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status15Choice.Proprietary),nameof(Status15Choice.Proprietary))]
    [JsonDerivedType(typeof(Status15Choice.MatchingStatus),nameof(Status15Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status15Choice.InferredMatchingStatus),nameof(Status15Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status15Choice.SettlementStatus),nameof(Status15Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status15Choice.InstructionProcessingStatus),nameof(Status15Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_D9pP0yRhEeO8sskhVI3IDA")]
    [DisplayName("Status 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status15Choice_
    #else
    public abstract partial class Status15Choice_
    #endif
    {
    }
}
