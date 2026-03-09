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
    /// Choice of format for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus79Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus79Choice.Rejected))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus79Choice.AcknowledgedAccepted),nameof(ProcessingStatus79Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus79Choice.Rejected),nameof(ProcessingStatus79Choice.Rejected))]
    #endif
    [IsoId("_Hk0BYZwZEeqtp-LOti013g")]
    [DisplayName("Processing Status 79 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus79Choice_
    #else
    public abstract partial class ProcessingStatus79Choice_
    #endif
    {
    }
}
