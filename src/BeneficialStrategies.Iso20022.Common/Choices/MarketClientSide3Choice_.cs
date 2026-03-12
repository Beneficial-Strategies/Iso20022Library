// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide3Choice.Code))]
    [KnownType(typeof(MarketClientSide3Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketClientSide3Choice.Code),nameof(MarketClientSide3Choice.Code))]
    [JsonDerivedType(typeof(MarketClientSide3Choice.Proprietary),nameof(MarketClientSide3Choice.Proprietary))]
    [IsoId("_Aamt0dokEeC60axPepSq7g_-861875028")]
    [DisplayName("Market Client Side 3 Choice")]
    public abstract partial record MarketClientSide3Choice_
    {
    }
}
