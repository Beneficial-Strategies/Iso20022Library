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
    /// Choice for transparency calculation specific details on commodities.
    /// </summary>
    [KnownType(typeof(CommodityDerivate2Choice.Freight))]
    [KnownType(typeof(CommodityDerivate2Choice.Energy))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommodityDerivate2Choice.Freight),nameof(CommodityDerivate2Choice.Freight))]
    [JsonDerivedType(typeof(CommodityDerivate2Choice.Energy),nameof(CommodityDerivate2Choice.Energy))]
    #endif
    [IsoId("_znH8cWlHEeaLAKoEUNsD9g")]
    [DisplayName("Commodity Derivate 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommodityDerivate2Choice_
    #else
    public abstract partial class CommodityDerivate2Choice_
    #endif
    {
    }
}
