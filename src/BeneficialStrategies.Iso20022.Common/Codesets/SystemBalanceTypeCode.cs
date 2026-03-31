// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the system balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8KMm4qMgEeCJ6YNENx4h-w_-228547867")]
[Description(@"Specifies the nature of the system balance.")]
[Derivations(typeof(SystemBalanceType1Code), typeof(SystemBalanceType2Code))]
public enum SystemBalanceTypeCode
{
    /// <summary>
    /// Book balance of the account at the beginning of the account servicer&apos;s business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer&apos;s business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as &quot;OPNG&quot;.
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_8KMm46MgEeCJ6YNENx4h-w_-342386933")]
    [Description(
        @"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day."
    )]
    Opening,

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_8KMm5KMgEeCJ6YNENx4h-w_-1047501548")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    Interim,

    /// <summary>
    /// Balance of the account at the end of the account servicer&apos;s business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer&apos;s business day.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_8KMm5aMgEeCJ6YNENx4h-w_2072274723")]
    [Description(
        @"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day."
    )]
    Closing,

    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_8KWX4KMgEeCJ6YNENx4h-w_-577425138")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book,

    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as &quot;CRRT&quot;.
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_8KWX4aMgEeCJ6YNENx4h-w_961363304")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current,

    /// <summary>
    /// Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_8KWX4qMgEeCJ6YNENx4h-w_256248689")]
    [Description(
        @"Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed."
    )]
    Pending,

    /// <summary>
    /// Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_8KWX46MgEeCJ6YNENx4h-w_-918942336")]
    [Description(
        @"Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit."
    )]
    LimitRelated,

    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_8KWX5KMgEeCJ6YNENx4h-w_726325099")]
    [Description(
        @"Balance of money or securities that is at the disposal of the account owner on the date specified."
    )]
    Available,

    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as &quot;LTSF&quot;.
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_8KWX5aMgEeCJ6YNENx4h-w_577646719")]
    [Description(
        @"Balance composed of the sum of all liquidity transfers made to or from an account."
    )]
    LiquidityTransfer,

    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_8KWX5qMgEeCJ6YNENx4h-w_-127467896")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit,

    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_8KWX56MgEeCJ6YNENx4h-w_-1302658921")]
    [Description(
        @"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank."
    )]
    EligibleAssets,

    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as &quot;PYMT&quot;.
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_8KWX6KMgEeCJ6YNENx4h-w_342608514")]
    [Description(
        @"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included."
    )]
    Payment,

    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_8KgI4KMgEeCJ6YNENx4h-w_1881396956")]
    [Description(
        @"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance."
    )]
    Blocked,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_8KgI4aMgEeCJ6YNENx4h-w_1176282341")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    Expected,

