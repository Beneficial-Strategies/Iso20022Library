// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType3Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType3Choice.Code),
        nameof(SecuritiesTransactionType3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType3Choice.Proprietary),
        nameof(SecuritiesTransactionType3Choice.Proprietary)
    )]
    [IsoId("_QwUAotp-Ed-ak6NoX_4Aeg_645805426")]
    [DisplayName("Securities Transaction Type 3 Choice")]
    public abstract record SecuritiesTransactionType3Choice_ { }
}
