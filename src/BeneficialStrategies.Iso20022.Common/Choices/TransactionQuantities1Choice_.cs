// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the quantities (eg of securities) in the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionQuantities1Choice.Quantity))]
    [KnownType(typeof(TransactionQuantities1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TransactionQuantities1Choice.Quantity),
        nameof(TransactionQuantities1Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(TransactionQuantities1Choice.Proprietary),
        nameof(TransactionQuantities1Choice.Proprietary)
    )]
    [IsoId("_RU0b5tp-Ed-ak6NoX_4Aeg_-584387568")]
    [DisplayName("Transaction Quantities 1 Choice")]
    public abstract record TransactionQuantities1Choice_ { }
}
