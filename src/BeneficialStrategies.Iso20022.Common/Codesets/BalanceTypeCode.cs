// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bbFhQNp-Ed-ak6NoX_4Aeg_142948041")]
[Description(@"Specifies the nature of the balance.")]
[Derivations(
    typeof(SecuritiesBalanceType6Code),
    typeof(BalanceType7Code),
    typeof(BalanceType11Code),
    typeof(BalanceType14Code),
    typeof(BalanceType10Code),
    typeof(BalanceType15Code),
    typeof(CashBalanceType1Code),
    typeof(BalanceType12Code),
    typeof(SecuritiesBalanceType9Code),
    typeof(BalanceType6Code),
    typeof(BalanceType13Code),
    typeof(SecuritiesBalanceType10Code),
    typeof(BalanceType8Code),
    typeof(BalanceType9Code)
)]
public enum BalanceTypeCode
{
    /// <summary>
    /// Balance attributed to receivables.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_m88a4PNBEeCuA5Tr22BnwA_-921442707")]
    [Description(@"Balance attributed to receivables.")]
    Receivables,

    /// <summary>
    /// Balance attributed to payables.
    /// Encoded/decoded by serializers as &quot;PAYA&quot;.
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_m8zQ9fNBEeCuA5Tr22BnwA_1566178121")]
    [Description(@"Balance attributed to payables.")]
    Payables,

    /// <summary>
    /// Balance attributed according to a different classification, which is not explictly defined.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_m8zQ9PNBEeCuA5Tr22BnwA_318203945")]
    [Description(
        @"Balance attributed according to a different classification, which is not explictly defined."
    )]
    Other,

    /// <summary>
    /// Balance attributed to expenses.
    /// Encoded/decoded by serializers as &quot;EXPN&quot;.
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_m8zQ8_NBEeCuA5Tr22BnwA_610384908")]
    [Description(@"Balance attributed to expenses.")]
    Expenses,

    /// <summary>
    /// Balance attributed to cash and cash equivalents.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_m8zQ8vNBEeCuA5Tr22BnwA_1785575933")]
    [Description(@"Balance attributed to cash and cash equivalents.")]
    CashAndCashEquivalents,

    /// <summary>
    /// Balance attributed to investor inflow/outflow (creations, cancellations, income distributions).
    /// Encoded/decoded by serializers as &quot;IIOF&quot;.
    /// </summary>
    [EnumMember(Value = "IIOF")]
    [IsoId("_m8zQ8fNBEeCuA5Tr22BnwA_-1804276748")]
    [Description(
        @"Balance attributed to investor inflow/outflow (creations, cancellations, income distributions)."
    )]
    InvestorInflowOutflow,

    /// <summary>
    /// Balance attributed to revenues; including dividends, interest, net realised gains/losses etc.
    /// Encoded/decoded by serializers as &quot;REVE&quot;.
    /// </summary>
    [EnumMember(Value = "REVE")]
    [IsoId("_m8zQ8PNBEeCuA5Tr22BnwA_951902106")]
    [Description(
        @"Balance attributed to revenues; including dividends, interest, net realised gains/losses etc."
    )]
    Revenues,

    /// <summary>
    /// Balance attributed to borrowings.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_m8pf9fNBEeCuA5Tr22BnwA_-693365329")]
    [Description(@"Balance attributed to borrowings.")]
    Borrowings,

    /// <summary>
    /// Balance attributed to investments at value.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_m8pf9PNBEeCuA5Tr22BnwA_-1147452598")]
    [Description(@"Balance attributed to investments at value.")]
    Investments,

    /// <summary>
    /// Book balance of the account at the beginning of the account servicer&apos;s business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer&apos;s business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as &quot;OPNG&quot;.
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_bbFhQdp-Ed-ak6NoX_4Aeg_142948042")]
    [Description(
        @"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day."
    )]
    Opening,

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_bbFhQtp-Ed-ak6NoX_4Aeg_142948043")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    Interim,

