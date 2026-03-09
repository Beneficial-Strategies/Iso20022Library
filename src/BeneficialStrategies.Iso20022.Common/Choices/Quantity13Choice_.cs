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
    /// Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.
    /// </summary>
    [KnownType(typeof(Quantity13Choice.TotalUnitsNumber))]
    [KnownType(typeof(Quantity13Choice.PortfolioTransferOutRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity13Choice.TotalUnitsNumber),nameof(Quantity13Choice.TotalUnitsNumber))]
    [JsonDerivedType(typeof(Quantity13Choice.PortfolioTransferOutRate),nameof(Quantity13Choice.PortfolioTransferOutRate))]
    #endif
    [IsoId("__UhkwEZ6EeGxeZmLCxTaOw_-2052413231")]
    [DisplayName("Quantity 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity13Choice_
    #else
    public abstract partial class Quantity13Choice_
    #endif
    {
    }
}
