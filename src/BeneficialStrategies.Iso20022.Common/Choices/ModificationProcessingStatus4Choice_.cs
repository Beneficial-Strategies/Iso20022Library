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
    [KnownType(typeof(ModificationProcessingStatus4Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationProcessingStatus4Choice.AcknowledgedAccepted),nameof(ModificationProcessingStatus4Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ModificationProcessingStatus4Choice.PendingProcessing),nameof(ModificationProcessingStatus4Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ModificationProcessingStatus4Choice.Denied),nameof(ModificationProcessingStatus4Choice.Denied))]
    [JsonDerivedType(typeof(ModificationProcessingStatus4Choice.Rejected),nameof(ModificationProcessingStatus4Choice.Rejected))]
    [JsonDerivedType(typeof(ModificationProcessingStatus4Choice.Repaired),nameof(ModificationProcessingStatus4Choice.Repaired))]
    [JsonDerivedType(typeof(ModificationProcessingStatus4Choice.Modified),nameof(ModificationProcessingStatus4Choice.Modified))]
    [JsonDerivedType(typeof(ModificationProcessingStatus4Choice.Proprietary),nameof(ModificationProcessingStatus4Choice.Proprietary))]
    #endif
    [IsoId("_gUOMsVhgEeS8HfHHd4stCA")]
    [DisplayName("Modification Processing Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationProcessingStatus4Choice_
    #else
    public abstract partial class ModificationProcessingStatus4Choice_
    #endif
    {
    }
}
