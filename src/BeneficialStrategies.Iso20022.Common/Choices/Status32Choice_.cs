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
    [KnownType(typeof(Status32Choice.Proprietary))]
    [KnownType(typeof(Status32Choice.MatchingStatus))]
    [KnownType(typeof(Status32Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status32Choice.SettlementStatus))]
    [KnownType(typeof(Status32Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status32Choice.Proprietary),nameof(Status32Choice.Proprietary))]
    [JsonDerivedType(typeof(Status32Choice.MatchingStatus),nameof(Status32Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status32Choice.InferredMatchingStatus),nameof(Status32Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status32Choice.SettlementStatus),nameof(Status32Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status32Choice.InstructionProcessingStatus),nameof(Status32Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_A4MfIQpIEeup4r-PFG2T5Q")]
    [DisplayName("Status 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status32Choice_
    #else
    public abstract partial class Status32Choice_
    #endif
    {
    }
}
