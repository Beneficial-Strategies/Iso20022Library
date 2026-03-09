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
    [KnownType(typeof(PendingReason38Choice.Code))]
    [KnownType(typeof(PendingReason38Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason38Choice.Code),nameof(PendingReason38Choice.Code))]
    [JsonDerivedType(typeof(PendingReason38Choice.Proprietary),nameof(PendingReason38Choice.Proprietary))]
    #endif
    [IsoId("_6BKT1ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason38Choice_
    #else
    public abstract partial class PendingReason38Choice_
    #endif
    {
    }
}
