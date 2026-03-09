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
    [KnownType(typeof(PendingCancellationStatus9Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus9Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationStatus9Choice.NotSpecifiedReason),nameof(PendingCancellationStatus9Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus9Choice.Reason),nameof(PendingCancellationStatus9Choice.Reason))]
    #endif
    [IsoId("_3V7U8f0vEeiKOe8GCUL1Lg")]
    [DisplayName("Pending Cancellation Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationStatus9Choice_
    #else
    public abstract partial class PendingCancellationStatus9Choice_
    #endif
    {
    }
}
