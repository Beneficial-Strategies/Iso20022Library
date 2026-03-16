// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the system balance type, as published in an external system balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qP4_kHhYEeidzqjNEfehPg")]
[Description(
    @"Specifies the system balance type, as published in an external system balance type code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalSystemBalanceType1Code))]
public enum ExternalSystemBalanceTypeCode
{
    /// <summary>
    /// Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_ueCp7PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up."
    )]
    Adjustment,

    /// <summary>
    /// Balance represents the available discounted market value for discount window repo.
    /// Encoded/decoded by serializers as &quot;ADWR&quot;.
    /// </summary>
    [EnumMember(Value = "ADWR")]
    [IsoId("_ueLz0PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance represents the available discounted market value for discount window repo."
    )]
    AvailableDMVForDiscountWindowRepo,

    /// <summary>
    /// Balance represents the available discounted market value for intraday repo.
    /// Encoded/decoded by serializers as &quot;AIDR&quot;.
    /// </summary>
    [EnumMember(Value = "AIDR")]
    [IsoId("_ueLz0_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the available discounted market value for intraday repo.")]
    AvailableDMVForIntradayRepo,

    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_ueVk0PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of money or securities that is at the disposal of the account owner on the date specified."
    )]
    Available,

    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_ueVk0_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance."
    )]
    Blocked,

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository&apos;s operates several settlements cycles per day.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_ueVk1vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository's operates several settlements cycles per day."
    )]
    BlockedTrades,

    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_ueVk2fRYEeuLhpyIdtJzwg")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book,

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.
    /// Encoded/decoded by serializers as &quot;BSCC&quot;.
    /// </summary>
    [EnumMember(Value = "BSCC")]
    [IsoId("_uefV0PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor credit."
    )]
    BulkSettlementCMUPCredit,

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.
    /// Encoded/decoded by serializers as &quot;BSCD&quot;.
    /// </summary>
    [EnumMember(Value = "BSCD")]
    [IsoId("_uefV0_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor debit."
    )]
    BulkSettlementCMUPDebit,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_uefV1vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality."
    )]
    CentralCounterparty,

    /// <summary>
    /// Balance of the account at the end of the account servicer&apos;s business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer&apos;s business day.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_uefV2fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day."
    )]
    Closing,

    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;COHB&quot;.
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_ueofwPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded."
    )]
    CreditOnHold,

    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as &quot;COLC&quot;.
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_ueofw_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent."
    )]
    DividendsCollection,

    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;CPBL&quot;.
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_ueofxvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total incoming payments that have been processed and are waiting for settlement."
    )]
    CreditProcessed,

    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_ueofyfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit,

    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as &quot;CRRT&quot;.
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_ueofzPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current,

    /// <summary>
    /// Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.
    /// Encoded/decoded by serializers as &quot;CUSA&quot;.
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_ueyQwPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc."
    )]
    CustodyActual,

    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ueyQw_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc."
    )]
    Custody,

    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_ue8BwvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit,

    /// <summary>
    /// Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_ue8BxfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day."
    )]
    DaylightOverdraft,

    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;DOHB&quot;.
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_ufFLsPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded."
    )]
    DebitOnHold,

    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;DPBL&quot;.
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_ufFLs_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total outgoing payments that have been processed and are waiting for settlement."
    )]
    DebitProcessed,

    /// <summary>
    /// Balance representing the cash equivalent of all settled securities transactions.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_ufFLtvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the cash equivalent of all settled securities transactions."
    )]
    DefinitiveSettledSecurities,

    /// <summary>
    /// Balance represents the discount window repo drawings.
    /// Encoded/decoded by serializers as &quot;DWRD&quot;.
    /// </summary>
    [EnumMember(Value = "DWRD")]
    [IsoId("_ufFLufRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the discount window repo drawings.")]
    DiscountWindowRepoDrawings,

    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_ufO8sPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank."
    )]
    EligibleAssets,

    /// <summary>
    /// The code defines the threshold to the value excess reserve exemption balance between the exempt and non-exempt tiers of excess reserve.
    /// Encoded/decoded by serializers as &quot;EXRE&quot;.
    /// </summary>
    [EnumMember(Value = "EXRE")]
    [IsoId("_ufO8s_RYEeuLhpyIdtJzwg")]
    [Description(
        @"The code defines the threshold to the value excess reserve exemption balance between the exempt and non-exempt tiers of excess reserve. "
    )]
    ExcessReserveExemptionThresholdExemptTier,

    /// <summary>
    /// The code defines the balance beyond excess reserve exemption threshold within the periodic average balance for minimum reserve. Thus, this part of the excess reserve is still to be remunerated.
    /// Encoded/decoded by serializers as &quot;EXRR&quot;.
    /// </summary>
    [EnumMember(Value = "EXRR")]
    [IsoId("_ufO8tvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The code defines the balance beyond excess reserve exemption threshold within the periodic average balance for minimum reserve. Thus, this part of the excess reserve is still to be remunerated."
    )]
    ExcessReserveRemunerationBalanceNonExemptTier,

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_ufO8ufRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral."
    )]
    FirmCollateralisation,

    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as &quot;FCOU&quot;.
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_ufYGoPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral."
    )]
    UsedAmountsFirmCollateralisation,

    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_ufYGo_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions."
    )]
    CashForecast,

    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as &quot;FSET&quot;.
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_ufYGpvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement."
    )]
    ForecastSettlement,

    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_ufYGqfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement."
    )]
    NetFunding,

    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as &quot;FUTB&quot;.
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_ufYGrPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total of the payments with a processing date in the future."
    )]
    TotalFuture,

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_ufh3oPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    Interim,

    /// <summary>
    /// Balance represents the intraday repo drawings.
    /// Encoded/decoded by serializers as &quot;IRDR&quot;.
    /// </summary>
    [EnumMember(Value = "IRDR")]
    [IsoId("_ufh3o_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the intraday repo drawings.")]
    IntradayRepoDrawings,

    /// <summary>
    /// Balance represents the intraday repo limit.
    /// Encoded/decoded by serializers as &quot;IRLT&quot;.
    /// </summary>
    [EnumMember(Value = "IRLT")]
    [IsoId("_ufh3pvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the intraday repo limit.")]
    IntradayRepoLimit,

    /// <summary>
    /// Balance representing the cash equivalent of transactions with a lack of holdings.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_ufh3qfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the cash equivalent of transactions with a lack of holdings."
    )]
    LackOfHoldingsTransactions,

    /// <summary>
    /// Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_ufrBkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit."
    )]
    LimitRelated,

    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as &quot;LTSF&quot;.
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_ufrBk_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance composed of the sum of all liquidity transfers made to or from an account."
    )]
    LiquidityTransfer,

    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as &quot;MSTR&quot;.
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_ufrBlvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master,

    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_ufrBmfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available."
    )]
    Noted,

    /// <summary>
    /// Balance representing the cash equivalent of all non-settled securities transactions.
    /// Encoded/decoded by serializers as &quot;NSET&quot;.
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_uf0ykPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the cash equivalent of all non-settled securities transactions."
    )]
    NonSettledSecurities,

    /// <summary>
    /// Book balance of the account at the beginning of the account servicer&apos;s business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer&apos;s business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as &quot;OPNG&quot;.
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_uf0yk_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day."
    )]
    Opening,

    /// <summary>
    /// Balance representing the Forecast of the total of all cash-legs of transactions &apos;over the counter&apos; (OTC), going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;OTCC&quot;.
    /// </summary>
    [EnumMember(Value = "OTCC")]
    [IsoId("_uf-jkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through central counter party (CCP) functions."
    )]
    CCPGuaranteedOTCTransactions,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC).
    /// Encoded/decoded by serializers as &quot;OTCG&quot;.
    /// </summary>
    [EnumMember(Value = "OTCG")]
    [IsoId("_uf-jk_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC)."
    )]
    ForecastOTCTransactions,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC) not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;OTCN&quot;.
    /// </summary>
    [EnumMember(Value = "OTCN")]
    [IsoId("_uf-jlvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through central counter party (CCP) functions."
    )]
    NonCCPGuaranteedOTCTransactions,

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as &quot;OTHB&quot;.
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_ugIUkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement."
    )]
    OtherBlockedTrades,

    /// <summary>
    /// Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ugIUk_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed."
    )]
    Pending,

    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.||||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as &quot;PIPO&quot;.
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_ugIUlvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.||||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds."
    )]
    PayInPayOut,

    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_ugIUmfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period."
    )]
    ProgressiveAverage,

    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as &quot;PYMT&quot;.
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_ugIUnPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included."
    )]
    Payment,

    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as &quot;REJB&quot;.
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_ugRegPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected,

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo credits.
    /// Encoded/decoded by serializers as &quot;REPC&quot;.
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_ugReg_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo credits."
    )]
    CMUPRepoCredit,

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo debits.
    /// Encoded/decoded by serializers as &quot;REPD&quot;.
    /// </summary>
    [EnumMember(Value = "REPD")]
    [IsoId("_ugRehvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo debits."
    )]
    CMUPRepoDebit,

    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the &quot;escrow balance&quot; or &quot;sequestered balance&quot;.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ugReifRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance""."
    )]
    Restricted,

    /// <summary>
    /// Balance represents the settlement account processor direct credit amount.
    /// Encoded/decoded by serializers as &quot;SAPC&quot;.
    /// </summary>
    [EnumMember(Value = "SAPC")]
    [IsoId("_ugbPgPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the settlement account processor direct credit amount.")]
    SAPDirectCreditAmount,

    /// <summary>
    /// Balance represents the settlement account processor direct debit amount.
    /// Encoded/decoded by serializers as &quot;SAPD&quot;.
    /// </summary>
    [EnumMember(Value = "SAPD")]
    [IsoId("_ugbPg_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the settlement account processor direct debit amount.")]
    SAPDirectDebitAmount,

    /// <summary>
    /// Balance represents the settlement account processor queue amount.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_uglAgPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance represents the settlement account processor queue amount.")]
    SAPQueueAmount,

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as &quot;SCOL&quot;.
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_uglAg_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at."
    )]
    SelfCollateralisation,

    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as &quot;SCOU&quot;.
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_uglAhvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process."
    )]
    UsedAmountsSelfCollateralisation,

    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_uguKcPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self,

    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_uguKc_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit."
    )]
    Threshold,

    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as &quot;TOHB&quot;.
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_uguKdvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total of the payments that were put on hold because the limits have been exceeded."
    )]
    TotalOnHold,

    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as &quot;TPBL&quot;.
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_uguKefRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the total of the payments that have been processed and are waiting for settlement during the day."
    )]
    TotalProcessed,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.
    /// Encoded/decoded by serializers as &quot;XCHC&quot;.
    /// </summary>
    [EnumMember(Value = "XCHC")]
    [IsoId("_ug37cPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions."
    )]
    CCPGuaranteedForecasting,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as &quot;XCHG&quot;.
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_ug37c_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges."
    )]
    ExchangeForecast,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;XCHN&quot;.
    /// </summary>
    [EnumMember(Value = "XCHN")]
    [IsoId("_ug37dvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions."
    )]
    NonCCPGuaranteedForecasting,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as &quot;XCRD&quot;.
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_ug37efRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted."
    )]
    ExpectedCredit,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as &quot;XDBT&quot;.
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_ug37fPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted."
    )]
    ExpectedDebit,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_uhBFYPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    Expected,
}
