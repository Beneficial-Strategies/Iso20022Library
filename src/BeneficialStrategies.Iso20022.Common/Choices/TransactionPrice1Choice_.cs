// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements identifying the price information related to the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionPrice1Choice.DealPrice))]
    [KnownType(typeof(TransactionPrice1Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionPrice1Choice.DealPrice),nameof(TransactionPrice1Choice.DealPrice))]
    [JsonDerivedType(typeof(TransactionPrice1Choice.Proprietary),nameof(TransactionPrice1Choice.Proprietary))]
    [IsoId("_RUrR9Np-Ed-ak6NoX_4Aeg_1516952051")]
    [DisplayName("Transaction Price 1 Choice")]
    public abstract partial record TransactionPrice1Choice_
    {
    }
}
