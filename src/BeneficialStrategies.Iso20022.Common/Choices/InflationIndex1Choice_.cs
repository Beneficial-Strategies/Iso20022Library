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
    /// Choice of an inflation index identification.
    /// </summary>
    [KnownType(typeof(InflationIndex1Choice.ISIN))]
    [KnownType(typeof(InflationIndex1Choice.Name))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InflationIndex1Choice.ISIN),nameof(InflationIndex1Choice.ISIN))]
    [JsonDerivedType(typeof(InflationIndex1Choice.Name),nameof(InflationIndex1Choice.Name))]
    #endif
    [IsoId("_ZyZ21CS2EeWsI5Sp3-B3zg")]
    [DisplayName("Inflation Index 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InflationIndex1Choice_
    #else
    public abstract partial class InflationIndex1Choice_
    #endif
    {
    }
}
