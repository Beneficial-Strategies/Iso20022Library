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
    [KnownType(typeof(PendingCancellationReason7Choice.Code))]
    [KnownType(typeof(PendingCancellationReason7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationReason7Choice.Code),nameof(PendingCancellationReason7Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReason7Choice.Proprietary),nameof(PendingCancellationReason7Choice.Proprietary))]
    #endif
    [IsoId("_cHKO1bKjEemux5trsZcCpw")]
    [DisplayName("Pending Cancellation Reason 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationReason7Choice_
    #else
    public abstract partial class PendingCancellationReason7Choice_
    #endif
    {
    }
}
