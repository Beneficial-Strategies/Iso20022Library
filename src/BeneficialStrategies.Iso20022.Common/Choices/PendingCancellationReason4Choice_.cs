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
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason4Choice.Code))]
    [KnownType(typeof(PendingCancellationReason4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationReason4Choice.Code),nameof(PendingCancellationReason4Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReason4Choice.Proprietary),nameof(PendingCancellationReason4Choice.Proprietary))]
    #endif
    [IsoId("_ce_gw5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Cancellation Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationReason4Choice_
    #else
    public abstract partial class PendingCancellationReason4Choice_
    #endif
    {
    }
}
