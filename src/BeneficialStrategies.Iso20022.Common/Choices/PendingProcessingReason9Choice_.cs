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
    /// Choice of formats for the reason of a pending status.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason9Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingReason9Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingProcessingReason9Choice.NoSpecifiedReason),nameof(PendingProcessingReason9Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingReason9Choice.Reason),nameof(PendingProcessingReason9Choice.Reason))]
    #endif
    [IsoId("_6LbpKVj1EeOnqqBHs8Gasw")]
    [DisplayName("Pending Processing Reason 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessingReason9Choice_
    #else
    public abstract partial class PendingProcessingReason9Choice_
    #endif
    {
    }
}
