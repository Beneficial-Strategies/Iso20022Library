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
    /// Status is rejected.
    /// </summary>
    [KnownType(typeof(RejectedStatus3Choice.Reason))]
    [KnownType(typeof(RejectedStatus3Choice.DataSourceScheme))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus3Choice.Reason),nameof(RejectedStatus3Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus3Choice.DataSourceScheme),nameof(RejectedStatus3Choice.DataSourceScheme))]
    #endif
    [IsoId("_U23mWtp-Ed-ak6NoX_4Aeg_-368695389")]
    [DisplayName("Rejected Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus3Choice_
    #else
    public abstract partial class RejectedStatus3Choice_
    #endif
    {
    }
}
