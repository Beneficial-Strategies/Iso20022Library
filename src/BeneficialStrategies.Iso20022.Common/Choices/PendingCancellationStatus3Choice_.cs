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
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus3Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus3Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationStatus3Choice.NotSpecifiedReason),nameof(PendingCancellationStatus3Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus3Choice.Reason),nameof(PendingCancellationStatus3Choice.Reason))]
    #endif
    [IsoId("_lFW2jQFnEeG2HcWTGfYeDQ")]
    [DisplayName("Pending Cancellation Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationStatus3Choice_
    #else
    public abstract partial class PendingCancellationStatus3Choice_
    #endif
    {
    }
}