    /// <summary>
    /// Balance of the account at the end of the account servicer&apos;s business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer&apos;s business day.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_bbFhQ9p-Ed-ak6NoX_4Aeg_142948044")]
    [Description(
        @"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day."
    )]
    Closing,

    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_bbFhRNp-Ed-ak6NoX_4Aeg_142948052")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book,

    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as &quot;CRRT&quot;.
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_bbFhRdp-Ed-ak6NoX_4Aeg_142948053")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current,

    /// <summary>
    /// Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_bbFhRtp-Ed-ak6NoX_4Aeg_142948054")]
    [Description(
        @"Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed."
    )]
    Pending,

    /// <summary>
    /// Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_bbFhR9p-Ed-ak6NoX_4Aeg_142948055")]
    [Description(
        @"Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit."
    )]
    LimitRelated,

    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_bbFhSNp-Ed-ak6NoX_4Aeg_142948056")]
    [Description(
        @"Balance of money or securities that is at the disposal of the account owner on the date specified."
    )]
    Available,

    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as &quot;LTSF&quot;.
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_bbFhSdp-Ed-ak6NoX_4Aeg_-98200544")]
    [Description(
        @"Balance composed of the sum of all liquidity transfers made to or from an account."
    )]
    LiquidityTransfer,

    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_bbPSQNp-Ed-ak6NoX_4Aeg_-98200543")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit,

    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_bbPSQdp-Ed-ak6NoX_4Aeg_-98200542")]
    [Description(
        @"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank."
    )]
    EligibleAssets,

    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as &quot;PYMT&quot;.
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_bbPSQtp-Ed-ak6NoX_4Aeg_-98200533")]
    [Description(
        @"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included."
    )]
    Payment,

    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_bbPSQ9p-Ed-ak6NoX_4Aeg_-98200532")]
    [Description(
        @"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance."
    )]
    Blocked,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_bbPSRNp-Ed-ak6NoX_4Aeg_-98200531")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    Expected,

