// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the system balance, such as opening balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8MlMhKMgEeCJ6YNENx4h-w_949117902")]
[Description(@"Specifies the nature of the system balance, such as opening balance.")]
[DerivedFrom(typeof(SystemBalanceTypeCode))]
public enum SystemBalanceType1Code
{
    /// <summary>
    /// Book balance of the account at the beginning of the account servicer&apos;s business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer&apos;s business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as &quot;OPNG&quot;.
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_8MlMhaMgEeCJ6YNENx4h-w_-1700581959")]
    [Description(@"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. |Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day.")]
    Opening = SystemBalanceTypeCode.Opening, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_8MlMhqMgEeCJ6YNENx4h-w_-47954451")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    Interim = SystemBalanceTypeCode.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at the end of the account servicer&apos;s business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer&apos;s business day.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_8MlMh6MgEeCJ6YNENx4h-w_130164221")]
    [Description(@"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day.")]
    Closing = SystemBalanceTypeCode.Closing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_8Mu9gKMgEeCJ6YNENx4h-w_-161793517")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book = SystemBalanceTypeCode.Book, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as &quot;CRRT&quot;.
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_8Mu9gaMgEeCJ6YNENx4h-w_1597312984")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current = SystemBalanceTypeCode.Current, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_8Mu9gqMgEeCJ6YNENx4h-w_-1045026804")]
    [Description(@"Balance of securities pending delivery, such as the orders to sell securities have been executed but settlement of the open transactions has not been confirmed.")]
    Pending = SystemBalanceTypeCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_8Mu9g6MgEeCJ6YNENx4h-w_-866908132")]
    [Description(@"Balance of a specific limit value, such as a bilateral balance is calculated in relation to a given bilateral limit.")]
    LimitRelated = SystemBalanceTypeCode.LimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_8Mu9hKMgEeCJ6YNENx4h-w_-1158865870")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available = SystemBalanceTypeCode.Available, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as &quot;LTSF&quot;.
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_8Mu9haMgEeCJ6YNENx4h-w_600240631")]
    [Description(@"Balance composed of the sum of all liquidity transfers made to or from an account.")]
    LiquidityTransfer = SystemBalanceTypeCode.LiquidityTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_8Mu9hqMgEeCJ6YNENx4h-w_-2042099157")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit = SystemBalanceTypeCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_8Mu9h6MgEeCJ6YNENx4h-w_-1863980485")]
    [Description(@"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, such as securities available and eligible as collateral with the central bank.")]
    EligibleAssets = SystemBalanceTypeCode.EligibleAssets, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as &quot;PYMT&quot;.
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_8M4ugKMgEeCJ6YNENx4h-w_2139029073")]
    [Description(@"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.")]
    Payment = SystemBalanceTypeCode.Payment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_8M4ugaMgEeCJ6YNENx4h-w_-396831722")]
    [Description(@"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, such as the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance.")]
    Blocked = SystemBalanceTypeCode.Blocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_8M4ugqMgEeCJ6YNENx4h-w_1255795786")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    Expected = SystemBalanceTypeCode.Expected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_8M4ug6MgEeCJ6YNENx4h-w_1433914458")]
    [Description(@"Balance representing the intra day overdraft granted by the central bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.")]
    DaylightOverdraft = SystemBalanceTypeCode.DaylightOverdraft, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as &quot;XCRD&quot;.
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_8M4uhKMgEeCJ6YNENx4h-w_1141956720")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.")]
    ExpectedCredit = SystemBalanceTypeCode.ExpectedCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as &quot;XDBT&quot;.
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_8M4uhaMgEeCJ6YNENx4h-w_-1393904075")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.")]
    ExpectedDebit = SystemBalanceTypeCode.ExpectedDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_8M4uhqMgEeCJ6YNENx4h-w_258723433")]
    [Description(@"Average balance to be held in the settlement account at the end of each day in order to fulfil the reserve due.|The approximation will be always made rounding up.")]
    Adjustment = SystemBalanceTypeCode.Adjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_8NB4cKMgEeCJ6YNENx4h-w_436842105")]
    [Description(@"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.")]
    ProgressiveAverage = SystemBalanceTypeCode.ProgressiveAverage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_8NB4caMgEeCJ6YNENx4h-w_144884367")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit = SystemBalanceTypeCode.Debit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_8NB4cqMgEeCJ6YNENx4h-w_1903990868")]
    [Description(@"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.")]
    Threshold = SystemBalanceTypeCode.Threshold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_8NB4c6MgEeCJ6YNENx4h-w_-738348920")]
    [Description(@"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.")]
    Noted = SystemBalanceTypeCode.Noted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_8NB4dKMgEeCJ6YNENx4h-w_-560230248")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self = SystemBalanceTypeCode.Self, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as &quot;MSTR&quot;.
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_8NB4daMgEeCJ6YNENx4h-w_-852187986")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master = SystemBalanceTypeCode.Master, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement.
    /// Encoded/decoded by serializers as &quot;FSET&quot;.
    /// </summary>
    [EnumMember(Value = "FSET")]
    [IsoId("_8NB4dqMgEeCJ6YNENx4h-w_906918515")]
    [Description(@"Balance representing the forecast of total of all cash legs for trades that are ready to settle via a central securities depository. Amounts shown are still subject to processing of the securities settlement.")]
    ForecastSettlement = SystemBalanceTypeCode.ForecastSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository&apos;s operates several settlements cycles per day.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_8NB4d6MgEeCJ6YNENx4h-w_-1735421273")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked trades are included in the calculation for settlement (for example to avoid overdrafts).|Usage rule: Blocking can be done by account owner or its counterparties. Usually this is done to chain transactions or to prioritise other trades. Blocked trades have an indicator that prevents the transactions from settling. Once matched, they can settle whenever the freeze is lifted. In this case they will move to FSET. Lifting the freeze can happen anytime during the day and the transaction will be settling in the next settlement cycle which can be the same day if the (international) central securities depository's operates several settlements cycles per day.")]
    BlockedTrades = SystemBalanceTypeCode.BlockedTrades, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.
    /// Encoded/decoded by serializers as &quot;OTHB&quot;.
    /// </summary>
    [EnumMember(Value = "OTHB")]
    [IsoId("_8NB4eKMgEeCJ6YNENx4h-w_-1557302601")]
    [Description(@"Balance representing the projected total of all cash legs for trades settling via a central securities depository that have been matched but blocked in order to not settle. These blocked transactions are not included in the calculation for settlement.")]
    OtherBlockedTrades = SystemBalanceTypeCode.OtherBlockedTrades, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_8NLpcKMgEeCJ6YNENx4h-w_-1849260339")]
    [Description(@"Balance representing the projected total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, etc.")]
    Custody = SystemBalanceTypeCode.Custody, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_8NLpcaMgEeCJ6YNENx4h-w_-90153838")]
    [Description(@"Balance representing the total of all balance types representing transactions to settle, blocked items and custody transactions.")]
    CashForecast = SystemBalanceTypeCode.CashForecast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.
    /// Encoded/decoded by serializers as &quot;COLC&quot;.
    /// </summary>
    [EnumMember(Value = "COLC")]
    [IsoId("_8NLpcqMgEeCJ6YNENx4h-w_1562473670")]
    [Description(@"Balance representing the projected total amount of all payment obligations to the participant (bank), based on their role as main paying agent.")]
    DividendsCollection = SystemBalanceTypeCode.DividendsCollection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_8NLpc6MgEeCJ6YNENx4h-w_1740592342")]
    [Description(@"Balance representing the net amount to be funded resulting from all transactions which have an impact on the funding requirement.")]
    NetFunding = SystemBalanceTypeCode.NetFunding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.
    /// Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.
    /// Encoded/decoded by serializers as &quot;PIPO&quot;.
    /// </summary>
    [EnumMember(Value = "PIPO")]
    [IsoId("_8NLpdKMgEeCJ6YNENx4h-w_1448634604")]
    [Description(@"Balance representing the fictive forecast of automated direct debits or payment based on standing arrangements between a central securities depository and the user.||Usage: Pay-Ins and Pay-Outs can be different based on individual payment instructions or available funds.")]
    PayInPayOut = SystemBalanceTypeCode.PayInPayOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.
    /// Encoded/decoded by serializers as &quot;XCHG&quot;.
    /// </summary>
    [EnumMember(Value = "XCHG")]
    [IsoId("_8NLpdaMgEeCJ6YNENx4h-w_-1087226191")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges.")]
    ExchangeForecast = SystemBalanceTypeCode.ExchangeForecast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_8NLpdqMgEeCJ6YNENx4h-w_565401317")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges that operate a central counterparty functionality.")]
    CentralCounterparty = SystemBalanceTypeCode.CentralCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments that were put on hold because the limits have been exceeded.
    /// Encoded/decoded by serializers as &quot;TOHB&quot;.
    /// </summary>
    [EnumMember(Value = "TOHB")]
    [IsoId("_8NLpd6MgEeCJ6YNENx4h-w_743519989")]
    [Description(@"Balance representing the total of the payments that were put on hold because the limits have been exceeded.")]
    TotalOnHold = SystemBalanceTypeCode.TotalOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;COHB&quot;.
    /// </summary>
    [EnumMember(Value = "COHB")]
    [IsoId("_8NLpeKMgEeCJ6YNENx4h-w_451562251")]
    [Description(@"Balance representing the total incoming payments that were put on hold because the credit limit has been exceeded.")]
    CreditOnHold = SystemBalanceTypeCode.CreditOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.
    /// Encoded/decoded by serializers as &quot;DOHB&quot;.
    /// </summary>
    [EnumMember(Value = "DOHB")]
    [IsoId("_8NUzYKMgEeCJ6YNENx4h-w_-2084298544")]
    [Description(@"Balance representing the total outgoing payments that were put on hold because the debit limit has been exceeded.")]
    DebitOnHold = SystemBalanceTypeCode.DebitOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments that have been processed and are waiting for settlement during the day.
    /// Encoded/decoded by serializers as &quot;TPBL&quot;.
    /// </summary>
    [EnumMember(Value = "TPBL")]
    [IsoId("_8NUzYaMgEeCJ6YNENx4h-w_-431671036")]
    [Description(@"Balance representing the total of the payments that have been processed and are waiting for settlement during the day.")]
    TotalProcessed = SystemBalanceTypeCode.TotalProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total incoming payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;CPBL&quot;.
    /// </summary>
    [EnumMember(Value = "CPBL")]
    [IsoId("_8NUzYqMgEeCJ6YNENx4h-w_-253552364")]
    [Description(@"Balance representing the total incoming payments that have been processed and are waiting for settlement.")]
    CreditProcessed = SystemBalanceTypeCode.CreditProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total outgoing payments that have been processed and are waiting for settlement.
    /// Encoded/decoded by serializers as &quot;DPBL&quot;.
    /// </summary>
    [EnumMember(Value = "DPBL")]
    [IsoId("_8NUzY6MgEeCJ6YNENx4h-w_-545510102")]
    [Description(@"Balance representing the total outgoing payments that have been processed and are waiting for settlement.")]
    DebitProcessed = SystemBalanceTypeCode.DebitProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments with a processing date in the future.
    /// Encoded/decoded by serializers as &quot;FUTB&quot;.
    /// </summary>
    [EnumMember(Value = "FUTB")]
    [IsoId("_8NUzZKMgEeCJ6YNENx4h-w_1213596399")]
    [Description(@"Balance representing the total of the payments with a processing date in the future.")]
    TotalFuture = SystemBalanceTypeCode.TotalFuture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the total of the payments that have been rejected.
    /// Encoded/decoded by serializers as &quot;REJB&quot;.
    /// </summary>
    [EnumMember(Value = "REJB")]
    [IsoId("_8NUzZaMgEeCJ6YNENx4h-w_-1428743389")]
    [Description(@"Balance representing the total of the payments that have been rejected.")]
    TotalRejected = SystemBalanceTypeCode.TotalRejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_8NUzZqMgEeCJ6YNENx4h-w_-1250624717")]
    [Description(@"Balance representing the forecast of the cash-equivalent resulting from evaluation of existing holdings at central securities depositary that are qualified to serve as collateral.")]
    FirmCollateralisation = SystemBalanceTypeCode.FirmCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.
    /// Encoded/decoded by serializers as &quot;FCOU&quot;.
    /// </summary>
    [EnumMember(Value = "FCOU")]
    [IsoId("_8NUzZ6MgEeCJ6YNENx4h-w_-1542582455")]
    [Description(@"Balance representing the cash equivalent resulting from evaluation of existing holdings at CSD that are qualified to serve as collateral and have been used as collateral.")]
    UsedAmountsFirmCollateralisation = SystemBalanceTypeCode.UsedAmountsFirmCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.
    /// Encoded/decoded by serializers as &quot;SCOL&quot;.
    /// </summary>
    [EnumMember(Value = "SCOL")]
    [IsoId("_8NUzaKMgEeCJ6YNENx4h-w_216524046")]
    [Description(@"Balance representing the forecast of the cash-equivalent resulting from evaluation of the net incoming balance of securities qualified to serve as collateral for which settlement instructions are held at.")]
    SelfCollateralisation = SystemBalanceTypeCode.SelfCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.
    /// Encoded/decoded by serializers as &quot;SCOU&quot;.
    /// </summary>
    [EnumMember(Value = "SCOU")]
    [IsoId("_8NekYKMgEeCJ6YNENx4h-w_1869151554")]
    [Description(@"Balance representing the cash-equivalent resulting from evaluation of incoming securities, qualified to serve as collateral and actually used as collateral, which have been settled during the settlement process.")]
    UsedAmountsSelfCollateralisation = SystemBalanceTypeCode.UsedAmountsSelfCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.
    /// Encoded/decoded by serializers as &quot;CUSA&quot;.
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_8NekYaMgEeCJ6YNENx4h-w_2047270226")]
    [Description(@"Balance representing the actual total of all asset servicing transactions such as dividends, income corporate actions equivalents, tax returns, redemptions, etc.")]
    CustodyActual = SystemBalanceTypeCode.CustodyActual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.
    /// Encoded/decoded by serializers as &quot;XCHC&quot;.
    /// </summary>
    [EnumMember(Value = "XCHC")]
    [IsoId("_8NekYqMgEeCJ6YNENx4h-w_1755312488")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions in exchanges, going through CCP functions.")]
    CCPGuaranteedForecasting = SystemBalanceTypeCode.CCPGuaranteedForecasting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;XCHN&quot;.
    /// </summary>
    [EnumMember(Value = "XCHN")]
    [IsoId("_8NekY6MgEeCJ6YNENx4h-w_-780548307")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded in exchanges not going through central counter party (CCP) functions.")]
    NonCCPGuaranteedForecasting = SystemBalanceTypeCode.NonCCPGuaranteedForecasting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the cash equivalent of all settled securities transactions.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_8NekZKMgEeCJ6YNENx4h-w_872079201")]
    [Description(@"Balance representing the cash equivalent of all settled securities transactions.")]
    DefinitiveSettledSecurities = SystemBalanceTypeCode.DefinitiveSettledSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the cash equivalent of transactions with a lack of holdings.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_8NekZaMgEeCJ6YNENx4h-w_1050197873")]
    [Description(@"Balance representing the cash equivalent of transactions with a lack of holdings.")]
    LackOfHoldingsTransactions = SystemBalanceTypeCode.LackOfHoldingsTransactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the cash equivalent of all non-settled securities transactions.
    /// Encoded/decoded by serializers as &quot;NSET&quot;.
    /// </summary>
    [EnumMember(Value = "NSET")]
    [IsoId("_8NekZqMgEeCJ6YNENx4h-w_758240135")]
    [Description(@"Balance representing the cash equivalent of all non-settled securities transactions.")]
    NonSettledSecurities = SystemBalanceTypeCode.NonSettledSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the Forecast of the total of all cash-legs of transactions &apos;over the counter&apos; (OTC), going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;OTCC&quot;.
    /// </summary>
    [EnumMember(Value = "OTCC")]
    [IsoId("_8NekZ6MgEeCJ6YNENx4h-w_-1777620660")]
    [Description(@"Balance representing the Forecast of the total of all cash-legs of transactions 'over the counter' (OTC), going through central counter party (CCP) functions.")]
    CCPGuaranteedOTCTransactions = SystemBalanceTypeCode.CCPGuaranteedOTCTransactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC).
    /// Encoded/decoded by serializers as &quot;OTCG&quot;.
    /// </summary>
    [EnumMember(Value = "OTCG")]
    [IsoId("_8NekaKMgEeCJ6YNENx4h-w_-124993152")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC).")]
    ForecastOTCTransactions = SystemBalanceTypeCode.ForecastOTCTransactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the forecast of the total of all cash legs of transactions traded &apos;over the counter&apos; (OTC) not going through central counter party (CCP) functions.
    /// Encoded/decoded by serializers as &quot;OTCN&quot;.
    /// </summary>
    [EnumMember(Value = "OTCN")]
    [IsoId("_8NoVYKMgEeCJ6YNENx4h-w_53125520")]
    [Description(@"Balance representing the forecast of the total of all cash legs of transactions traded 'over the counter' (OTC) not going through central counter party (CCP) functions.")]
    NonCCPGuaranteedOTCTransactions = SystemBalanceTypeCode.NonCCPGuaranteedOTCTransactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the settlement account processor direct debit amount.
    /// Encoded/decoded by serializers as &quot;SAPD&quot;.
    /// </summary>
    [EnumMember(Value = "SAPD")]
    [IsoId("_8NoVYaMgEeCJ6YNENx4h-w_-238832218")]
    [Description(@"Balance represents the settlement account processor direct debit amount.")]
    SAPDirectDebitAmount = SystemBalanceTypeCode.SAPDirectDebitAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the settlement account processor direct credit amount.
    /// Encoded/decoded by serializers as &quot;SAPC&quot;.
    /// </summary>
    [EnumMember(Value = "SAPC")]
    [IsoId("_8NoVYqMgEeCJ6YNENx4h-w_1520274283")]
    [Description(@"Balance represents the settlement account processor direct credit amount.")]
    SAPDirectCreditAmount = SystemBalanceTypeCode.SAPDirectCreditAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo debits.
    /// Encoded/decoded by serializers as &quot;REPD&quot;.
    /// </summary>
    [EnumMember(Value = "REPD")]
    [IsoId("_8NoVY6MgEeCJ6YNENx4h-w_-1122065505")]
    [Description(@"Balance represents the total of the central moneymarkets unit processor repo debits.")]
    CMUPRepoDebit = SystemBalanceTypeCode.CMUPRepoDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the total of the central moneymarkets unit processor repo credits.
    /// Encoded/decoded by serializers as &quot;REPC&quot;.
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_8NoVZKMgEeCJ6YNENx4h-w_-943946833")]
    [Description(@"Balance represents the total of the central moneymarkets unit processor repo credits.")]
    CMUPRepoCredit = SystemBalanceTypeCode.CMUPRepoCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.
    /// Encoded/decoded by serializers as &quot;BSCD&quot;.
    /// </summary>
    [EnumMember(Value = "BSCD")]
    [IsoId("_8NoVZaMgEeCJ6YNENx4h-w_-1235904571")]
    [Description(@"Balance represents the total of the bulk settlement and central moneymarkets unit processor debit.")]
    BulkSettlementCMUPDebit = SystemBalanceTypeCode.BulkSettlementCMUPDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.
    /// Encoded/decoded by serializers as &quot;BSCC&quot;.
    /// </summary>
    [EnumMember(Value = "BSCC")]
    [IsoId("_8NoVZqMgEeCJ6YNENx4h-w_523201930")]
    [Description(@"Balance represents the total of the bulk settlement and central moneymarkets unit processor credit.")]
    BulkSettlementCMUPCredit = SystemBalanceTypeCode.BulkSettlementCMUPCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the settlement account processor queue amount.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_8NoVZ6MgEeCJ6YNENx4h-w_-353155415")]
    [Description(@"Balance represents the settlement account processor queue amount.")]
    SAPQueueAmount = SystemBalanceTypeCode.SAPQueueAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the intraday repo limit.
    /// Encoded/decoded by serializers as &quot;IRLT&quot;.
    /// </summary>
    [EnumMember(Value = "IRLT")]
    [IsoId("_8NoVaKMgEeCJ6YNENx4h-w_-175036743")]
    [Description(@"Balance represents the intraday repo limit.")]
    IntradayRepoLimit = SystemBalanceTypeCode.IntradayRepoLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the intraday repo drawings.
    /// Encoded/decoded by serializers as &quot;IRDR&quot;.
    /// </summary>
    [EnumMember(Value = "IRDR")]
    [IsoId("_8NxfUKMgEeCJ6YNENx4h-w_-466994481")]
    [Description(@"Balance represents the intraday repo drawings.")]
    IntradayRepoDrawings = SystemBalanceTypeCode.IntradayRepoDrawings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the discount window repo drawings.
    /// Encoded/decoded by serializers as &quot;DWRD&quot;.
    /// </summary>
    [EnumMember(Value = "DWRD")]
    [IsoId("_8NxfUaMgEeCJ6YNENx4h-w_1292112020")]
    [Description(@"Balance represents the discount window repo drawings.")]
    DiscountWindowRepoDrawings = SystemBalanceTypeCode.DiscountWindowRepoDrawings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the available discounted market value for discount window repo.
    /// Encoded/decoded by serializers as &quot;ADWR&quot;.
    /// </summary>
    [EnumMember(Value = "ADWR")]
    [IsoId("_8NxfUqMgEeCJ6YNENx4h-w_-1350227768")]
    [Description(@"Balance represents the available discounted market value for discount window repo.")]
    AvailableDMVForDiscountWindowRepo = SystemBalanceTypeCode.AvailableDMVForDiscountWindowRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance represents the available discounted market value for intraday repo.
    /// Encoded/decoded by serializers as &quot;AIDR&quot;.
    /// </summary>
    [EnumMember(Value = "AIDR")]
    [IsoId("_8NxfU6MgEeCJ6YNENx4h-w_-1172109096")]
    [Description(@"Balance represents the available discounted market value for intraday repo.")]
    AvailableDMVForIntradayRepo = SystemBalanceTypeCode.AvailableDMVForIntradayRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the &quot;escrow balance&quot; or &quot;sequestered balance&quot;.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_8NxfVKMgEeCJ6YNENx4h-w_-297647176")]
    [Description(@"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account for example, when related to specific corporate actions, the holding is under the direct control of the system paying agent, who is the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance"".")]
    Restricted = SystemBalanceTypeCode.Restricted, // same ordinal as derivation source for type conversions
    
}
