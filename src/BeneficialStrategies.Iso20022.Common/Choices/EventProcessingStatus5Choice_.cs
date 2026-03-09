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
    [KnownType(typeof(EventProcessingStatus5Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus5Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus5Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus5Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.Complete),nameof(EventProcessingStatus5Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.Reconciled),nameof(EventProcessingStatus5Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.Pending),nameof(EventProcessingStatus5Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.ProprietaryStatus),nameof(EventProcessingStatus5Choice.ProprietaryStatus))]
    #endif
    [IsoId("_sSD3MeaEEemtTOaHuc_63w")]
    [DisplayName("Event Processing Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventProcessingStatus5Choice_
    #else
    public abstract partial class EventProcessingStatus5Choice_
    #endif
    {
    }
}
