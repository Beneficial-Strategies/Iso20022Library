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
    [KnownType(typeof(Status33Choice.Proprietary))]
    [KnownType(typeof(Status33Choice.MatchingStatus))]
    [KnownType(typeof(Status33Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status33Choice.SettlementStatus))]
    [KnownType(typeof(Status33Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status33Choice.Proprietary),nameof(Status33Choice.Proprietary))]
    [JsonDerivedType(typeof(Status33Choice.MatchingStatus),nameof(Status33Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status33Choice.InferredMatchingStatus),nameof(Status33Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status33Choice.SettlementStatus),nameof(Status33Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status33Choice.InstructionProcessingStatus),nameof(Status33Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_waWF8yAeEeuyDZ-ukt4YRg")]
    [DisplayName("Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status33Choice_
    #else
    public abstract partial class Status33Choice_
    #endif
    {
    }
}
