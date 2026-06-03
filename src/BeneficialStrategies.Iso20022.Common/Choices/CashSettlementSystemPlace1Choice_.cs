// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Location where the payment is/will be taking place.
    /// </summary>
    [KnownType(typeof(CashSettlementSystemPlace1Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(CashSettlementSystemPlace1Choice.AnyBIC))]
    [KnownType(typeof(CashSettlementSystemPlace1Choice.LEI))]
    [JsonDerivedType(typeof(CashSettlementSystemPlace1Choice.DigitalLedgerIdentification), nameof(CashSettlementSystemPlace1Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(CashSettlementSystemPlace1Choice.AnyBIC), nameof(CashSettlementSystemPlace1Choice.AnyBIC))]
    [JsonDerivedType(typeof(CashSettlementSystemPlace1Choice.LEI), nameof(CashSettlementSystemPlace1Choice.LEI))]
    [IsoId("_57FSMJZgEfCShM_qO0U4ig")]
    [DisplayName("CashSettlementSystemPlace1Choice")]
    public abstract record CashSettlementSystemPlace1Choice_ { }
}
