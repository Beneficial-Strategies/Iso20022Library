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
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus66Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus66Choice.Repair))]
    [KnownType(typeof(ProcessingStatus66Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus66Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus66Choice.AcknowledgedAccepted),nameof(ProcessingStatus66Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus66Choice.Repair),nameof(ProcessingStatus66Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus66Choice.Cancelled),nameof(ProcessingStatus66Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus66Choice.Proprietary),nameof(ProcessingStatus66Choice.Proprietary))]
    #endif
    [IsoId("_BmSl9eFUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status 66 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus66Choice_
    #else
    public abstract partial class ProcessingStatus66Choice_
    #endif
    {
    }
}
