// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType2Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType2Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType2Choice.Code),nameof(SecuritiesTransactionType2Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType2Choice.Proprietary),nameof(SecuritiesTransactionType2Choice.Proprietary))]
    [IsoId("_QtevF9p-Ed-ak6NoX_4Aeg_-529584274")]
    [DisplayName("Securities Transaction Type 2 Choice")]
    public abstract partial record SecuritiesTransactionType2Choice_
    {
    }
}
