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
    [KnownType(typeof(Status29Choice.Proprietary))]
    [KnownType(typeof(Status29Choice.MatchingStatus))]
    [KnownType(typeof(Status29Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status29Choice.SettlementStatus))]
    [KnownType(typeof(Status29Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status29Choice.Proprietary),nameof(Status29Choice.Proprietary))]
    [JsonDerivedType(typeof(Status29Choice.MatchingStatus),nameof(Status29Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status29Choice.InferredMatchingStatus),nameof(Status29Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status29Choice.SettlementStatus),nameof(Status29Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status29Choice.InstructionProcessingStatus),nameof(Status29Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_IYQ_QdB7EeihG9bKfarOOA")]
    [DisplayName("Status 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status29Choice_
    #else
    public abstract partial class Status29Choice_
    #endif
    {
    }
}
