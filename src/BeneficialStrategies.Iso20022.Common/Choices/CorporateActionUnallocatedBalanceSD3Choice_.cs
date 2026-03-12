// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice amongst various balance types related to unallocated payment.
    /// </summary>
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.TotalEligibleBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.BorrowedBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.CollateralInBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.CollateralOutBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.OnLoanBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.PendingDeliveryBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.PendingReceiptBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD3Choice.TotalEligibleBalance),nameof(CorporateActionUnallocatedBalanceSD3Choice.TotalEligibleBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD3Choice.BorrowedBalance),nameof(CorporateActionUnallocatedBalanceSD3Choice.BorrowedBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD3Choice.CollateralInBalance),nameof(CorporateActionUnallocatedBalanceSD3Choice.CollateralInBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD3Choice.CollateralOutBalance),nameof(CorporateActionUnallocatedBalanceSD3Choice.CollateralOutBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD3Choice.OnLoanBalance),nameof(CorporateActionUnallocatedBalanceSD3Choice.OnLoanBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD3Choice.PendingDeliveryBalance),nameof(CorporateActionUnallocatedBalanceSD3Choice.PendingDeliveryBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD3Choice.PendingReceiptBalance),nameof(CorporateActionUnallocatedBalanceSD3Choice.PendingReceiptBalance))]
    [IsoId("_uTU8wcSTEeeRJJtE9TSlkw")]
    [DisplayName("Corporate Action Unallocated Balance SD 3 Choice")]
    public abstract partial record CorporateActionUnallocatedBalanceSD3Choice_
    {
    }
}
