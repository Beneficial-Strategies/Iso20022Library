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
    [KnownType(typeof(Proxy1Choice.Proxy))]
    [KnownType(typeof(Proxy1Choice.ProxyNotAllowed))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Proxy1Choice.Proxy),nameof(Proxy1Choice.Proxy))]
    [JsonDerivedType(typeof(Proxy1Choice.ProxyNotAllowed),nameof(Proxy1Choice.ProxyNotAllowed))]
    #endif
    [IsoId("_RD1ZkNp-Ed-ak6NoX_4Aeg_754984045")]
    [DisplayName("Proxy 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Proxy1Choice_
    #else
    public abstract partial class Proxy1Choice_
    #endif
    {
    }
}
