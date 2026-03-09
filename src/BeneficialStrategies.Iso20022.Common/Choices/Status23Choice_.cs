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
    [KnownType(typeof(Status23Choice.Proprietary))]
    [KnownType(typeof(Status23Choice.MatchingStatus))]
    [KnownType(typeof(Status23Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status23Choice.SettlementStatus))]
    [KnownType(typeof(Status23Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status23Choice.Proprietary),nameof(Status23Choice.Proprietary))]
    [JsonDerivedType(typeof(Status23Choice.MatchingStatus),nameof(Status23Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status23Choice.InferredMatchingStatus),nameof(Status23Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status23Choice.SettlementStatus),nameof(Status23Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status23Choice.InstructionProcessingStatus),nameof(Status23Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_8VHUK5NLEeWGlc8L7oPDIg")]
    [DisplayName("Status 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status23Choice_
    #else
    public abstract partial class Status23Choice_
    #endif
    {
    }
}
