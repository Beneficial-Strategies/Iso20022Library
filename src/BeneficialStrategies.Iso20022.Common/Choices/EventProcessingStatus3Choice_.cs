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
    [KnownType(typeof(EventProcessingStatus3Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus3Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus3Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus3Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.Complete),nameof(EventProcessingStatus3Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.Reconciled),nameof(EventProcessingStatus3Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.Pending),nameof(EventProcessingStatus3Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.ProprietaryStatus),nameof(EventProcessingStatus3Choice.ProprietaryStatus))]
    #endif
    [IsoId("_s1KyAUGSEeWqy4niLuXETA")]
    [DisplayName("Event Processing Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventProcessingStatus3Choice_
    #else
    public abstract partial class EventProcessingStatus3Choice_
    #endif
    {
    }
}
