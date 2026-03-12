// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for specifying how the trade was executed off-market.
    /// </summary>
    [KnownType(typeof(OffMarket1Choice.OffMarketIndicator))]
    [KnownType(typeof(OffMarket1Choice.SystematicInternaliser))]
    [JsonDerivedType(typeof(OffMarket1Choice.OffMarketIndicator),nameof(OffMarket1Choice.OffMarketIndicator))]
    [JsonDerivedType(typeof(OffMarket1Choice.SystematicInternaliser),nameof(OffMarket1Choice.SystematicInternaliser))]
    [IsoId("_TCpPoNp-Ed-ak6NoX_4Aeg_2009784706")]
    [DisplayName("Off Market 1 Choice")]
    public abstract partial record OffMarket1Choice_
    {
    }
}
