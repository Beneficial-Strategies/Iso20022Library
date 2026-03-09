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
    [KnownType(typeof(CancellationReason31Choice.Code))]
    [KnownType(typeof(CancellationReason31Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason31Choice.Code),nameof(CancellationReason31Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason31Choice.Proprietary),nameof(CancellationReason31Choice.Proprietary))]
    #endif
    [IsoId("_tTaksVM4Eear4I4mBVNwZg")]
    [DisplayName("Cancellation Reason 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason31Choice_
    #else
    public abstract partial class CancellationReason31Choice_
    #endif
    {
    }
}
