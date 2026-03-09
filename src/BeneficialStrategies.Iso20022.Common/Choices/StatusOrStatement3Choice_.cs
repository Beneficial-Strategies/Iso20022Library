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
    /// Choice between the identification of a status or statement query.
    /// </summary>
    [KnownType(typeof(StatusOrStatement3Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement3Choice.Statement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatusOrStatement3Choice.StatusAdvice),nameof(StatusOrStatement3Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement3Choice.Statement),nameof(StatusOrStatement3Choice.Statement))]
    #endif
    [IsoId("_CEeN0fJlEd-DocZblYEqZw")]
    [DisplayName("Status Or Statement 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement3Choice_
    #else
    public abstract partial class StatusOrStatement3Choice_
    #endif
    {
    }
}
