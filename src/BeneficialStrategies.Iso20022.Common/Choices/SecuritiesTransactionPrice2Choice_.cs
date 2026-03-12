// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.BasisPoints))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.MonetaryValue),nameof(SecuritiesTransactionPrice2Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.Percentage),nameof(SecuritiesTransactionPrice2Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.Yield),nameof(SecuritiesTransactionPrice2Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.BasisPoints),nameof(SecuritiesTransactionPrice2Choice.BasisPoints))]
    [IsoId("_xZe0tiZJEeWbypuCUIOnzw")]
    [DisplayName("Securities Transaction Price 2 Choice")]
    public abstract partial record SecuritiesTransactionPrice2Choice_
    {
    }
}
