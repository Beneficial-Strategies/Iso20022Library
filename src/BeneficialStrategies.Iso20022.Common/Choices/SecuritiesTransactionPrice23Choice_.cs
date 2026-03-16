// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Securities Transaction Price23Choice.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice23Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice23Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice23Choice.Other))]
    [KnownType(typeof(SecuritiesTransactionPrice23Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice23Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice23Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice23Choice.Decimal),nameof(SecuritiesTransactionPrice23Choice.Decimal))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice23Choice.MonetaryValue),nameof(SecuritiesTransactionPrice23Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice23Choice.Other),nameof(SecuritiesTransactionPrice23Choice.Other))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice23Choice.Percentage),nameof(SecuritiesTransactionPrice23Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice23Choice.Unit),nameof(SecuritiesTransactionPrice23Choice.Unit))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice23Choice.Yield),nameof(SecuritiesTransactionPrice23Choice.Yield))]
    [IsoId("_Auws0eFbEe64Zfh-zMOIZQ")]
    [DisplayName("Securities Transaction Price23Choice")]
    public abstract partial record SecuritiesTransactionPrice23Choice_
    {
    }
}
