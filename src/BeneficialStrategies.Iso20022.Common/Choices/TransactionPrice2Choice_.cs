// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the price information related to the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionPrice2Choice.DealPrice))]
    [KnownType(typeof(TransactionPrice2Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionPrice2Choice.DealPrice),nameof(TransactionPrice2Choice.DealPrice))]
    [JsonDerivedType(typeof(TransactionPrice2Choice.Proprietary),nameof(TransactionPrice2Choice.Proprietary))]
    [IsoId("_Rp1Cl9p-Ed-ak6NoX_4Aeg_997208296")]
    [DisplayName("Transaction Price 2 Choice")]
    public abstract partial record TransactionPrice2Choice_
    {
    }
}
