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
    [KnownType(typeof(Quantity12Choice.Unit))]
    [KnownType(typeof(Quantity12Choice.PercentageRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity12Choice.Unit),nameof(Quantity12Choice.Unit))]
    [JsonDerivedType(typeof(Quantity12Choice.PercentageRate),nameof(Quantity12Choice.PercentageRate))]
    #endif
    [IsoId("_ioTPQ_srEeCUd_EZYqZ_Uw")]
    [DisplayName("Quantity 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity12Choice_
    #else
    public abstract partial class Quantity12Choice_
    #endif
    {
    }
}
