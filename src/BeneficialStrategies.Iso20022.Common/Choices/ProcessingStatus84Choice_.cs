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
    [KnownType(typeof(ProcessingStatus84Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus84Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus84Choice.Repair))]
    [KnownType(typeof(ProcessingStatus84Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus84Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus84Choice.Denied))]
    [KnownType(typeof(ProcessingStatus84Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus84Choice.PendingCancellation),nameof(ProcessingStatus84Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Rejected),nameof(ProcessingStatus84Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Repair),nameof(ProcessingStatus84Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.AcknowledgedAccepted),nameof(ProcessingStatus84Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Proprietary),nameof(ProcessingStatus84Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Denied),nameof(ProcessingStatus84Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus84Choice.Cancelled),nameof(ProcessingStatus84Choice.Cancelled))]
    #endif
    [IsoId("_mC22sStVEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 84 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus84Choice_
    #else
    public abstract partial class ProcessingStatus84Choice_
    #endif
    {
    }
}
