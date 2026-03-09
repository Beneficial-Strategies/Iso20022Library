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
    /// Reason for the cancellation pending status.
    /// </summary>
    [KnownType(typeof(CancellationPendingStatus7Choice.Reason))]
    [KnownType(typeof(CancellationPendingStatus7Choice.DataSourceScheme))]
    [KnownType(typeof(CancellationPendingStatus7Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationPendingStatus7Choice.Reason),nameof(CancellationPendingStatus7Choice.Reason))]
    [JsonDerivedType(typeof(CancellationPendingStatus7Choice.DataSourceScheme),nameof(CancellationPendingStatus7Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(CancellationPendingStatus7Choice.NoSpecifiedReason),nameof(CancellationPendingStatus7Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_mp9xQSY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Cancellation Pending Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationPendingStatus7Choice_
    #else
    public abstract partial class CancellationPendingStatus7Choice_
    #endif
    {
    }
}
