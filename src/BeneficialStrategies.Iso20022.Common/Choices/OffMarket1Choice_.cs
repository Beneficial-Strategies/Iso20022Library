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
    /// Choice for specifying how the trade was executed off-market.
    /// </summary>
    [KnownType(typeof(OffMarket1Choice.OffMarketIndicator))]
    [KnownType(typeof(OffMarket1Choice.SystematicInternaliser))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OffMarket1Choice.OffMarketIndicator),nameof(OffMarket1Choice.OffMarketIndicator))]
    [JsonDerivedType(typeof(OffMarket1Choice.SystematicInternaliser),nameof(OffMarket1Choice.SystematicInternaliser))]
    #endif
    [IsoId("_TCpPoNp-Ed-ak6NoX_4Aeg_2009784706")]
    [DisplayName("Off Market 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OffMarket1Choice_
    #else
    public abstract partial class OffMarket1Choice_
    #endif
    {
    }
}
