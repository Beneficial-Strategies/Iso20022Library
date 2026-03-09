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
    [KnownType(typeof(Status30Choice.Proprietary))]
    [KnownType(typeof(Status30Choice.MatchingStatus))]
    [KnownType(typeof(Status30Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status30Choice.SettlementStatus))]
    [KnownType(typeof(Status30Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status30Choice.Proprietary),nameof(Status30Choice.Proprietary))]
    [JsonDerivedType(typeof(Status30Choice.MatchingStatus),nameof(Status30Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status30Choice.InferredMatchingStatus),nameof(Status30Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status30Choice.SettlementStatus),nameof(Status30Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status30Choice.InstructionProcessingStatus),nameof(Status30Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_iE4L6ffZEeiNZp_PtLohLw")]
    [DisplayName("Status 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status30Choice_
    #else
    public abstract partial class Status30Choice_
    #endif
    {
    }
}
