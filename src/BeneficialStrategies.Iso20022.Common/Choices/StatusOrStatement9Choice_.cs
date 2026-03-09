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
    [KnownType(typeof(StatusOrStatement9Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement9Choice.Statement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatusOrStatement9Choice.StatusAdvice),nameof(StatusOrStatement9Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement9Choice.Statement),nameof(StatusOrStatement9Choice.Statement))]
    #endif
    [IsoId("_9a9TMdBxEeihG9bKfarOOA")]
    [DisplayName("Status Or Statement 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement9Choice_
    #else
    public abstract partial class StatusOrStatement9Choice_
    #endif
    {
    }
}
