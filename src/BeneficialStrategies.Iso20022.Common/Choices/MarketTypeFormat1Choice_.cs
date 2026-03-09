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
    /// Choice between a standard code or proprietary code to specify the type of market.
    /// </summary>
    [KnownType(typeof(MarketTypeFormat1Choice.Code))]
    [KnownType(typeof(MarketTypeFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketTypeFormat1Choice.Code),nameof(MarketTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(MarketTypeFormat1Choice.Proprietary),nameof(MarketTypeFormat1Choice.Proprietary))]
    #endif
    [IsoId("_Q4XJYdp-Ed-ak6NoX_4Aeg_472330061")]
    [DisplayName("Market Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketTypeFormat1Choice_
    #else
    public abstract partial class MarketTypeFormat1Choice_
    #endif
    {
    }
}
