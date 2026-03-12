// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of market identification.
    /// </summary>
    [KnownType(typeof(MarketIdentification2Choice.MarketIdentifierCode))]
    [KnownType(typeof(MarketIdentification2Choice.Description))]
    [JsonDerivedType(typeof(MarketIdentification2Choice.MarketIdentifierCode),nameof(MarketIdentification2Choice.MarketIdentifierCode))]
    [JsonDerivedType(typeof(MarketIdentification2Choice.Description),nameof(MarketIdentification2Choice.Description))]
    [IsoId("_XK10ENp-Ed-ak6NoX_4Aeg_-180703514")]
    [DisplayName("Market Identification 2 Choice")]
    public abstract partial record MarketIdentification2Choice_
    {
    }
}
