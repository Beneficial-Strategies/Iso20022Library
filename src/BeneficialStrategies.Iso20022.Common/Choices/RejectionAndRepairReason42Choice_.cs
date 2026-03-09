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
    [KnownType(typeof(RejectionAndRepairReason42Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason42Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionAndRepairReason42Choice.Code),nameof(RejectionAndRepairReason42Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason42Choice.Proprietary),nameof(RejectionAndRepairReason42Choice.Proprietary))]
    #endif
    [IsoId("_ds1eGzi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection And Repair Reason 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason42Choice_
    #else
    public abstract partial class RejectionAndRepairReason42Choice_
    #endif
    {
    }
}
