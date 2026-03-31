// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType1Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType1Choice.Code),
        nameof(SecuritiesTransactionType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType1Choice.Proprietary),
        nameof(SecuritiesTransactionType1Choice.Proprietary)
    )]
    [IsoId("_QuOV9tp-Ed-ak6NoX_4Aeg_-1962262149")]
    [DisplayName("Securities Transaction Type 1 Choice")]
    public abstract record SecuritiesTransactionType1Choice_ { }
}
