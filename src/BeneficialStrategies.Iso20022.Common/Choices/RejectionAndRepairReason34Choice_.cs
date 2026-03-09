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
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason34Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason34Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionAndRepairReason34Choice.Code),nameof(RejectionAndRepairReason34Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason34Choice.Proprietary),nameof(RejectionAndRepairReason34Choice.Proprietary))]
    #endif
    [IsoId("_m8KAseGKEeWCAvUNsZ5u6g")]
    [DisplayName("Rejection And Repair Reason 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason34Choice_
    #else
    public abstract partial class RejectionAndRepairReason34Choice_
    #endif
    {
    }
}
