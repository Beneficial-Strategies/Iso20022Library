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
    /// Choice of formats for an in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatusReason5Choice.Code))]
    [KnownType(typeof(InRepairStatusReason5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InRepairStatusReason5Choice.Code),nameof(InRepairStatusReason5Choice.Code))]
    [JsonDerivedType(typeof(InRepairStatusReason5Choice.Proprietary),nameof(InRepairStatusReason5Choice.Proprietary))]
    #endif
    [IsoId("_PjtfkUHqEea8I67lh6qdSQ")]
    [DisplayName("In Repair Status Reason 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InRepairStatusReason5Choice_
    #else
    public abstract partial class InRepairStatusReason5Choice_
    #endif
    {
    }
}
