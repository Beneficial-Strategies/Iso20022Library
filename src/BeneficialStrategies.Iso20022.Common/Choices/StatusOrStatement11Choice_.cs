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
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement11Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement11Choice.Statement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatusOrStatement11Choice.StatusAdvice),nameof(StatusOrStatement11Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement11Choice.Statement),nameof(StatusOrStatement11Choice.Statement))]
    #endif
    [IsoId("_4dK-USgSEeym1_Zp1BTvEw")]
    [DisplayName("Status Or Statement 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement11Choice_
    #else
    public abstract partial class StatusOrStatement11Choice_
    #endif
    {
    }
}
