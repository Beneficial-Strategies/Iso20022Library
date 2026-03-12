// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice amongst various balance types related to unallocated payment.
    /// </summary>
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD1Choice.TotalEligibleBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD1Choice.BorrowedBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD1Choice.CollateralInBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD1Choice.CollateralOutBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD1Choice.OnLoanBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD1Choice.PendingDeliveryBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD1Choice.PendingReceiptBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD1Choice.TotalEligibleBalance),nameof(CorporateActionUnallocatedBalanceSD1Choice.TotalEligibleBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD1Choice.BorrowedBalance),nameof(CorporateActionUnallocatedBalanceSD1Choice.BorrowedBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD1Choice.CollateralInBalance),nameof(CorporateActionUnallocatedBalanceSD1Choice.CollateralInBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD1Choice.CollateralOutBalance),nameof(CorporateActionUnallocatedBalanceSD1Choice.CollateralOutBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD1Choice.OnLoanBalance),nameof(CorporateActionUnallocatedBalanceSD1Choice.OnLoanBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD1Choice.PendingDeliveryBalance),nameof(CorporateActionUnallocatedBalanceSD1Choice.PendingDeliveryBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD1Choice.PendingReceiptBalance),nameof(CorporateActionUnallocatedBalanceSD1Choice.PendingReceiptBalance))]
    [IsoId("_1QPnkzL3EeKU9IrkkToqcw_954371406")]
    [DisplayName("Corporate Action Unallocated Balance SD 1 Choice")]
    public abstract partial record CorporateActionUnallocatedBalanceSD1Choice_
    {
    }
}
