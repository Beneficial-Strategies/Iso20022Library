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
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason21Choice.Code))]
    [KnownType(typeof(CancellationReason21Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason21Choice.Code),nameof(CancellationReason21Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason21Choice.Proprietary),nameof(CancellationReason21Choice.Proprietary))]
    #endif
    [IsoId("_MxX5ATs9EeWRTLSN0i0tng")]
    [DisplayName("Cancellation Reason 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason21Choice_
    #else
    public abstract partial class CancellationReason21Choice_
    #endif
    {
    }
}
