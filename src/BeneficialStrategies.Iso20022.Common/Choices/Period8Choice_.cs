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
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period8Choice.DateTime))]
    [KnownType(typeof(Period8Choice.FromDateTime))]
    [KnownType(typeof(Period8Choice.ToDateTime))]
    [KnownType(typeof(Period8Choice.FromDateToDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Period8Choice.DateTime),nameof(Period8Choice.DateTime))]
    [JsonDerivedType(typeof(Period8Choice.FromDateTime),nameof(Period8Choice.FromDateTime))]
    [JsonDerivedType(typeof(Period8Choice.ToDateTime),nameof(Period8Choice.ToDateTime))]
    [JsonDerivedType(typeof(Period8Choice.FromDateToDate),nameof(Period8Choice.FromDateToDate))]
    #endif
    [IsoId("_ctoHOP1cEeiAfJEqh4xF_Q")]
    [DisplayName("Period 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period8Choice_
    #else
    public abstract partial class Period8Choice_
    #endif
    {
    }
}
