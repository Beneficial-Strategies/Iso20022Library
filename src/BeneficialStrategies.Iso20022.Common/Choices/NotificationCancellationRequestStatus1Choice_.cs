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
    /// Choice between various statuses.
    /// </summary>
    [KnownType(typeof(NotificationCancellationRequestStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(NotificationCancellationRequestStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NotificationCancellationRequestStatus1Choice.ProcessedStatus),nameof(NotificationCancellationRequestStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(NotificationCancellationRequestStatus1Choice.RejectedStatus),nameof(NotificationCancellationRequestStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_RiYWw9p-Ed-ak6NoX_4Aeg_-987032957")]
    [DisplayName("Notification Cancellation Request Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NotificationCancellationRequestStatus1Choice_
    #else
    public abstract partial class NotificationCancellationRequestStatus1Choice_
    #endif
    {
    }
}
