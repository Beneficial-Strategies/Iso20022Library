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
    [KnownType(typeof(CommodityDerivative2Choice.Freight))]
    [KnownType(typeof(CommodityDerivative2Choice.Energy))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommodityDerivative2Choice.Freight),nameof(CommodityDerivative2Choice.Freight))]
    [JsonDerivedType(typeof(CommodityDerivative2Choice.Energy),nameof(CommodityDerivative2Choice.Energy))]
    #endif
    [IsoId("_nZzFsU-nEeiVsYLJl6hleg")]
    [DisplayName("Commodity Derivative 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommodityDerivative2Choice_
    #else
    public abstract partial class CommodityDerivative2Choice_
    #endif
    {
    }
}
