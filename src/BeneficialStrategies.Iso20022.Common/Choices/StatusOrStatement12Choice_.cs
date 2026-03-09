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
    [KnownType(typeof(StatusOrStatement12Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement12Choice.Statement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatusOrStatement12Choice.StatusAdvice),nameof(StatusOrStatement12Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement12Choice.Statement),nameof(StatusOrStatement12Choice.Statement))]
    #endif
    [IsoId("_gBH0DTi8Eeydid5dcNPKvg")]
    [DisplayName("Status Or Statement 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement12Choice_
    #else
    public abstract partial class StatusOrStatement12Choice_
    #endif
    {
    }
}
