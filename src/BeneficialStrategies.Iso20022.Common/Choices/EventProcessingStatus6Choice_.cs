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
    [KnownType(typeof(EventProcessingStatus6Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus6Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus6Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus6Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventProcessingStatus6Choice.Complete),nameof(EventProcessingStatus6Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus6Choice.Reconciled),nameof(EventProcessingStatus6Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus6Choice.Pending),nameof(EventProcessingStatus6Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus6Choice.ProprietaryStatus),nameof(EventProcessingStatus6Choice.ProprietaryStatus))]
    #endif
    [IsoId("_Szi6OgVREeqjd8n6wD9JVw")]
    [DisplayName("Event Processing Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventProcessingStatus6Choice_
    #else
    public abstract partial class EventProcessingStatus6Choice_
    #endif
    {
    }
}
