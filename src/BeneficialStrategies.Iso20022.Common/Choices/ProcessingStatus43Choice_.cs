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
    /// Choice of formats for the specification of a status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus43Choice.Received))]
    [KnownType(typeof(ProcessingStatus43Choice.Accepted))]
    [KnownType(typeof(ProcessingStatus43Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus43Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus43Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus43Choice.Received),nameof(ProcessingStatus43Choice.Received))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.Accepted),nameof(ProcessingStatus43Choice.Accepted))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.PendingProcessing),nameof(ProcessingStatus43Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.Rejected),nameof(ProcessingStatus43Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.ProprietaryStatus),nameof(ProcessingStatus43Choice.ProprietaryStatus))]
    #endif
    [IsoId("_ezCkoVhFEeOMYfRGLS0NbA")]
    [DisplayName("Processing Status 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus43Choice_
    #else
    public abstract partial class ProcessingStatus43Choice_
    #endif
    {
    }
}
