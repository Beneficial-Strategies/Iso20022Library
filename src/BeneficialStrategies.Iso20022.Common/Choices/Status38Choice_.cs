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
    [KnownType(typeof(Status38Choice.Proprietary))]
    [KnownType(typeof(Status38Choice.MatchingStatus))]
    [KnownType(typeof(Status38Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status38Choice.SettlementStatus))]
    [KnownType(typeof(Status38Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status38Choice.Proprietary),nameof(Status38Choice.Proprietary))]
    [JsonDerivedType(typeof(Status38Choice.MatchingStatus),nameof(Status38Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status38Choice.InferredMatchingStatus),nameof(Status38Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status38Choice.SettlementStatus),nameof(Status38Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status38Choice.InstructionProcessingStatus),nameof(Status38Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_cOdm5SW-EeygjNFjAlVoPA")]
    [DisplayName("Status 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status38Choice_
    #else
    public abstract partial class Status38Choice_
    #endif
    {
    }
}
