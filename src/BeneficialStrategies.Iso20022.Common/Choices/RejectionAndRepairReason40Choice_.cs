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
    [KnownType(typeof(RejectionAndRepairReason40Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason40Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionAndRepairReason40Choice.Code),nameof(RejectionAndRepairReason40Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason40Choice.Proprietary),nameof(RejectionAndRepairReason40Choice.Proprietary))]
    #endif
    [IsoId("_cdk09zi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection And Repair Reason 40 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason40Choice_
    #else
    public abstract partial class RejectionAndRepairReason40Choice_
    #endif
    {
    }
}
