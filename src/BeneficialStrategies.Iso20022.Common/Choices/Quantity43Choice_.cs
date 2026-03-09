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
    /// Choice of quantity of assets to be transferred in percentage rate or units.
    /// </summary>
    [KnownType(typeof(Quantity43Choice.Unit))]
    [KnownType(typeof(Quantity43Choice.PercentageRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity43Choice.Unit),nameof(Quantity43Choice.Unit))]
    [JsonDerivedType(typeof(Quantity43Choice.PercentageRate),nameof(Quantity43Choice.PercentageRate))]
    #endif
    [IsoId("_pzAI0a5xEeeMy7TnJ3e__g")]
    [DisplayName("Quantity 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity43Choice_
    #else
    public abstract partial class Quantity43Choice_
    #endif
    {
    }
}
