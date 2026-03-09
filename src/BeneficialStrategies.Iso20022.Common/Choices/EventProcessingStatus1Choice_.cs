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
    [KnownType(typeof(EventProcessingStatus1Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus1Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus1Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus1Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventProcessingStatus1Choice.Complete),nameof(EventProcessingStatus1Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus1Choice.Reconciled),nameof(EventProcessingStatus1Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus1Choice.Pending),nameof(EventProcessingStatus1Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus1Choice.ProprietaryStatus),nameof(EventProcessingStatus1Choice.ProprietaryStatus))]
    #endif
    [IsoId("_QxzOZ9p-Ed-ak6NoX_4Aeg_-1514957759")]
    [DisplayName("Event Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventProcessingStatus1Choice_
    #else
    public abstract partial class EventProcessingStatus1Choice_
    #endif
    {
    }
}
