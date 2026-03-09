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
    /// Specifies the reason for the transaction cancellation status.
    /// </summary>
    [KnownType(typeof(CancellationStatusReason3Choice.Code))]
    [KnownType(typeof(CancellationStatusReason3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationStatusReason3Choice.Code),nameof(CancellationStatusReason3Choice.Code))]
    [JsonDerivedType(typeof(CancellationStatusReason3Choice.Proprietary),nameof(CancellationStatusReason3Choice.Proprietary))]
    #endif
    [IsoId("_skGdSYlrEeePr-EGJjGYzQ")]
    [DisplayName("Cancellation Status Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatusReason3Choice_
    #else
    public abstract partial class CancellationStatusReason3Choice_
    #endif
    {
    }
}
