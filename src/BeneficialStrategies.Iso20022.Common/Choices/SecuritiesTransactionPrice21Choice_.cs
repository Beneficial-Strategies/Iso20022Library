// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Securities Transaction Price21Choice.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice21Choice.BasisPoints))]
    [KnownType(typeof(SecuritiesTransactionPrice21Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice21Choice.NominalValue))]
    [KnownType(typeof(SecuritiesTransactionPrice21Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice21Choice.Yield))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice21Choice.BasisPoints),
        nameof(SecuritiesTransactionPrice21Choice.BasisPoints)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice21Choice.MonetaryValue),
        nameof(SecuritiesTransactionPrice21Choice.MonetaryValue)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice21Choice.NominalValue),
        nameof(SecuritiesTransactionPrice21Choice.NominalValue)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice21Choice.Percentage),
        nameof(SecuritiesTransactionPrice21Choice.Percentage)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice21Choice.Yield),
        nameof(SecuritiesTransactionPrice21Choice.Yield)
    )]
    [IsoId("_KzWSEWsgEe25qph5Y8_eYQ")]
    [DisplayName("Securities Transaction Price21Choice")]
    public abstract record SecuritiesTransactionPrice21Choice_ { }
}