    /// <summary>
    /// Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_8KgI4qMgEeCJ6YNENx4h-w_1091316")]
    [Description(
        @"Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day."
    )]
    DaylightOverdraft,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as &quot;XCRD&quot;.
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_8KgI46MgEeCJ6YNENx4h-w_1646358751")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted."
    )]
    ExpectedCredit,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as &quot;XDBT&quot;.
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_8KgI5KMgEeCJ6YNENx4h-w_-1109820103")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted."
    )]
    ExpectedDebit,

    /// <summary>
    /// Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_8KgI5aMgEeCJ6YNENx4h-w_-1814934718")]
    [Description(
        @"Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up."
    )]
    Adjustment,

    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_8KgI5qMgEeCJ6YNENx4h-w_1304841553")]
    [Description(
        @"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period."
    )]
    ProgressiveAverage,

    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_8KgI56MgEeCJ6YNENx4h-w_-1344858308")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit,

    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_8KgI6KMgEeCJ6YNENx4h-w_193930134")]
    [Description(
        @"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit."
    )]
    Threshold,

    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_8KpS0KMgEeCJ6YNENx4h-w_-511184481")]
    [Description(
        @"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available."
    )]
    Noted,

    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_8KpS0aMgEeCJ6YNENx4h-w_-1686375506")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self,

    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as &quot;MSTR&quot;.
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_8KpS0qMgEeCJ6YNENx4h-w_-41108071")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master,

    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as &quot;FSET&quot;.
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_8KpS06MgEeCJ6YNENx4h-w_1497680371")]
    [Description(
        @"Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement."
    )]
    ForecastSettlement,

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository&apos;s operates several settlements cycles per day.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_8KpS1KMgEeCJ6YNENx4h-w_792565756")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository's operates several settlements cycles per day."
    )]
    BlockedTrades,

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as &quot;OTHB&quot;.
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_8KpS1aMgEeCJ6YNENx4h-w_-382625269")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement."
    )]
    OtherBlockedTrades,

    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_8KpS1qMgEeCJ6YNENx4h-w_1262642166")]
    [Description(
        @"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc."
    )]
    Custody,

    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_8KpS16MgEeCJ6YNENx4h-w_-1493536688")]
    [Description(
        @"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions."
    )]
    CashForecast,

    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as &quot;COLC&quot;.
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_8KpS2KMgEeCJ6YNENx4h-w_2096315993")]
    [Description(
        @"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent."
    )]
    DividendsCollection,

    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_8KzD0KMgEeCJ6YNENx4h-w_921124968")]
    [Description(
        @"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement."
    )]
    NetFunding,

    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.
    /// Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as &quot;PIPO&quot;.
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_8KzD0aMgEeCJ6YNENx4h-w_-1728574893")]
    [Description(
        @"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds."
    )]
    PayInPayOut,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as &quot;XCHG&quot;.
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_8KzD0qMgEeCJ6YNENx4h-w_-189786451")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges."
    )]
    ExchangeForecast,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_8KzD06MgEeCJ6YNENx4h-w_-894901066")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality."
    )]
    CentralCounterparty,

    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as &quot;TOHB&quot;.
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_8KzD1KMgEeCJ6YNENx4h-w_-2070092091")]
    [Description(
        @"Balance representing the total of the payments that were put on hold because the limits have been exceeded."
    )]
    TotalOnHold,

    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;COHB&quot;.
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_8KzD1aMgEeCJ6YNENx4h-w_-424824656")]
    [Description(
        @"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded."
    )]
    CreditOnHold,

    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;DOHB&quot;.
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_8KzD1qMgEeCJ6YNENx4h-w_1113963786")]
    [Description(
        @"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded."
    )]
    DebitOnHold,

    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as &quot;TPBL&quot;.
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_8KzD16MgEeCJ6YNENx4h-w_408849171")]
    [Description(
        @"Balance representing the total of the payments that have been processed and are waiting for settlement during the day."
    )]
    TotalProcessed,

    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;CPBL&quot;.
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_8KzD2KMgEeCJ6YNENx4h-w_-766341854")]
    [Description(
        @"Balance representing the total incoming payments that have been processed and are waiting for settlement."
    )]
    CreditProcessed,

    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;DPBL&quot;.
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_8K8NwKMgEeCJ6YNENx4h-w_878925581")]
    [Description(
        @"Balance representing the total outgoing payments that have been processed and are waiting for settlement."
    )]
    DebitProcessed,

    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as &quot;FUTB&quot;.
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_8K8NwaMgEeCJ6YNENx4h-w_-1877253273")]
    [Description(
        @"Balance representing the total of the payments with a processing date in the future."
    )]
    TotalFuture,

    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as &quot;REJB&quot;.
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_8K8NwqMgEeCJ6YNENx4h-w_1712599408")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected,

    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;OPAV&quot;.
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_8K8Nw6MgEeCJ6YNENx4h-w_-1991576470")]
    [Description(
        @"Opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    OpeningAvailable,

    /// <summary>
    /// Available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITAV&quot;.
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_8K8NxKMgEeCJ6YNENx4h-w_-346309035")]
    [Description(
        @"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InterimAvailable,

    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CLAV&quot;.
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_8K8NxaMgEeCJ6YNENx4h-w_1192479407")]
    [Description(
        @"Closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    ClosingAvailable,

    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;FWAV&quot;.
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_8K8NxqMgEeCJ6YNENx4h-w_487364792")]
    [Description(
        @"Forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    ForwardAvailable,

    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;CLBD&quot;.
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_8K8Nx6MgEeCJ6YNENx4h-w_-687826233")]
    [Description(
        @"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    ClosingBooked,

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITBD&quot;.
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_8LF-wKMgEeCJ6YNENx4h-w_957441202")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InterimBooked,

    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;OPBD&quot;.
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_8LF-waMgEeCJ6YNENx4h-w_-1798737652")]
    [Description(
        @"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    OpeningBooked,

    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// Encoded/decoded by serializers as &quot;PRCD&quot;.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_8LF-wqMgEeCJ6YNENx4h-w_1791115029")]
    [Description(
        @"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date."
    )]
    PreviouslyClosedBooked,

    /// <summary>
    /// Investment opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;IOPA&quot;.
    /// </summary>
    [EnumMember(Value = "IOPA")]
    [IsoId("_8LF-w6MgEeCJ6YNENx4h-w_615924004")]
    [Description(
        @"Investment opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentOpeningAvailable,

    /// <summary>
    /// Investment available balance for calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;IITA&quot;.
    /// </summary>
    [EnumMember(Value = "IITA")]
    [IsoId("_8LF-xKMgEeCJ6YNENx4h-w_-2033775857")]
    [Description(
        @"Investment available balance for calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InvestmentInterimAvailable,

    /// <summary>
    /// Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;ICLA&quot;.
    /// </summary>
    [EnumMember(Value = "ICLA")]
    [IsoId("_8LF-xaMgEeCJ6YNENx4h-w_-494987415")]
    [Description(
        @"Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentClosingAvailable,

    /// <summary>
    /// Investment forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;IFWA&quot;.
    /// </summary>
    [EnumMember(Value = "IFWA")]
    [IsoId("_8LF-xqMgEeCJ6YNENx4h-w_-1200102030")]
    [Description(
        @"Investment forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentForwardAvailable,

    /// <summary>
    /// Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;ICLB&quot;.
    /// </summary>
    [EnumMember(Value = "ICLB")]
    [IsoId("_8LF-x6MgEeCJ6YNENx4h-w_1919674241")]
    [Description(
        @"Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    InvestmentClosingBooked,

    /// <summary>
    /// Investment balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;IITB&quot;.
    /// </summary>
    [EnumMember(Value = "IITB")]
    [IsoId("_8LF-yKMgEeCJ6YNENx4h-w_-730025620")]
    [Description(
        @"Investment balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InvestmentInterimBooked,

    /// <summary>
    /// Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report. ||.
    /// Encoded/decoded by serializers as &quot;IOPB&quot;.
    /// </summary>
    [EnumMember(Value = "IOPB")]
    [IsoId("_8LPvwKMgEeCJ6YNENx4h-w_885801523")]
    [Description(
        @"Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report. ||."
    )]
    InvestmentOpeningBooked,

    /// <summary>
    /// Investment balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;IXPC&quot;.
    /// </summary>
    [EnumMember(Value = "IXPC")]
    [IsoId("_8LPvwaMgEeCJ6YNENx4h-w_-1431218133")]
    [Description(
        @"Investment balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    InvestmentExpected,

    /// <summary>
    /// Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DOPA&quot;.
    /// </summary>
    [EnumMember(Value = "DOPA")]
    [IsoId("_8LPvwqMgEeCJ6YNENx4h-w_1688558138")]
    [Description(
        @"Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementOpeningAvailable,

    /// <summary>
    /// Disbursement available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;DITA&quot;.
    /// </summary>
    [EnumMember(Value = "DITA")]
    [IsoId("_8LPvw6MgEeCJ6YNENx4h-w_-961141723")]
    [Description(
        @"Disbursement available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    DisbursementInterimAvailable,

    /// <summary>
    /// Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DCLA&quot;.
    /// </summary>
    [EnumMember(Value = "DCLA")]
    [IsoId("_8LPvxKMgEeCJ6YNENx4h-w_577646719")]
    [Description(
        @"Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementClosingAvailable,

    /// <summary>
    /// Disbursement forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DFWA&quot;.
    /// </summary>
    [EnumMember(Value = "DFWA")]
    [IsoId("_8LPvxaMgEeCJ6YNENx4h-w_-127467896")]
    [Description(
        @"Disbursement forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementForwardAvailable,

    /// <summary>
    /// Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;DCLB&quot;.
    /// </summary>
    [EnumMember(Value = "DCLB")]
    [IsoId("_8LPvxqMgEeCJ6YNENx4h-w_-1302658921")]
    [Description(
        @"Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    DisbursementClosingBooked,

    /// <summary>
    /// Disbursement balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;DITB&quot;.
    /// </summary>
    [EnumMember(Value = "DITB")]
    [IsoId("_8LPvx6MgEeCJ6YNENx4h-w_342608514")]
    [Description(
        @"Disbursement balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    DisbursementInterimBooked,

    /// <summary>
    /// Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;DOPB&quot;.
    /// </summary>
    [EnumMember(Value = "DOPB")]
    [IsoId("_8LPvyKMgEeCJ6YNENx4h-w_1881396956")]
    [Description(
        @"Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    DisbursementOpeningBooked,

    /// <summary>
    /// Disbursement balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;DXPC&quot;.
    /// </summary>
    [EnumMember(Value = "DXPC")]
    [IsoId("_8LY5sKMgEeCJ6YNENx4h-w_1176282341")]
    [Description(
        @"Disbursement balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    DisbursementExpected,

    /// <summary>
    /// Collection opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;COPA&quot;.
    /// </summary>
    [EnumMember(Value = "COPA")]
    [IsoId("_8LY5saMgEeCJ6YNENx4h-w_1091316")]
    [Description(
        @"Collection opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionOpeningAvailable,

    /// <summary>
    /// Collection available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;CITA&quot;.
    /// </summary>
    [EnumMember(Value = "CITA")]
    [IsoId("_8LY5sqMgEeCJ6YNENx4h-w_1646358751")]
    [Description(
        @"Collection available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    CollectionInterimAvailable,

    /// <summary>
    /// Collection closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CCLA&quot;.
    /// </summary>
    [EnumMember(Value = "CCLA")]
    [IsoId("_8LY5s6MgEeCJ6YNENx4h-w_-1109820103")]
    [Description(
        @"Collection closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionClosingAvailable,

    /// <summary>
    /// Collection forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CFWA&quot;.
    /// </summary>
    [EnumMember(Value = "CFWA")]
    [IsoId("_8LY5tKMgEeCJ6YNENx4h-w_-1814934718")]
    [Description(
        @"Collection forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionForwardAvailable,

    /// <summary>
    /// Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;CCLB&quot;.
    /// </summary>
    [EnumMember(Value = "CCLB")]
    [IsoId("_8LY5taMgEeCJ6YNENx4h-w_1304841553")]
    [Description(
        @"Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    CollectionClosingBooked,

    /// <summary>
    /// Collection balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;CITB&quot;.
    /// </summary>
    [EnumMember(Value = "CITB")]
    [IsoId("_8LY5tqMgEeCJ6YNENx4h-w_-1344858308")]
    [Description(
        @"Collection balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    CollectionInterimBooked,

    /// <summary>
    /// Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;COPB&quot;.
    /// </summary>
    [EnumMember(Value = "COPB")]
    [IsoId("_8LY5t6MgEeCJ6YNENx4h-w_193930134")]
    [Description(
        @"Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    CollectionOpeningBooked,

    /// <summary>
    /// Collection balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;CXPC&quot;.
    /// </summary>
    [EnumMember(Value = "CXPC")]
    [IsoId("_8LY5uKMgEeCJ6YNENx4h-w_-511184481")]
    [Description(
        @"Collection balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    CollectionExpected,

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_8LiqsKMgEeCJ6YNENx4h-w_-1686375506")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral."
    )]
    FirmCollateralisation,

    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as &quot;FCOU&quot;.
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_8LiqsaMgEeCJ6YNENx4h-w_-41108071")]
    [Description(
        @"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral."
    )]
    UsedAmountsFirmCollateralisation,

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as &quot;SCOL&quot;.
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_8LiqsqMgEeCJ6YNENx4h-w_1497680371")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at."
    )]
    SelfCollateralisation,

    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as &quot;SCOU&quot;.
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_8Liqs6MgEeCJ6YNENx4h-w_792565756")]
    [Description(
        @"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process."
    )]
    UsedAmountsSelfCollateralisation,

    /// <summary>
    /// Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.
    /// Encoded/decoded by serializers as &quot;CUSA&quot;.
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_8LiqtKMgEeCJ6YNENx4h-w_-382625269")]
    [Description(
        @"Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc."
    )]
    CustodyActual,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.
    /// Encoded/decoded by serializers as &quot;XCHC&quot;.
    /// </summary>
    [EnumMember(Value = "XCHC")]
    [IsoId("_8LiqtaMgEeCJ6YNENx4h-w_1262642166")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions."
    )]
    CCPGuaranteedForecasting,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;XCHN&quot;.
    /// </summary>
    [EnumMember(Value = "XCHN")]
    [IsoId("_8LiqtqMgEeCJ6YNENx4h-w_-1493536688")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions."
    )]
    NonCCPGuaranteedForecasting,

    /// <summary>
    /// Balance representing the cash equivalent of all settled securities transactions.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_8Liqt6MgEeCJ6YNENx4h-w_2096315993")]
    [Description(
        @"Balance representing the cash equivalent of all settled securities transactions."
    )]
    DefinitiveSettledSecurities,

    /// <summary>
    /// Balance representing the cash equivalent of transactions with a lack of holdings.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_8LiquKMgEeCJ6YNENx4h-w_921124968")]
    [Description(
        @"Balance representing the cash equivalent of transactions with a lack of holdings."
    )]
    LackOfHoldingsTransactions,

    /// <summary>
    /// Balance representing the cash equivalent of all non-settled securities transactions.
    /// Encoded/decoded by serializers as &quot;NSET&quot;.
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_8LsbsKMgEeCJ6YNENx4h-w_-1728574893")]
    [Description(
        @"Balance representing the cash equivalent of all non-settled securities transactions."
    )]
    NonSettledSecurities,

    /// <summary>
    /// Balance representing the Forecast of the total of all cash-legs of transactions &apos;over the counter&apos; (OTC), going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;OTCC&quot;.
    /// </summary>
    [EnumMember(Value = "OTCC")]
    [IsoId("_8LsbsaMgEeCJ6YNENx4h-w_-189786451")]
    [Description(
        @"Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through central counter party (CCP) functions."
    )]
    CCPGuaranteedOTCTransactions,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC).
    /// Encoded/decoded by serializers as &quot;OTCG&quot;.
    /// </summary>
    [EnumMember(Value = "OTCG")]
    [IsoId("_8LsbsqMgEeCJ6YNENx4h-w_-894901066")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC)."
    )]
    ForecastOTCTransactions,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC) not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;OTCN&quot;.
    /// </summary>
    [EnumMember(Value = "OTCN")]
    [IsoId("_8Lsbs6MgEeCJ6YNENx4h-w_-2070092091")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through central counter party (CCP) functions."
    )]
    NonCCPGuaranteedOTCTransactions,

    /// <summary>
    /// Balance represents the settlement account processor direct debit amount.
    /// Encoded/decoded by serializers as &quot;SAPD&quot;.
    /// </summary>
    [EnumMember(Value = "SAPD")]
    [IsoId("_8LsbtKMgEeCJ6YNENx4h-w_-424824656")]
    [Description(@"Balance represents the settlement account processor direct debit amount.")]
    SAPDirectDebitAmount,

    /// <summary>
    /// Balance represents the settlement account processor direct credit amount.
    /// Encoded/decoded by serializers as &quot;SAPC&quot;.
    /// </summary>
    [EnumMember(Value = "SAPC")]
    [IsoId("_8LsbtaMgEeCJ6YNENx4h-w_1113963786")]
    [Description(@"Balance represents the settlement account processor direct credit amount.")]
    SAPDirectCreditAmount,

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo debits.
    /// Encoded/decoded by serializers as &quot;REPD&quot;.
    /// </summary>
    [EnumMember(Value = "REPD")]
    [IsoId("_8LsbtqMgEeCJ6YNENx4h-w_408849171")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo debits."
    )]
    CMUPRepoDebit,

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo credits.
    /// Encoded/decoded by serializers as &quot;REPC&quot;.
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_8Lsbt6MgEeCJ6YNENx4h-w_-766341854")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo credits."
    )]
    CMUPRepoCredit,

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.
    /// Encoded/decoded by serializers as &quot;BSCD&quot;.
    /// </summary>
    [EnumMember(Value = "BSCD")]
    [IsoId("_8LsbuKMgEeCJ6YNENx4h-w_878925581")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor debit."
    )]
    BulkSettlementCMUPDebit,

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.
    /// Encoded/decoded by serializers as &quot;BSCC&quot;.
    /// </summary>
    [EnumMember(Value = "BSCC")]
    [IsoId("_8L1loKMgEeCJ6YNENx4h-w_-1877253273")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor credit."
    )]
    BulkSettlementCMUPCredit,

    /// <summary>
    /// Balance represents the settlement account processor queue amount.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_8L1loaMgEeCJ6YNENx4h-w_25132586")]
    [Description(@"Balance represents the settlement account processor queue amount.")]
    SAPQueueAmount,

    /// <summary>
    /// Balance represents the intraday repo limit.
    /// Encoded/decoded by serializers as &quot;IRLT&quot;.
    /// </summary>
    [EnumMember(Value = "IRLT")]
    [IsoId("_8L1loqMgEeCJ6YNENx4h-w_-1150058439")]
    [Description(@"Balance represents the intraday repo limit.")]
    IntradayRepoLimit,

    /// <summary>
    /// Balance represents the intraday repo drawings.
    /// Encoded/decoded by serializers as &quot;IRDR&quot;.
    /// </summary>
    [EnumMember(Value = "IRDR")]
    [IsoId("_8L1lo6MgEeCJ6YNENx4h-w_495208996")]
    [Description(@"Balance represents the intraday repo drawings.")]
    IntradayRepoDrawings,

    /// <summary>
    /// Balance represents the discount window repo drawings.
    /// Encoded/decoded by serializers as &quot;DWRD&quot;.
    /// </summary>
    [EnumMember(Value = "DWRD")]
    [IsoId("_8L1lpKMgEeCJ6YNENx4h-w_2033997438")]
    [Description(@"Balance represents the discount window repo drawings.")]
    DiscountWindowRepoDrawings,

    /// <summary>
    /// Balance represents the available discounted market value for discount window repo.
    /// Encoded/decoded by serializers as &quot;ADWR&quot;.
    /// </summary>
    [EnumMember(Value = "ADWR")]
    [IsoId("_8L1lpaMgEeCJ6YNENx4h-w_1328882823")]
    [Description(
        @"Balance represents the available discounted market value for discount window repo."
    )]
    AvailableDMVForDiscountWindowRepo,

    /// <summary>
    /// Balance represents the available discounted market value for intraday repo.
    /// Encoded/decoded by serializers as &quot;AIDR&quot;.
    /// </summary>
    [EnumMember(Value = "AIDR")]
    [IsoId("_8L1lpqMgEeCJ6YNENx4h-w_153691798")]
    [Description(@"Balance represents the available discounted market value for intraday repo.")]
    AvailableDMVForIntradayRepo,

    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_8L1lp6MgEeCJ6YNENx4h-w_1798959233")]
    [Description(@"Balance of instructed position.")]
    Elected,

    /// <summary>
    /// Balance of financial instruments that are reserved for the distribution of the proceeds.
    /// Encoded/decoded by serializers as &quot;RDIS&quot;.
    /// </summary>
    [EnumMember(Value = "RDIS")]
    [IsoId("_8L1lqKMgEeCJ6YNENx4h-w_-957219621")]
    [Description(
        @"Balance of financial instruments that are reserved for the distribution of the proceeds."
    )]
    ReservedForDistribution,

    /// <summary>
    /// Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged.
    /// Encoded/decoded by serializers as &quot;RREM&quot;.
    /// </summary>
    [EnumMember(Value = "RREM")]
    [IsoId("_8L_WoKMgEeCJ6YNENx4h-w_-1662334236")]
    [Description(
        @"Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged."
    )]
    ReservedForRemoval,

    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the &quot;escrow balance&quot; or &quot;sequestered balance&quot;.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_8L_WoaMgEeCJ6YNENx4h-w_1457442035")]
    [Description(
        @"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance""."
    )]
    Restricted,

    /// <summary>
    /// Total quantity of financial instruments entitled to the account owner based on the terms of the corporate action event.|.
    /// Encoded/decoded by serializers as &quot;TENT&quot;.
    /// </summary>
    [EnumMember(Value = "TENT")]
    [IsoId("_8L_WoqMgEeCJ6YNENx4h-w_-1192257826")]
    [Description(
        @"Total quantity of financial instruments entitled to the account owner based on the terms of the corporate action event.|."
    )]
    TotalEntitled,

    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as &quot;UNEL&quot;.
    /// </summary>
    [EnumMember(Value = "UNEL")]
    [IsoId("_8L_Wo6MgEeCJ6YNENx4h-w_346530616")]
    [Description(@"Balance of uninstructed position.")]
    Unelected,

    /// <summary>
    /// Balance for informational purposes.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_8L_WpKMgEeCJ6YNENx4h-w_-358583999")]
    [Description(@"Balance for informational purposes.")]
    Information,
}