    /// <summary>
    /// Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_bbPSRdp-Ed-ak6NoX_4Aeg_-98200530")]
    [Description(
        @"Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day."
    )]
    DaylightOverdraft,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as &quot;XCRD&quot;.
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_bbPSRtp-Ed-ak6NoX_4Aeg_-98200529")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted."
    )]
    ExpectedCredit,

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as &quot;XDBT&quot;.
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_bbPSR9p-Ed-ak6NoX_4Aeg_-98200528")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted."
    )]
    ExpectedDebit,

    /// <summary>
    /// Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank&apos;s balance is equal to the reserve due during the remaining days of the maintenance period.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_bbPSSNp-Ed-ak6NoX_4Aeg_1590709571")]
    [Description(
        @"Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank's balance is equal to the reserve due during the remaining days of the maintenance period."
    )]
    Adjustment,

    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_bbPSSdp-Ed-ak6NoX_4Aeg_1590709572")]
    [Description(
        @"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period."
    )]
    ProgressiveAverage,

    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_bbYcMNp-Ed-ak6NoX_4Aeg_2140677250")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit,

    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_bbYcMdp-Ed-ak6NoX_4Aeg_318636677")]
    [Description(
        @"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit."
    )]
    Threshold,

    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_bbYcMtp-Ed-ak6NoX_4Aeg_318637020")]
    [Description(
        @"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available."
    )]
    Noted,

    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_bbYcM9p-Ed-ak6NoX_4Aeg_318637045")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self,

    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as &quot;MSTR&quot;.
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_bbYcNNp-Ed-ak6NoX_4Aeg_318637115")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master,

    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as &quot;FSET&quot;.
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_bbYcNdp-Ed-ak6NoX_4Aeg_1245599539")]
    [Description(
        @"Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement."
    )]
    ForecastSettlement,

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD&apos;s operates several settlements cycles per day.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_bbYcNtp-Ed-ak6NoX_4Aeg_1245599582")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD's operates several settlements cycles per day."
    )]
    BlockedTrades,

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as &quot;OTHB&quot;.
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_bbYcN9p-Ed-ak6NoX_4Aeg_1245599617")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement."
    )]
    OtherBlockedTrades,

    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bbYcONp-Ed-ak6NoX_4Aeg_1245599652")]
    [Description(
        @"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc."
    )]
    Custody,

    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_bbYcOdp-Ed-ak6NoX_4Aeg_1245599960")]
    [Description(
        @"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions."
    )]
    CashForecast,

    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as &quot;COLC&quot;.
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_bbiNMNp-Ed-ak6NoX_4Aeg_1245600002")]
    [Description(
        @"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent."
    )]
    DividendsCollection,

    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_bbiNMdp-Ed-ak6NoX_4Aeg_1245600037")]
    [Description(
        @"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement."
    )]
    NetFunding,

    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as &quot;PIPO&quot;.
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_bbiNMtp-Ed-ak6NoX_4Aeg_1245600140")]
    [Description(
        @"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds."
    )]
    PayInPayOut,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as &quot;XCHG&quot;.
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_bbiNM9p-Ed-ak6NoX_4Aeg_1245600175")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges."
    )]
    ExchangeForecast,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_bbiNNNp-Ed-ak6NoX_4Aeg_1245600210")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality."
    )]
    CentralCounterparty,

    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as &quot;TOHB&quot;.
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_bbiNNdp-Ed-ak6NoX_4Aeg_1245600487")]
    [Description(
        @"Balance representing the total of the payments that were put on hold because the limits have been exceeded."
    )]
    TotalOnHold,

    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;COHB&quot;.
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_bbiNNtp-Ed-ak6NoX_4Aeg_1245600547")]
    [Description(
        @"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded."
    )]
    CreditOnHold,

    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;DOHB&quot;.
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_bbiNN9p-Ed-ak6NoX_4Aeg_1246520561")]
    [Description(
        @"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded."
    )]
    DebitOnHold,

    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as &quot;TPBL&quot;.
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_bbiNONp-Ed-ak6NoX_4Aeg_1246520613")]
    [Description(
        @"Balance representing the total of the payments that have been processed and are waiting for settlement during the day."
    )]
    TotalProcessed,

    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;CPBL&quot;.
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_bbiNOdp-Ed-ak6NoX_4Aeg_1246520656")]
    [Description(
        @"Balance representing the total incoming payments that have been processed and are waiting for settlement."
    )]
    CreditProcessed,

    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;DPBL&quot;.
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_bbrXINp-Ed-ak6NoX_4Aeg_1246520716")]
    [Description(
        @"Balance representing the total outgoing payments that have been processed and are waiting for settlement."
    )]
    DebitProcessed,

    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as &quot;FUTB&quot;.
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_bbrXIdp-Ed-ak6NoX_4Aeg_1246520768")]
    [Description(
        @"Balance representing the total of the payments with a processing date in the future."
    )]
    TotalFuture,

    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as &quot;REJB&quot;.
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_bbrXItp-Ed-ak6NoX_4Aeg_1246520828")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected,

    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;OPAV&quot;.
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_bbrXI9p-Ed-ak6NoX_4Aeg_34178739")]
    [Description(
        @"Opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    OpeningAvailable,

    /// <summary>
    /// Available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITAV&quot;.
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_bbrXJNp-Ed-ak6NoX_4Aeg_34178859")]
    [Description(
        @"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InterimAvailable,

    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CLAV&quot;.
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_bbrXJdp-Ed-ak6NoX_4Aeg_34179172")]
    [Description(
        @"Closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    ClosingAvailable,

    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;FWAV&quot;.
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_bbrXJtp-Ed-ak6NoX_4Aeg_34179249")]
    [Description(
        @"Forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    ForwardAvailable,

    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;CLBD&quot;.
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_bbrXJ9p-Ed-ak6NoX_4Aeg_34179592")]
    [Description(
        @"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    ClosingBooked,

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITBD&quot;.
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_bbrXKNp-Ed-ak6NoX_4Aeg_34179695")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InterimBooked,

    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;OPBD&quot;.
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_bbrXKdp-Ed-ak6NoX_4Aeg_34179790")]
    [Description(
        @"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    OpeningBooked,

    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// Encoded/decoded by serializers as &quot;PRCD&quot;.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_bbrXKtp-Ed-ak6NoX_4Aeg_-404402186")]
    [Description(
        @"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date."
    )]
    PreviouslyClosedBooked,

    /// <summary>
    /// Investment opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;IOPA&quot;.
    /// </summary>
    [EnumMember(Value = "IOPA")]
    [IsoId("_bb1IINp-Ed-ak6NoX_4Aeg_2022285008")]
    [Description(
        @"Investment opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentOpeningAvailable,

    /// <summary>
    /// Investment available balance for calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;IITA&quot;.
    /// </summary>
    [EnumMember(Value = "IITA")]
    [IsoId("_bb1IIdp-Ed-ak6NoX_4Aeg_2022285069")]
    [Description(
        @"Investment available balance for calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InvestmentInterimAvailable,

    /// <summary>
    /// Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;ICLA&quot;.
    /// </summary>
    [EnumMember(Value = "ICLA")]
    [IsoId("_bb1IItp-Ed-ak6NoX_4Aeg_2022285100")]
    [Description(
        @"Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentClosingAvailable,

    /// <summary>
    /// Investment forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;IFWA&quot;.
    /// </summary>
    [EnumMember(Value = "IFWA")]
    [IsoId("_bb1II9p-Ed-ak6NoX_4Aeg_2022285161")]
    [Description(
        @"Investment forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentForwardAvailable,

    /// <summary>
    /// Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;ICLB&quot;.
    /// </summary>
    [EnumMember(Value = "ICLB")]
    [IsoId("_bb1IJNp-Ed-ak6NoX_4Aeg_2067534871")]
    [Description(
        @"Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    InvestmentClosingBooked,

    /// <summary>
    /// Investment balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;IITB&quot;.
    /// </summary>
    [EnumMember(Value = "IITB")]
    [IsoId("_bb1IJdp-Ed-ak6NoX_4Aeg_2067535118")]
    [Description(
        @"Investment balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InvestmentInterimBooked,

    /// <summary>
    /// Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;IOPB&quot;.
    /// </summary>
    [EnumMember(Value = "IOPB")]
    [IsoId("_bb1IJtp-Ed-ak6NoX_4Aeg_2067535180")]
    [Description(
        @"Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    InvestmentOpeningBooked,

    /// <summary>
    /// Investment balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;IXPC&quot;.
    /// </summary>
    [EnumMember(Value = "IXPC")]
    [IsoId("_bb1IJ9p-Ed-ak6NoX_4Aeg_-2099062636")]
    [Description(
        @"Investment balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    InvestmentExpected,

    /// <summary>
    /// Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DOPA&quot;.
    /// </summary>
    [EnumMember(Value = "DOPA")]
    [IsoId("_bb1IKNp-Ed-ak6NoX_4Aeg_-1471066121")]
    [Description(
        @"Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementOpeningAvailable,

    /// <summary>
    /// Disbursement available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;DITA&quot;.
    /// </summary>
    [EnumMember(Value = "DITA")]
    [IsoId("_bb1IKdp-Ed-ak6NoX_4Aeg_-1471066060")]
    [Description(
        @"Disbursement available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    DisbursementInterimAvailable,

    /// <summary>
    /// Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DCLA&quot;.
    /// </summary>
    [EnumMember(Value = "DCLA")]
    [IsoId("_bb-5INp-Ed-ak6NoX_4Aeg_-1471066029")]
    [Description(
        @"Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementClosingAvailable,

    /// <summary>
    /// Disbursement forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DFWA&quot;.
    /// </summary>
    [EnumMember(Value = "DFWA")]
    [IsoId("_bb-5Idp-Ed-ak6NoX_4Aeg_-1471065968")]
    [Description(
        @"Disbursement forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementForwardAvailable,

    /// <summary>
    /// Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;DCLB&quot;.
    /// </summary>
    [EnumMember(Value = "DCLB")]
    [IsoId("_bb-5Itp-Ed-ak6NoX_4Aeg_-1471065937")]
    [Description(
        @"Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    DisbursementClosingBooked,

    /// <summary>
    /// Disbursement balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;DITB&quot;.
    /// </summary>
    [EnumMember(Value = "DITB")]
    [IsoId("_bb-5I9p-Ed-ak6NoX_4Aeg_-1471065876")]
    [Description(
        @"Disbursement balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    DisbursementInterimBooked,

    /// <summary>
    /// Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;DOPB&quot;.
    /// </summary>
    [EnumMember(Value = "DOPB")]
    [IsoId("_bb-5JNp-Ed-ak6NoX_4Aeg_-1471065853")]
    [Description(
        @"Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    DisbursementOpeningBooked,

    /// <summary>
    /// Disbursement balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;DXPC&quot;.
    /// </summary>
    [EnumMember(Value = "DXPC")]
    [IsoId("_bb-5Jdp-Ed-ak6NoX_4Aeg_-1471065574")]
    [Description(
        @"Disbursement balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    DisbursementExpected,

    /// <summary>
    /// Collection opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;COPA&quot;.
    /// </summary>
    [EnumMember(Value = "COPA")]
    [IsoId("_bb-5Jtp-Ed-ak6NoX_4Aeg_-1309452612")]
    [Description(
        @"Collection opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionOpeningAvailable,

    /// <summary>
    /// Collection available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;CITA&quot;.
    /// </summary>
    [EnumMember(Value = "CITA")]
    [IsoId("_bb-5J9p-Ed-ak6NoX_4Aeg_-1309452582")]
    [Description(
        @"Collection available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    CollectionInterimAvailable,

    /// <summary>
    /// Collection closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CCLA&quot;.
    /// </summary>
    [EnumMember(Value = "CCLA")]
    [IsoId("_bb-5KNp-Ed-ak6NoX_4Aeg_-1309452304")]
    [Description(
        @"Collection closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionClosingAvailable,

    /// <summary>
    /// Collection forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CFWA&quot;.
    /// </summary>
    [EnumMember(Value = "CFWA")]
    [IsoId("_bb-5Kdp-Ed-ak6NoX_4Aeg_-1309452242")]
    [Description(
        @"Collection forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionForwardAvailable,

    /// <summary>
    /// Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;CCLB&quot;.
    /// </summary>
    [EnumMember(Value = "CCLB")]
    [IsoId("_bcIDENp-Ed-ak6NoX_4Aeg_-1309452212")]
    [Description(
        @"Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    CollectionClosingBooked,

    /// <summary>
    /// Collection balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;CITB&quot;.
    /// </summary>
    [EnumMember(Value = "CITB")]
    [IsoId("_bcIDEdp-Ed-ak6NoX_4Aeg_-1309452150")]
    [Description(
        @"Collection balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    CollectionInterimBooked,

    /// <summary>
    /// Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;COPB&quot;.
    /// </summary>
    [EnumMember(Value = "COPB")]
    [IsoId("_bcIDEtp-Ed-ak6NoX_4Aeg_-1309451848")]
    [Description(
        @"Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    CollectionOpeningBooked,

    /// <summary>
    /// Collection balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;CXPC&quot;.
    /// </summary>
    [EnumMember(Value = "CXPC")]
    [IsoId("_bcIDE9p-Ed-ak6NoX_4Aeg_-1293749997")]
    [Description(
        @"Collection balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    CollectionExpected,

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_bcIDFNp-Ed-ak6NoX_4Aeg_1052556760")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral."
    )]
    FirmCollateralisation,

    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as &quot;FCOU&quot;.
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_bcIDFdp-Ed-ak6NoX_4Aeg_980521166")]
    [Description(
        @"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral."
    )]
    UsedAmountsFirmCollateralisation,

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as &quot;SCOL&quot;.
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_bcIDFtp-Ed-ak6NoX_4Aeg_980521628")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at."
    )]
    SelfCollateralisation,

    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as &quot;SCOU&quot;.
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_bcIDF9p-Ed-ak6NoX_4Aeg_980521781")]
    [Description(
        @"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process."
    )]
    UsedAmountsSelfCollateralisation,

    /// <summary>
    /// Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.
    /// Encoded/decoded by serializers as &quot;CUSA&quot;.
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_bcIDGNp-Ed-ak6NoX_4Aeg_980522182")]
    [Description(
        @"Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc."
    )]
    CustodyActual,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.
    /// Encoded/decoded by serializers as &quot;XCHC&quot;.
    /// </summary>
    [EnumMember(Value = "XCHC")]
    [IsoId("_bcIDGdp-Ed-ak6NoX_4Aeg_980522575")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions."
    )]
    CCPGuaranteedForecasting,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through CCP functions.
    /// Encoded/decoded by serializers as &quot;XCHN&quot;.
    /// </summary>
    [EnumMember(Value = "XCHN")]
    [IsoId("_bcR0ENp-Ed-ak6NoX_4Aeg_980522728")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through CCP functions."
    )]
    NonCCPGuaranteedForecasting,

    /// <summary>
    /// Balance representing the cash equivalent of all settled securities transactions.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_bcR0Edp-Ed-ak6NoX_4Aeg_980523129")]
    [Description(
        @"Balance representing the cash equivalent of all settled securities transactions."
    )]
    DefinitiveSettledSecurities,

    /// <summary>
    /// Balance representing the cash equivalent of transactions with a lack of holdings.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_bcR0Etp-Ed-ak6NoX_4Aeg_980523584")]
    [Description(
        @"Balance representing the cash equivalent of transactions with a lack of holdings."
    )]
    LackOfHoldingsTransactions,

    /// <summary>
    /// Balance representing the cash equivalent of all non-settled securities transactions.
    /// Encoded/decoded by serializers as &quot;NSET&quot;.
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_bcR0E9p-Ed-ak6NoX_4Aeg_980523768")]
    [Description(
        @"Balance representing the cash equivalent of all non-settled securities transactions."
    )]
    NonSettledSecurities,

    /// <summary>
    /// Balance representing the Forecast of the total of all cash-legs of transactions &apos;over the counter&apos; (OTC), going through CCP functions.
    /// Encoded/decoded by serializers as &quot;OTCC&quot;.
    /// </summary>
    [EnumMember(Value = "OTCC")]
    [IsoId("_bcR0FNp-Ed-ak6NoX_4Aeg_981444140")]
    [Description(
        @"Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through CCP functions."
    )]
    CCPGuaranteedOTCTransactions,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC).
    /// Encoded/decoded by serializers as &quot;OTCG&quot;.
    /// </summary>
    [EnumMember(Value = "OTCG")]
    [IsoId("_bcR0Fdp-Ed-ak6NoX_4Aeg_981444286")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC)."
    )]
    ForecastOTCTransactions,

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC) not going through CCP functions.
    /// Encoded/decoded by serializers as &quot;OTCN&quot;.
    /// </summary>
    [EnumMember(Value = "OTCN")]
    [IsoId("_bcR0Ftp-Ed-ak6NoX_4Aeg_981444687")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through CCP functions."
    )]
    NonCCPGuaranteedOTCTransactions,

    /// <summary>
    /// Balance represents the settlement account processor direct debit amount.
    /// Encoded/decoded by serializers as &quot;SAPD&quot;.
    /// </summary>
    [EnumMember(Value = "SAPD")]
    [IsoId("_bcR0F9p-Ed-ak6NoX_4Aeg_981445118")]
    [Description(@"Balance represents the settlement account processor direct debit amount.")]
    SAPDirectDebitAmount,

    /// <summary>
    /// Balance represents the settlement account processor direct credit amount.
    /// Encoded/decoded by serializers as &quot;SAPC&quot;.
    /// </summary>
    [EnumMember(Value = "SAPC")]
    [IsoId("_bcR0GNp-Ed-ak6NoX_4Aeg_981445363")]
    [Description(@"Balance represents the settlement account processor direct credit amount.")]
    SAPDirectCreditAmount,

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo debits.
    /// Encoded/decoded by serializers as &quot;REPD&quot;.
    /// </summary>
    [EnumMember(Value = "REPD")]
    [IsoId("_bcR0Gdp-Ed-ak6NoX_4Aeg_981445756")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo debits."
    )]
    CMUPRepoDebit,

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo credits.
    /// Encoded/decoded by serializers as &quot;REPC&quot;.
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_bcR0Gtp-Ed-ak6NoX_4Aeg_981446188")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo credits."
    )]
    CMUPRepoCredit,

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.
    /// Encoded/decoded by serializers as &quot;BSCD&quot;.
    /// </summary>
    [EnumMember(Value = "BSCD")]
    [IsoId("_bcblENp-Ed-ak6NoX_4Aeg_981446589")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor debit."
    )]
    BulkSettlementCMUPDebit,

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.
    /// Encoded/decoded by serializers as &quot;BSCC&quot;.
    /// </summary>
    [EnumMember(Value = "BSCC")]
    [IsoId("_bcblEdp-Ed-ak6NoX_4Aeg_981447044")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor credit."
    )]
    BulkSettlementCMUPCredit,

    /// <summary>
    /// Balance represents the settlement account processor queue amount.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_bcblEtp-Ed-ak6NoX_4Aeg_981447289")]
    [Description(@"Balance represents the settlement account processor queue amount.")]
    SAPQueueAmount,

    /// <summary>
    /// Balance represents the intraday repo limit.
    /// Encoded/decoded by serializers as &quot;IRLT&quot;.
    /// </summary>
    [EnumMember(Value = "IRLT")]
    [IsoId("_bcblE9p-Ed-ak6NoX_4Aeg_982367661")]
    [Description(@"Balance represents the intraday repo limit.")]
    IntradayRepoLimit,

    /// <summary>
    /// Balance represents the intraday repo drawings.
    /// Encoded/decoded by serializers as &quot;IRDR&quot;.
    /// </summary>
    [EnumMember(Value = "IRDR")]
    [IsoId("_bcblFNp-Ed-ak6NoX_4Aeg_982367838")]
    [Description(@"Balance represents the intraday repo drawings.")]
    IntradayRepoDrawings,

    /// <summary>
    /// Balance represents the discount window repo drawings.
    /// Encoded/decoded by serializers as &quot;DWRD&quot;.
    /// </summary>
    [EnumMember(Value = "DWRD")]
    [IsoId("_bcblFdp-Ed-ak6NoX_4Aeg_982368269")]
    [Description(@"Balance represents the discount window repo drawings.")]
    DiscountWindowRepoDrawings,

    /// <summary>
    /// Balance represents the available discounted market value for discount window repo.
    /// Encoded/decoded by serializers as &quot;ADWR&quot;.
    /// </summary>
    [EnumMember(Value = "ADWR")]
    [IsoId("_bcblFtp-Ed-ak6NoX_4Aeg_982368701")]
    [Description(
        @"Balance represents the available discounted market value for discount window repo."
    )]
    AvailableDMVForDiscountWindowRepo,

    /// <summary>
    /// Balance represents the available discounted market value for intraday repo.
    /// Encoded/decoded by serializers as &quot;AIDR&quot;.
    /// </summary>
    [EnumMember(Value = "AIDR")]
    [IsoId("_bcblF9p-Ed-ak6NoX_4Aeg_982369163")]
    [Description(@"Balance represents the available discounted market value for intraday repo.")]
    AvailableDMVForIntradayRepo,

    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_bcblGNp-Ed-ak6NoX_4Aeg_-919763464")]
    [Description(@"Balance of instructed position.")]
    Elected,

    /// <summary>
    /// Balance of financial instruments that are reserved for the distribution of the proceeds.
    /// Encoded/decoded by serializers as &quot;RDIS&quot;.
    /// </summary>
    [EnumMember(Value = "RDIS")]
    [IsoId("_bcblGdp-Ed-ak6NoX_4Aeg_-1183890654")]
    [Description(
        @"Balance of financial instruments that are reserved for the distribution of the proceeds."
    )]
    ReservedForDistribution,

    /// <summary>
    /// Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged.
    /// Encoded/decoded by serializers as &quot;RREM&quot;.
    /// </summary>
    [EnumMember(Value = "RREM")]
    [IsoId("_bckvANp-Ed-ak6NoX_4Aeg_-1183890653")]
    [Description(
        @"Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged."
    )]
    ReservedForRemoval,

    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the &quot;escrow balance&quot; or &quot;sequestered balance&quot;.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_bckvAdp-Ed-ak6NoX_4Aeg_-1292866132")]
    [Description(
        @"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance""."
    )]
    Restricted,

    /// <summary>
    /// Total quantity of financial instruments entitled to the account owner based on the terms of the corporate action event.
    /// Encoded/decoded by serializers as &quot;TENT&quot;.
    /// </summary>
    [EnumMember(Value = "TENT")]
    [IsoId("_bckvAtp-Ed-ak6NoX_4Aeg_-1183890685")]
    [Description(
        @"Total quantity of financial instruments entitled to the account owner based on the terms of the corporate action event."
    )]
    TotalEntitled,

    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as &quot;UNEL&quot;.
    /// </summary>
    [EnumMember(Value = "UNEL")]
    [IsoId("_bckvA9p-Ed-ak6NoX_4Aeg_-919763441")]
    [Description(@"Balance of uninstructed position.")]
    Unelected,

    /// <summary>
    /// Balance for informational purposes.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_bckvBNp-Ed-ak6NoX_4Aeg_-637207757")]
    [Description(@"Balance for informational purposes.")]
    Information,

    /// <summary>
    /// Amount of money due.
    /// Encoded/decoded by serializers as &quot;AMTD&quot;.
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_lpHM-Hx7EemHsOqJOzMVfg")]
    [Description(@"Amount of money due.")]
    AmountDue,

    /// <summary>
    /// Amount put on hold.
    /// Encoded/decoded by serializers as &quot;AMOH&quot;.
    /// </summary>
    [EnumMember(Value = "AMOH")]
    [IsoId("_lpHM-Xx7EemHsOqJOzMVfg")]
    [Description(@"Amount put on hold.")]
    AmountOnHold,

    /// <summary>
    /// Amount of money owed
    /// Encoded/decoded by serializers as &quot;AMTO&quot;.
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_lpHM-nx7EemHsOqJOzMVfg")]
    [Description(@"Amount of money owed")]
    AmountOwing,

    /// <summary>
    /// Cleared items balance.
    /// Encoded/decoded by serializers as &quot;CLRI&quot;.
    /// </summary>
    [EnumMember(Value = "CLRI")]
    [IsoId("_lpHM-3x7EemHsOqJOzMVfg")]
    [Description(@"Cleared items balance. ")]
    ClearedItem,

    /// <summary>
    /// Credit line available.
    /// Encoded/decoded by serializers as &quot;CRDL&quot;.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_lpHM_Hx7EemHsOqJOzMVfg")]
    [Description(@"Credit line available.")]
    CreditLine,

    /// <summary>
    /// Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).
    /// Encoded/decoded by serializers as &quot;LDGR&quot;.
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_lpHM_Xx7EemHsOqJOzMVfg")]
    [Description(
        @"Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions)."
    )]
    Ledger,

    /// <summary>
    /// Other type of balance defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_lpHM_nx7EemHsOqJOzMVfg")]
    [Description(@"Other type of balance defined at national level")]
    OtherNational,

    /// <summary>
    /// Other type of balance defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_lpHM_3x7EemHsOqJOzMVfg")]
    [Description(@"Other type of balance defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Value expressed in points.
    /// Encoded/decoded by serializers as &quot;PNTS&quot;.
    /// </summary>
    [EnumMember(Value = "PNTS")]
    [IsoId("_hQxqwMSqEeuBjv5G5kw00g")]
    [Description(@"Value expressed in points.")]
    Points,
}
