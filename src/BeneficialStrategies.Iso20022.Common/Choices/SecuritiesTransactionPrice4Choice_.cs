// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice element capturing strike price related descriptive information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice4Choice.Price))]
    [KnownType(typeof(SecuritiesTransactionPrice4Choice.NoPrice))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice4Choice.Price),
        nameof(SecuritiesTransactionPrice4Choice.Price)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice4Choice.NoPrice),
        nameof(SecuritiesTransactionPrice4Choice.NoPrice)
    )]
    [IsoId("_8Rc9cOI-EeWWKb0jFHxViQ")]
    [DisplayName("Securities Transaction Price 4 Choice")]
    public abstract record SecuritiesTransactionPrice4Choice_ { }
}
