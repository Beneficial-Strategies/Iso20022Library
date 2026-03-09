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
    [KnownType(typeof(RejectionAndRepairReason41Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason41Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionAndRepairReason41Choice.Code),nameof(RejectionAndRepairReason41Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason41Choice.Proprietary),nameof(RejectionAndRepairReason41Choice.Proprietary))]
    #endif
    [IsoId("_diXTqTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection And Repair Reason 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason41Choice_
    #else
    public abstract partial class RejectionAndRepairReason41Choice_
    #endif
    {
    }
}
