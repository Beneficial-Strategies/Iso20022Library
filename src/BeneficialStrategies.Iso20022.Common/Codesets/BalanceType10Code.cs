// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bkLL2Np-Ed-ak6NoX_4Aeg_1537940408")]
[Description(@"Specifies the nature of the balance, eg, opening balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType10Code
{
    /// <summary>
    /// Book balance of the account at the beginning of the account servicer&apos;s business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer&apos;s business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as &quot;OPNG&quot;.
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_bkU80Np-Ed-ak6NoX_4Aeg_1537940410")]
    [Description(
        @"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day."
    )]
    Opening = BalanceTypeCode.Opening, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_bkU80dp-Ed-ak6NoX_4Aeg_1537940439")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    Interim = BalanceTypeCode.Interim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the account at the end of the account servicer&apos;s business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer&apos;s business day.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_bkU80tp-Ed-ak6NoX_4Aeg_1537940687")]
    [Description(
        @"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day."
    )]
    Closing = BalanceTypeCode.Closing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_bkU809p-Ed-ak6NoX_4Aeg_1537940688")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book = BalanceTypeCode.Book, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as &quot;CRRT&quot;.
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_bkU81Np-Ed-ak6NoX_4Aeg_1537940717")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current = BalanceTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_bkU81dp-Ed-ak6NoX_4Aeg_1537940718")]
    [Description(
        @"Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed."
    )]
    Pending = BalanceTypeCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_bkU81tp-Ed-ak6NoX_4Aeg_1537940748")]
    [Description(
        @"Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit."
    )]
    LimitRelated = BalanceTypeCode.LimitRelated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_bkU819p-Ed-ak6NoX_4Aeg_1537940778")]
    [Description(
        @"Balance of money or securities that is at the disposal of the account owner on the date specified."
    )]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as &quot;LTSF&quot;.
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_bkeGwNp-Ed-ak6NoX_4Aeg_1537940779")]
    [Description(
        @"Balance composed of the sum of all liquidity transfers made to or from an account."
    )]
    LiquidityTransfer = BalanceTypeCode.LiquidityTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_bkeGwdp-Ed-ak6NoX_4Aeg_1537940809")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit = BalanceTypeCode.Credit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_bkeGwtp-Ed-ak6NoX_4Aeg_1537940810")]
    [Description(
        @"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank."
    )]
    EligibleAssets = BalanceTypeCode.EligibleAssets, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as &quot;PYMT&quot;.
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_bkeGw9p-Ed-ak6NoX_4Aeg_1537940840")]
    [Description(
        @"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included."
    )]
    Payment = BalanceTypeCode.Payment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_bkeGxNp-Ed-ak6NoX_4Aeg_1537940841")]
    [Description(
        @"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance."
    )]
    Blocked = BalanceTypeCode.Blocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_bkeGxdp-Ed-ak6NoX_4Aeg_1537940862")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted."
    )]
    Expected = BalanceTypeCode.Expected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_bkeGxtp-Ed-ak6NoX_4Aeg_1537941141")]
    [Description(
        @"Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day."
    )]
    DaylightOverdraft = BalanceTypeCode.DaylightOverdraft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as &quot;XCRD&quot;.
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_bkeGx9p-Ed-ak6NoX_4Aeg_1537941150")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted."
    )]
    ExpectedCredit = BalanceTypeCode.ExpectedCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as &quot;XDBT&quot;.
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_bkeGyNp-Ed-ak6NoX_4Aeg_1537941151")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted."
    )]
    ExpectedDebit = BalanceTypeCode.ExpectedDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank&apos;s balance is equal to the reserve due during the remaining days of the maintenance period.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_bkeGydp-Ed-ak6NoX_4Aeg_1537941172")]
    [Description(
        @"Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank's balance is equal to the reserve due during the remaining days of the maintenance period."
    )]
    Adjustment = BalanceTypeCode.Adjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_bkn3wNp-Ed-ak6NoX_4Aeg_1537941181")]
    [Description(
        @"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period."
    )]
    ProgressiveAverage = BalanceTypeCode.ProgressiveAverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_bkn3wdp-Ed-ak6NoX_4Aeg_1537941182")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit = BalanceTypeCode.Debit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_bkn3wtp-Ed-ak6NoX_4Aeg_1537941202")]
    [Description(
        @"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit."
    )]
    Threshold = BalanceTypeCode.Threshold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_bkn3w9p-Ed-ak6NoX_4Aeg_1537941203")]
    [Description(
        @"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available."
    )]
    Noted = BalanceTypeCode.Noted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_bkn3xNp-Ed-ak6NoX_4Aeg_1537941212")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self = BalanceTypeCode.Self, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as &quot;MSTR&quot;.
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_bkn3xdp-Ed-ak6NoX_4Aeg_1537941233")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master = BalanceTypeCode.Master, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as &quot;FSET&quot;.
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_bkn3xtp-Ed-ak6NoX_4Aeg_1537941234")]
    [Description(
        @"Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement."
    )]
    ForecastSettlement = BalanceTypeCode.ForecastSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD&apos;s operates several settlements cycles per day.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_bkn3x9p-Ed-ak6NoX_4Aeg_1537941263")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD's operates several settlements cycles per day."
    )]
    BlockedTrades = BalanceTypeCode.BlockedTrades, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as &quot;OTHB&quot;.
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_bkn3yNp-Ed-ak6NoX_4Aeg_1537941264")]
    [Description(
        @"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement."
    )]
    OtherBlockedTrades = BalanceTypeCode.OtherBlockedTrades, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bkn3ydp-Ed-ak6NoX_4Aeg_1537941265")]
    [Description(
        @"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc."
    )]
    Custody = BalanceTypeCode.Custody, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_bkn3ytp-Ed-ak6NoX_4Aeg_1537941294")]
    [Description(
        @"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions."
    )]
    CashForecast = BalanceTypeCode.CashForecast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as &quot;COLC&quot;.
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_bkxowNp-Ed-ak6NoX_4Aeg_1537941295")]
    [Description(
        @"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent."
    )]
    DividendsCollection = BalanceTypeCode.DividendsCollection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_bkxowdp-Ed-ak6NoX_4Aeg_1537941325")]
    [Description(
        @"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement."
    )]
    NetFunding = BalanceTypeCode.NetFunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as &quot;PIPO&quot;.
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_bkxowtp-Ed-ak6NoX_4Aeg_1537941326")]
    [Description(
        @"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds."
    )]
    PayInPayOut = BalanceTypeCode.PayInPayOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as &quot;XCHG&quot;.
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_bkxow9p-Ed-ak6NoX_4Aeg_1537941327")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges."
    )]
    ExchangeForecast = BalanceTypeCode.ExchangeForecast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_bkxoxNp-Ed-ak6NoX_4Aeg_1537941355")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality."
    )]
    CentralCounterparty = BalanceTypeCode.CentralCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as &quot;TOHB&quot;.
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_bkxoxdp-Ed-ak6NoX_4Aeg_1537941356")]
    [Description(
        @"Balance representing the total of the payments that were put on hold because the limits have been exceeded."
    )]
    TotalOnHold = BalanceTypeCode.TotalOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;COHB&quot;.
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_bkxoxtp-Ed-ak6NoX_4Aeg_1537941357")]
    [Description(
        @"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded."
    )]
    CreditOnHold = BalanceTypeCode.CreditOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;DOHB&quot;.
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_bkxox9p-Ed-ak6NoX_4Aeg_1537941386")]
    [Description(
        @"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded."
    )]
    DebitOnHold = BalanceTypeCode.DebitOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as &quot;TPBL&quot;.
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_bkxoyNp-Ed-ak6NoX_4Aeg_1537941387")]
    [Description(
        @"Balance representing the total of the payments that have been processed and are waiting for settlement during the day."
    )]
    TotalProcessed = BalanceTypeCode.TotalProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;CPBL&quot;.
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_bkxoydp-Ed-ak6NoX_4Aeg_1537941417")]
    [Description(
        @"Balance representing the total incoming payments that have been processed and are waiting for settlement."
    )]
    CreditProcessed = BalanceTypeCode.CreditProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;DPBL&quot;.
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_bk6ysNp-Ed-ak6NoX_4Aeg_1537941418")]
    [Description(
        @"Balance representing the total outgoing payments that have been processed and are waiting for settlement."
    )]
    DebitProcessed = BalanceTypeCode.DebitProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as &quot;FUTB&quot;.
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_bk6ysdp-Ed-ak6NoX_4Aeg_1537941419")]
    [Description(
        @"Balance representing the total of the payments with a processing date in the future."
    )]
    TotalFuture = BalanceTypeCode.TotalFuture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as &quot;REJB&quot;.
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_bk6ystp-Ed-ak6NoX_4Aeg_1537941664")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected = BalanceTypeCode.TotalRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_bk6ys9p-Ed-ak6NoX_4Aeg_1623828777")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral."
    )]
    FirmCollateralisation = BalanceTypeCode.FirmCollateralisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as &quot;FCOU&quot;.
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_bk6ytNp-Ed-ak6NoX_4Aeg_1623828869")]
    [Description(
        @"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral."
    )]
    UsedAmountsFirmCollateralisation = BalanceTypeCode.UsedAmountsFirmCollateralisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as &quot;SCOL&quot;.
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_bk6ytdp-Ed-ak6NoX_4Aeg_1623829147")]
    [Description(
        @"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at."
    )]
    SelfCollateralisation = BalanceTypeCode.SelfCollateralisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as &quot;SCOU&quot;.
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_bk6yttp-Ed-ak6NoX_4Aeg_1623829232")]
    [Description(
        @"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process."
    )]
    UsedAmountsSelfCollateralisation = BalanceTypeCode.UsedAmountsSelfCollateralisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.
    /// Encoded/decoded by serializers as &quot;CUSA&quot;.
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_bk6yt9p-Ed-ak6NoX_4Aeg_1623829542")]
    [Description(
        @"Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc."
    )]
    CustodyActual = BalanceTypeCode.CustodyActual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.
    /// Encoded/decoded by serializers as &quot;XCHC&quot;.
    /// </summary>
    [EnumMember(Value = "XCHC")]
    [IsoId("_bk6yuNp-Ed-ak6NoX_4Aeg_1623829572")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions."
    )]
    CCPGuaranteedForecasting = BalanceTypeCode.CCPGuaranteedForecasting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through CCP functions.
    /// Encoded/decoded by serializers as &quot;XCHN&quot;.
    /// </summary>
    [EnumMember(Value = "XCHN")]
    [IsoId("_bk6yudp-Ed-ak6NoX_4Aeg_1623829633")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through CCP functions."
    )]
    NonCCPGuaranteedForecasting = BalanceTypeCode.NonCCPGuaranteedForecasting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the cash equivalent of all settled securities transactions.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_blEjsNp-Ed-ak6NoX_4Aeg_1623829695")]
    [Description(
        @"Balance representing the cash equivalent of all settled securities transactions."
    )]
    DefinitiveSettledSecurities = BalanceTypeCode.DefinitiveSettledSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the cash equivalent of transactions with a lack of holdings.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_blEjsdp-Ed-ak6NoX_4Aeg_1623829725")]
    [Description(
        @"Balance representing the cash equivalent of transactions with a lack of holdings."
    )]
    LackOfHoldingsTransactions = BalanceTypeCode.LackOfHoldingsTransactions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the cash equivalent of all non-settled securities transactions.
    /// Encoded/decoded by serializers as &quot;NSET&quot;.
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_blEjstp-Ed-ak6NoX_4Aeg_1623829787")]
    [Description(
        @"Balance representing the cash equivalent of all non-settled securities transactions."
    )]
    NonSettledSecurities = BalanceTypeCode.NonSettledSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the Forecast of the total of all cash-legs of transactions &apos;over the counter&apos; (OTC), going through CCP functions.
    /// Encoded/decoded by serializers as &quot;OTCC&quot;.
    /// </summary>
    [EnumMember(Value = "OTCC")]
    [IsoId("_blEjs9p-Ed-ak6NoX_4Aeg_1623830065")]
    [Description(
        @"Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through CCP functions."
    )]
    CCPGuaranteedOTCTransactions = BalanceTypeCode.CCPGuaranteedOTCTransactions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC).
    /// Encoded/decoded by serializers as &quot;OTCG&quot;.
    /// </summary>
    [EnumMember(Value = "OTCG")]
    [IsoId("_blEjtNp-Ed-ak6NoX_4Aeg_1623830095")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC)."
    )]
    ForecastOTCTransactions = BalanceTypeCode.ForecastOTCTransactions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC) not going through CCP functions.
    /// Encoded/decoded by serializers as &quot;OTCN&quot;.
    /// </summary>
    [EnumMember(Value = "OTCN")]
    [IsoId("_blEjtdp-Ed-ak6NoX_4Aeg_1623830157")]
    [Description(
        @"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through CCP functions."
    )]
    NonCCPGuaranteedOTCTransactions = BalanceTypeCode.NonCCPGuaranteedOTCTransactions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the settlement account processor direct debit amount.
    /// Encoded/decoded by serializers as &quot;SAPD&quot;.
    /// </summary>
    [EnumMember(Value = "SAPD")]
    [IsoId("_blEjttp-Ed-ak6NoX_4Aeg_1623830218")]
    [Description(@"Balance represents the settlement account processor direct debit amount.")]
    SAPDirectDebitAmount = BalanceTypeCode.SAPDirectDebitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the settlement account processor direct credit amount.
    /// Encoded/decoded by serializers as &quot;SAPC&quot;.
    /// </summary>
    [EnumMember(Value = "SAPC")]
    [IsoId("_blEjt9p-Ed-ak6NoX_4Aeg_1623830497")]
    [Description(@"Balance represents the settlement account processor direct credit amount.")]
    SAPDirectCreditAmount = BalanceTypeCode.SAPDirectCreditAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo debits.
    /// Encoded/decoded by serializers as &quot;REPD&quot;.
    /// </summary>
    [EnumMember(Value = "REPD")]
    [IsoId("_blEjuNp-Ed-ak6NoX_4Aeg_1623830558")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo debits."
    )]
    CMUPRepoDebit = BalanceTypeCode.CMUPRepoDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo credits.
    /// Encoded/decoded by serializers as &quot;REPC&quot;.
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_blEjudp-Ed-ak6NoX_4Aeg_1623830619")]
    [Description(
        @"Balance represents the total of the central moneymarkets unit processor repo credits."
    )]
    CMUPRepoCredit = BalanceTypeCode.CMUPRepoCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.
    /// Encoded/decoded by serializers as &quot;BSCD&quot;.
    /// </summary>
    [EnumMember(Value = "BSCD")]
    [IsoId("_blEjutp-Ed-ak6NoX_4Aeg_1623830680")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor debit."
    )]
    BulkSettlementCMUPDebit = BalanceTypeCode.BulkSettlementCMUPDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.
    /// Encoded/decoded by serializers as &quot;BSCC&quot;.
    /// </summary>
    [EnumMember(Value = "BSCC")]
    [IsoId("_blNtoNp-Ed-ak6NoX_4Aeg_1623830711")]
    [Description(
        @"Balance represents the total of the bulk settlement and central moneymarkets unit processor credit."
    )]
    BulkSettlementCMUPCredit = BalanceTypeCode.BulkSettlementCMUPCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the settlement account processor queue amount.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_blNtodp-Ed-ak6NoX_4Aeg_1623830764")]
    [Description(@"Balance represents the settlement account processor queue amount.")]
    SAPQueueAmount = BalanceTypeCode.SAPQueueAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the intraday repo limit.
    /// Encoded/decoded by serializers as &quot;IRLT&quot;.
    /// </summary>
    [EnumMember(Value = "IRLT")]
    [IsoId("_blNtotp-Ed-ak6NoX_4Aeg_1623831042")]
    [Description(@"Balance represents the intraday repo limit.")]
    IntradayRepoLimit = BalanceTypeCode.IntradayRepoLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the intraday repo drawings.
    /// Encoded/decoded by serializers as &quot;IRDR&quot;.
    /// </summary>
    [EnumMember(Value = "IRDR")]
    [IsoId("_blNto9p-Ed-ak6NoX_4Aeg_1623831104")]
    [Description(@"Balance represents the intraday repo drawings.")]
    IntradayRepoDrawings = BalanceTypeCode.IntradayRepoDrawings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the discount window repo drawings.
    /// Encoded/decoded by serializers as &quot;DWRD&quot;.
    /// </summary>
    [EnumMember(Value = "DWRD")]
    [IsoId("_blNtpNp-Ed-ak6NoX_4Aeg_1624751137")]
    [Description(@"Balance represents the discount window repo drawings.")]
    DiscountWindowRepoDrawings = BalanceTypeCode.DiscountWindowRepoDrawings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the available discounted market value for discount window repo.
    /// Encoded/decoded by serializers as &quot;ADWR&quot;.
    /// </summary>
    [EnumMember(Value = "ADWR")]
    [IsoId("_blNtpdp-Ed-ak6NoX_4Aeg_1624751198")]
    [Description(
        @"Balance represents the available discounted market value for discount window repo."
    )]
    AvailableDMVForDiscountWindowRepo = BalanceTypeCode.AvailableDMVForDiscountWindowRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance represents the available discounted market value for intraday repo.
    /// Encoded/decoded by serializers as &quot;AIDR&quot;.
    /// </summary>
    [EnumMember(Value = "AIDR")]
    [IsoId("_blNtptp-Ed-ak6NoX_4Aeg_1624751259")]
    [Description(@"Balance represents the available discounted market value for intraday repo.")]
    AvailableDMVForIntradayRepo = BalanceTypeCode.AvailableDMVForIntradayRepo, // same ordinal as derivation source for type conversions
}
