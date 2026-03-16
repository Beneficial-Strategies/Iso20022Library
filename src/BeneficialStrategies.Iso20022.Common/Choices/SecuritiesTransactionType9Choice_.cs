// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType9Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType9Choice.Code),
        nameof(SecuritiesTransactionType9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType9Choice.Proprietary),
        nameof(SecuritiesTransactionType9Choice.Proprietary)
    )]
    [IsoId("_aJKrQfvlEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Transaction Type 9 Choice")]
    public abstract record SecuritiesTransactionType9Choice_ { }
}
