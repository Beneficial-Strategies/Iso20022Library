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
    [KnownType(typeof(Disclosure1Choice.NoDisclosure))]
    [KnownType(typeof(Disclosure1Choice.SafekeepingAccountAndHoldings))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Disclosure1Choice.NoDisclosure),nameof(Disclosure1Choice.NoDisclosure))]
    [JsonDerivedType(typeof(Disclosure1Choice.SafekeepingAccountAndHoldings),nameof(Disclosure1Choice.SafekeepingAccountAndHoldings))]
    #endif
    [IsoId("_xP2q0MAMEembi_x1QDJfxw")]
    [DisplayName("Disclosure 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Disclosure1Choice_
    #else
    public abstract partial class Disclosure1Choice_
    #endif
    {
    }
}
