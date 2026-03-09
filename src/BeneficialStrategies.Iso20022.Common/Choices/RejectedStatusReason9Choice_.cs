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
    /// Reason for which a transaction report is rejected.
    /// </summary>
    [KnownType(typeof(RejectedStatusReason9Choice.Reason))]
    [KnownType(typeof(RejectedStatusReason9Choice.ExtendedReason))]
    [KnownType(typeof(RejectedStatusReason9Choice.DataSourceScheme))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatusReason9Choice.Reason),nameof(RejectedStatusReason9Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatusReason9Choice.ExtendedReason),nameof(RejectedStatusReason9Choice.ExtendedReason))]
    [JsonDerivedType(typeof(RejectedStatusReason9Choice.DataSourceScheme),nameof(RejectedStatusReason9Choice.DataSourceScheme))]
    #endif
    [IsoId("_RXWyh9p-Ed-ak6NoX_4Aeg_-1456677531")]
    [DisplayName("Rejected Status Reason 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatusReason9Choice_
    #else
    public abstract partial class RejectedStatusReason9Choice_
    #endif
    {
    }
}
