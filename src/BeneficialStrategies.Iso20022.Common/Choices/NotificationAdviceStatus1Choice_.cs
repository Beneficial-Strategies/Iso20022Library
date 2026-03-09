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
    /// Provides the status of a notification advice.
    /// </summary>
    [KnownType(typeof(NotificationAdviceStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(NotificationAdviceStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NotificationAdviceStatus1Choice.ProcessedStatus),nameof(NotificationAdviceStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(NotificationAdviceStatus1Choice.RejectedStatus),nameof(NotificationAdviceStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_Ri1Ctdp-Ed-ak6NoX_4Aeg_-997189670")]
    [DisplayName("Notification Advice Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NotificationAdviceStatus1Choice_
    #else
    public abstract partial class NotificationAdviceStatus1Choice_
    #endif
    {
    }
}
