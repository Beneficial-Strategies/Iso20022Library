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
    /// Provides the dispute notification details for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(DisputeNotification2Choice.DisputeNotificationDetails))]
    [KnownType(typeof(DisputeNotification2Choice.SegregatedIndependentAmountDisputeDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DisputeNotification2Choice.DisputeNotificationDetails),nameof(DisputeNotification2Choice.DisputeNotificationDetails))]
    [JsonDerivedType(typeof(DisputeNotification2Choice.SegregatedIndependentAmountDisputeDetails),nameof(DisputeNotification2Choice.SegregatedIndependentAmountDisputeDetails))]
    #endif
    [IsoId("_KLqxkStOEeyOa655cLd-DQ")]
    [DisplayName("Dispute Notification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DisputeNotification2Choice_
    #else
    public abstract partial class DisputeNotification2Choice_
    #endif
    {
    }
}
