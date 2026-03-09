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
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status39Choice.Proprietary))]
    [KnownType(typeof(Status39Choice.MatchingStatus))]
    [KnownType(typeof(Status39Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status39Choice.SettlementStatus))]
    [KnownType(typeof(Status39Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status39Choice.Proprietary),nameof(Status39Choice.Proprietary))]
    [JsonDerivedType(typeof(Status39Choice.MatchingStatus),nameof(Status39Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status39Choice.InferredMatchingStatus),nameof(Status39Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status39Choice.SettlementStatus),nameof(Status39Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status39Choice.InstructionProcessingStatus),nameof(Status39Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_gEIFaji8Eeydid5dcNPKvg")]
    [DisplayName("Status 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status39Choice_
    #else
    public abstract partial class Status39Choice_
    #endif
    {
    }
}
