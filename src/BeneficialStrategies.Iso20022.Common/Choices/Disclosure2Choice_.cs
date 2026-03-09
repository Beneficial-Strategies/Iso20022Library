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
    /// Choice between an indication of no disclosure and the provision of shareholding disclosure information.
    /// </summary>
    [KnownType(typeof(Disclosure2Choice.NoDisclosure))]
    [KnownType(typeof(Disclosure2Choice.SafekeepingAccountAndHoldings))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Disclosure2Choice.NoDisclosure),nameof(Disclosure2Choice.NoDisclosure))]
    [JsonDerivedType(typeof(Disclosure2Choice.SafekeepingAccountAndHoldings),nameof(Disclosure2Choice.SafekeepingAccountAndHoldings))]
    #endif
    [IsoId("_L3-v4fNyEeqRfth943bvEA")]
    [DisplayName("Disclosure 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Disclosure2Choice_
    #else
    public abstract partial class Disclosure2Choice_
    #endif
    {
    }
}
