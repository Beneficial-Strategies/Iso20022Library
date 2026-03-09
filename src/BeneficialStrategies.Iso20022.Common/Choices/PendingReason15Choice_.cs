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
    [KnownType(typeof(PendingReason15Choice.Code))]
    [KnownType(typeof(PendingReason15Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason15Choice.Code),nameof(PendingReason15Choice.Code))]
    [JsonDerivedType(typeof(PendingReason15Choice.Proprietary),nameof(PendingReason15Choice.Proprietary))]
    #endif
    [IsoId("_Qg1iRf41EeClUvPNHKL9Zw")]
    [DisplayName("Pending Reason 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason15Choice_
    #else
    public abstract partial class PendingReason15Choice_
    #endif
    {
    }
}
