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
    [KnownType(typeof(ProcessingStatus2Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus2Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus2Choice.Repair))]
    [KnownType(typeof(ProcessingStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus2Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus2Choice.Denied))]
    [KnownType(typeof(ProcessingStatus2Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus2Choice.PendingCancellation),nameof(ProcessingStatus2Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Rejected),nameof(ProcessingStatus2Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Repair),nameof(ProcessingStatus2Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.AcknowledgedAccepted),nameof(ProcessingStatus2Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Proprietary),nameof(ProcessingStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Denied),nameof(ProcessingStatus2Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Cancelled),nameof(ProcessingStatus2Choice.Cancelled))]
    #endif
    [IsoId("_UUJ60dp-Ed-ak6NoX_4Aeg_1316468360")]
    [DisplayName("Processing Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus2Choice_
    #else
    public abstract partial class ProcessingStatus2Choice_
    #endif
    {
    }
}
