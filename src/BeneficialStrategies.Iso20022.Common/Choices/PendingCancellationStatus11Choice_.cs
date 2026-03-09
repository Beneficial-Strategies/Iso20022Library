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
    [KnownType(typeof(PendingCancellationStatus11Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus11Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationStatus11Choice.NotSpecifiedReason),nameof(PendingCancellationStatus11Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus11Choice.Reason),nameof(PendingCancellationStatus11Choice.Reason))]
    #endif
    [IsoId("_0BXX8RUOEeuYppTwWp55gA")]
    [DisplayName("Pending Cancellation Status 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationStatus11Choice_
    #else
    public abstract partial class PendingCancellationStatus11Choice_
    #endif
    {
    }
}
