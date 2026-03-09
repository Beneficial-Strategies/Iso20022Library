// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bY2sodp-Ed-ak6NoX_4Aeg_1729062852")]
[Description(@"Specifies the nature of the balance, eg, opening balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType6Code
{
    /// <summary>
    /// Book balance of the account at the beginning of the account servicer&apos;s business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer&apos;s business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as &quot;OPNG&quot;.
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_bY2sotp-Ed-ak6NoX_4Aeg_1729062888")]
    [Description(@"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day.")]
    Opening = BalanceTypeCode.Opening, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_bY2so9p-Ed-ak6NoX_4Aeg_1729062930")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    Interim = BalanceTypeCode.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at the end of the account servicer&apos;s business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer&apos;s business day.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_bY2spNp-Ed-ak6NoX_4Aeg_1729062947")]
    [Description(@"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day.")]
    Closing = BalanceTypeCode.Closing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_bY2spdp-Ed-ak6NoX_4Aeg_1729062990")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book = BalanceTypeCode.Book, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as &quot;CRRT&quot;.
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_bY2sptp-Ed-ak6NoX_4Aeg_1729063025")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current = BalanceTypeCode.Current, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_bY2sp9p-Ed-ak6NoX_4Aeg_1729063042")]
    [Description(@"Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.")]
    Pending = BalanceTypeCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_bY2sqNp-Ed-ak6NoX_4Aeg_1729063085")]
    [Description(@"Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.")]
    LimitRelated = BalanceTypeCode.LimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_bY2sqdp-Ed-ak6NoX_4Aeg_1729063337")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as &quot;LTSF&quot;.
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_bY_2kNp-Ed-ak6NoX_4Aeg_1729063362")]
    [Description(@"Balance composed of the sum of all liquidity transfers made to or from an account.")]
    LiquidityTransfer = BalanceTypeCode.LiquidityTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_bY_2kdp-Ed-ak6NoX_4Aeg_1729063397")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit = BalanceTypeCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_bY_2ktp-Ed-ak6NoX_4Aeg_1729063414")]
    [Description(@"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.")]
    EligibleAssets = BalanceTypeCode.EligibleAssets, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as &quot;PYMT&quot;.
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_bY_2k9p-Ed-ak6NoX_4Aeg_1729063457")]
    [Description(@"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.")]
    Payment = BalanceTypeCode.Payment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_bY_2lNp-Ed-ak6NoX_4Aeg_1729063474")]
    [Description(@"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance.")]
    Blocked = BalanceTypeCode.Blocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_bY_2ldp-Ed-ak6NoX_4Aeg_1729063765")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    Expected = BalanceTypeCode.Expected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_bY_2ltp-Ed-ak6NoX_4Aeg_1729063800")]
    [Description(@"Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.")]
    DaylightOverdraft = BalanceTypeCode.DaylightOverdraft, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as &quot;XCRD&quot;.
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_bY_2l9p-Ed-ak6NoX_4Aeg_1729063835")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.")]
    ExpectedCredit = BalanceTypeCode.ExpectedCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as &quot;XDBT&quot;.
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_bY_2mNp-Ed-ak6NoX_4Aeg_1729063860")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.")]
    ExpectedDebit = BalanceTypeCode.ExpectedDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank&apos;s balance is equal to the reserve due during the remaining days of the maintenance period.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_bY_2mdp-Ed-ak6NoX_4Aeg_1729063895")]
    [Description(@"Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank's balance is equal to the reserve due during the remaining days of the maintenance period.")]
    Adjustment = BalanceTypeCode.Adjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_bZJnkNp-Ed-ak6NoX_4Aeg_1729063920")]
    [Description(@"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.")]
    ProgressiveAverage = BalanceTypeCode.ProgressiveAverage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_bZJnkdp-Ed-ak6NoX_4Aeg_1729063955")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit = BalanceTypeCode.Debit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_bZJnktp-Ed-ak6NoX_4Aeg_1729063972")]
    [Description(@"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.")]
    Threshold = BalanceTypeCode.Threshold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_bZJnk9p-Ed-ak6NoX_4Aeg_1729064015")]
    [Description(@"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.")]
    Noted = BalanceTypeCode.Noted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_bZJnlNp-Ed-ak6NoX_4Aeg_1729064050")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self = BalanceTypeCode.Self, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as &quot;MSTR&quot;.
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_bZJnldp-Ed-ak6NoX_4Aeg_1729064292")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master = BalanceTypeCode.Master, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as &quot;FSET&quot;.
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_bZJnltp-Ed-ak6NoX_4Aeg_-1838169896")]
    [Description(@"Balance representing the forecast of total of all cash legs for trades that are ready to settle via CSD. Amounts shown are still subject to processing of the securities settlement.")]
    ForecastSettlement = BalanceTypeCode.ForecastSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD&apos;s operates several settlements cycles per day.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_bZJnl9p-Ed-ak6NoX_4Aeg_-1838169843")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (eg, to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (I)CSD's operates several settlements cycles per day.")]
    BlockedTrades = BalanceTypeCode.BlockedTrades, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as &quot;OTHB&quot;.
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_bZJnmNp-Ed-ak6NoX_4Aeg_-1838169783")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via CSD that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.")]
    OtherBlockedTrades = BalanceTypeCode.OtherBlockedTrades, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bZJnmdp-Ed-ak6NoX_4Aeg_-1838169741")]
    [Description(@"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.")]
    Custody = BalanceTypeCode.Custody, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_bZSxgNp-Ed-ak6NoX_4Aeg_-1838169687")]
    [Description(@"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.")]
    CashForecast = BalanceTypeCode.CashForecast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as &quot;COLC&quot;.
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_bZSxgdp-Ed-ak6NoX_4Aeg_-1838169410")]
    [Description(@"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.")]
    DividendsCollection = BalanceTypeCode.DividendsCollection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_bZSxgtp-Ed-ak6NoX_4Aeg_-1838169350")]
    [Description(@"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.")]
    NetFunding = BalanceTypeCode.NetFunding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as &quot;PIPO&quot;.
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_bZSxg9p-Ed-ak6NoX_4Aeg_-1838169290")]
    [Description(@"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between the CSD and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.")]
    PayInPayOut = BalanceTypeCode.PayInPayOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as &quot;XCHG&quot;.
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_bZSxhNp-Ed-ak6NoX_4Aeg_-1838168982")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.")]
    ExchangeForecast = BalanceTypeCode.ExchangeForecast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_bZSxhdp-Ed-ak6NoX_4Aeg_-1838168930")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.")]
    CentralCounterparty = BalanceTypeCode.CentralCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as &quot;TOHB&quot;.
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_bZSxhtp-Ed-ak6NoX_4Aeg_-1838168887")]
    [Description(@"Balance representing the total of the payments that were put on hold because the limits have been exceeded.")]
    TotalOnHold = BalanceTypeCode.TotalOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;COHB&quot;.
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_bZSxh9p-Ed-ak6NoX_4Aeg_-1838168827")]
    [Description(@"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.")]
    CreditOnHold = BalanceTypeCode.CreditOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;DOHB&quot;.
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_bZSxiNp-Ed-ak6NoX_4Aeg_-1838168775")]
    [Description(@"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.")]
    DebitOnHold = BalanceTypeCode.DebitOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as &quot;TPBL&quot;.
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_bZSxidp-Ed-ak6NoX_4Aeg_-1838168715")]
    [Description(@"Balance representing the total of the payments that have been processed and are waiting for settlement during the day.")]
    TotalProcessed = BalanceTypeCode.TotalProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;CPBL&quot;.
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_bZcigNp-Ed-ak6NoX_4Aeg_-1838168438")]
    [Description(@"Balance representing the total incoming payments that have been processed and are waiting for settlement.")]
    CreditProcessed = BalanceTypeCode.CreditProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;DPBL&quot;.
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_bZcigdp-Ed-ak6NoX_4Aeg_-1838168385")]
    [Description(@"Balance representing the total outgoing payments that have been processed and are waiting for settlement.")]
    DebitProcessed = BalanceTypeCode.DebitProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as &quot;FUTB&quot;.
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_bZcigtp-Ed-ak6NoX_4Aeg_-1838168325")]
    [Description(@"Balance representing the total of the payments with a processing date in the future.")]
    TotalFuture = BalanceTypeCode.TotalFuture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as &quot;REJB&quot;.
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_bZcig9p-Ed-ak6NoX_4Aeg_-1837248294")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected = BalanceTypeCode.TotalRejected, // same ordinal as derivation source for type conversions
    
}
