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
    [KnownType(typeof(Status9Choice.Proprietary))]
    [KnownType(typeof(Status9Choice.MatchingStatus))]
    [KnownType(typeof(Status9Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status9Choice.SettlementStatus))]
    [KnownType(typeof(Status9Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status9Choice.Proprietary),nameof(Status9Choice.Proprietary))]
    [JsonDerivedType(typeof(Status9Choice.MatchingStatus),nameof(Status9Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status9Choice.InferredMatchingStatus),nameof(Status9Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status9Choice.SettlementStatus),nameof(Status9Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status9Choice.InstructionProcessingStatus),nameof(Status9Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_4BGc4f8dEeCrw_OT0uBMXQ")]
    [DisplayName("Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status9Choice_
    #else
    public abstract partial class Status9Choice_
    #endif
    {
    }
}
