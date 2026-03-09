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
    [KnownType(typeof(Status2Choice.Proprietary))]
    [KnownType(typeof(Status2Choice.MatchingStatus))]
    [KnownType(typeof(Status2Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status2Choice.SettlementStatus))]
    [KnownType(typeof(Status2Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status2Choice.Proprietary),nameof(Status2Choice.Proprietary))]
    [JsonDerivedType(typeof(Status2Choice.MatchingStatus),nameof(Status2Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status2Choice.InferredMatchingStatus),nameof(Status2Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status2Choice.SettlementStatus),nameof(Status2Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status2Choice.InstructionProcessingStatus),nameof(Status2Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_UaQi09p-Ed-ak6NoX_4Aeg_1627831869")]
    [DisplayName("Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status2Choice_
    #else
    public abstract partial class Status2Choice_
    #endif
    {
    }
}
