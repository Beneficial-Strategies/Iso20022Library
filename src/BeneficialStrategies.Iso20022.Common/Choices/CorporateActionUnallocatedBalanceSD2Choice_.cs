// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.TotalEligibleBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.TotalEligibleBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.BorrowedBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.BorrowedBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralInBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.CollateralInBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.CollateralOutBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.CollateralOutBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.OnLoanBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.OnLoanBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingDeliveryBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.PendingDeliveryBalance))]
    [JsonDerivedType(typeof(CorporateActionUnallocatedBalanceSD2Choice.PendingReceiptBalance),nameof(CorporateActionUnallocatedBalanceSD2Choice.PendingReceiptBalance))]
    #endif
    [IsoId("_20nwsaIQEeS6IulNYwkZBg")]
    [DisplayName("Corporate Action Unallocated Balance SD 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionUnallocatedBalanceSD2Choice_
    #else
    public abstract partial class CorporateActionUnallocatedBalanceSD2Choice_
    #endif
    {
    }
}
