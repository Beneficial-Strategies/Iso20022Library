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
    /// Reason for the rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus8Choice.Reason))]
    [KnownType(typeof(RejectedStatus8Choice.ExtendedReason))]
    [KnownType(typeof(RejectedStatus8Choice.DataSourceScheme))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus8Choice.Reason),nameof(RejectedStatus8Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus8Choice.ExtendedReason),nameof(RejectedStatus8Choice.ExtendedReason))]
    [JsonDerivedType(typeof(RejectedStatus8Choice.DataSourceScheme),nameof(RejectedStatus8Choice.DataSourceScheme))]
    #endif
    [IsoId("_RQy3gdp-Ed-ak6NoX_4Aeg_-368514445")]
    [DisplayName("Rejected Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus8Choice_
    #else
    public abstract partial class RejectedStatus8Choice_
    #endif
    {
    }
}
