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
    [KnownType(typeof(ModificationProcessingStatus10Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus10Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus10Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus10Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus10Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus10Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationProcessingStatus10Choice.AcknowledgedAccepted),nameof(ModificationProcessingStatus10Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ModificationProcessingStatus10Choice.PendingProcessing),nameof(ModificationProcessingStatus10Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ModificationProcessingStatus10Choice.Denied),nameof(ModificationProcessingStatus10Choice.Denied))]
    [JsonDerivedType(typeof(ModificationProcessingStatus10Choice.Rejected),nameof(ModificationProcessingStatus10Choice.Rejected))]
    [JsonDerivedType(typeof(ModificationProcessingStatus10Choice.Repaired),nameof(ModificationProcessingStatus10Choice.Repaired))]
    [JsonDerivedType(typeof(ModificationProcessingStatus10Choice.Modified),nameof(ModificationProcessingStatus10Choice.Modified))]
    [JsonDerivedType(typeof(ModificationProcessingStatus10Choice.Proprietary),nameof(ModificationProcessingStatus10Choice.Proprietary))]
    #endif
    [IsoId("_OSQ54StWEeyhipY4f42fZQ")]
    [DisplayName("Modification Processing Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationProcessingStatus10Choice_
    #else
    public abstract partial class ModificationProcessingStatus10Choice_
    #endif
    {
    }
}
