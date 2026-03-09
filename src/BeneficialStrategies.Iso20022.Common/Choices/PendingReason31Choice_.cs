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
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason31Choice.Code))]
    [KnownType(typeof(PendingReason31Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason31Choice.Code),nameof(PendingReason31Choice.Code))]
    [JsonDerivedType(typeof(PendingReason31Choice.Proprietary),nameof(PendingReason31Choice.Proprietary))]
    #endif
    [IsoId("_qpuxgTw9EeW3QqUkIQtIUA")]
    [DisplayName("Pending Reason 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason31Choice_
    #else
    public abstract partial class PendingReason31Choice_
    #endif
    {
    }
}
