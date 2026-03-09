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
    [KnownType(typeof(ModificationProcessingStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.AcknowledgedAccepted),nameof(ModificationProcessingStatus2Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.PendingProcessing),nameof(ModificationProcessingStatus2Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Denied),nameof(ModificationProcessingStatus2Choice.Denied))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Rejected),nameof(ModificationProcessingStatus2Choice.Rejected))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Repaired),nameof(ModificationProcessingStatus2Choice.Repaired))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Modified),nameof(ModificationProcessingStatus2Choice.Modified))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Proprietary),nameof(ModificationProcessingStatus2Choice.Proprietary))]
    #endif
    [IsoId("_0kkl1AlIEeGATtfOBToyew_205414048")]
    [DisplayName("Modification Processing Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationProcessingStatus2Choice_
    #else
    public abstract partial class ModificationProcessingStatus2Choice_
    #endif
    {
    }
}
