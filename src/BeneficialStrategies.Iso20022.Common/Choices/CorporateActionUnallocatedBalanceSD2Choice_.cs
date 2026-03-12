// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice amongst various balance types related to unallocated payment.
    /// </summary>
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.TotalEligibleBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.BorrowedBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralInBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralOutBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.OnLoanBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingDeliveryBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingReceiptBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.TotalEligibleBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.TotalEligibleBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.BorrowedBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.BorrowedBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralInBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.CollateralInBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralOutBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.CollateralOutBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.OnLoanBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.OnLoanBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingDeliveryBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.PendingDeliveryBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingReceiptBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.PendingReceiptBalance))]
    [IsoId("_20nwsaIQEeS6IulNYwkZBg")]
    [DisplayName("Corporate Action Unallocated Balance SD 2 Choice")]
    public abstract partial record CorporateActionUnallocatedBalanceSD2Choice_
    {
    }
}
