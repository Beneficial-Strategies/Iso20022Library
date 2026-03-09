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
    /// Provides information about the status of a corporate action or the status of a payment.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus4Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus4Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus4Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus4Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.Complete),nameof(EventProcessingStatus4Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.Reconciled),nameof(EventProcessingStatus4Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.Pending),nameof(EventProcessingStatus4Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.ProprietaryStatus),nameof(EventProcessingStatus4Choice.ProprietaryStatus))]
    #endif
    [IsoId("_cel395KQEeWHWpTQn1FFVg")]
    [DisplayName("Event Processing Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventProcessingStatus4Choice_
    #else
    public abstract partial class EventProcessingStatus4Choice_
    #endif
    {
    }
}
