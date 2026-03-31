// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice element capturing strike price related descriptive information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice22Choice.Price))]
    [KnownType(typeof(SecuritiesTransactionPrice22Choice.DigitalTokenPrice))]
    [KnownType(typeof(SecuritiesTransactionPrice22Choice.NoPrice))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice22Choice.Price),
        nameof(SecuritiesTransactionPrice22Choice.Price)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice22Choice.DigitalTokenPrice),
        nameof(SecuritiesTransactionPrice22Choice.DigitalTokenPrice)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice22Choice.NoPrice),
        nameof(SecuritiesTransactionPrice22Choice.NoPrice)
    )]
    [IsoId("_i5c_MZiuEe2f7NHvXATP5g")]
    [DisplayName("Securities Transaction Price 22 Choice")]
    public abstract record SecuritiesTransactionPrice22Choice_ { }
}
