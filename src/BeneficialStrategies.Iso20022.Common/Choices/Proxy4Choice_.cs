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
    /// Choice of proxy allowance.
    /// </summary>
    [KnownType(typeof(Proxy4Choice.Proxy))]
    [KnownType(typeof(Proxy4Choice.ProxyNotAllowed))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Proxy4Choice.Proxy),nameof(Proxy4Choice.Proxy))]
    [JsonDerivedType(typeof(Proxy4Choice.ProxyNotAllowed),nameof(Proxy4Choice.ProxyNotAllowed))]
    #endif
    [IsoId("_euVP0fM7EeqRfth943bvEA")]
    [DisplayName("Proxy 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Proxy4Choice_
    #else
    public abstract partial class Proxy4Choice_
    #endif
    {
    }
}
