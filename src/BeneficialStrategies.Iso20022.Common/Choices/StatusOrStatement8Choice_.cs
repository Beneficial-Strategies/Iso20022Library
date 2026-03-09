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
    [KnownType(typeof(StatusOrStatement8Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement8Choice.Statement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatusOrStatement8Choice.StatusAdvice),nameof(StatusOrStatement8Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement8Choice.Statement),nameof(StatusOrStatement8Choice.Statement))]
    #endif
    [IsoId("_8RszhZNLEeWGlc8L7oPDIg")]
    [DisplayName("Status Or Statement 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement8Choice_
    #else
    public abstract partial class StatusOrStatement8Choice_
    #endif
    {
    }
}
