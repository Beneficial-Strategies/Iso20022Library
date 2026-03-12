// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType37Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType37Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType37Choice.Code),nameof(SecuritiesTransactionType37Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType37Choice.Proprietary),nameof(SecuritiesTransactionType37Choice.Proprietary))]
    [IsoId("_eTqacaUrEee4_75LDmHZiQ")]
    [DisplayName("Securities Transaction Type 37 Choice")]
    public abstract partial record SecuritiesTransactionType37Choice_
    {
    }
}
