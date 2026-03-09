// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vnvpptp-Ed-ak6NoX_4Aeg_-890461341")]
[Description(@"Specifies the nature of the balance, eg, opening balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType4Code
{
    /// <summary>
    /// Book balance of the account at the beginning of the account servicer&apos;s business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer&apos;s business day may be different from the closing book balance from the previous business day.
    /// Encoded/decoded by serializers as &quot;OPNG&quot;.
    /// </summary>
    [EnumMember(Value = "OPNG")]
    [IsoId("_Vnvpp9p-Ed-ak6NoX_4Aeg_-890461186")]
    [Description(@"Book balance of the account at the beginning of the account servicer's business day. It always equals the closing book balance from the previous business day. Note: the available balance at the beginning of the account servicer's business day may be different from the closing book balance from the previous business day.")]
    Opening = BalanceTypeCode.Opening, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_VnvpqNp-Ed-ak6NoX_4Aeg_-889539559")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    Interim = BalanceTypeCode.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at the end of the account servicer&apos;s business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer&apos;s business day.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_Vn5aoNp-Ed-ak6NoX_4Aeg_-889539307")]
    [Description(@"Balance of the account at the end of the account servicer's business day. It is the sum of the opening balance at the beginning of the day and all entries booked to the account during the account servicer's business day.")]
    Closing = BalanceTypeCode.Closing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance that is registered in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_Vn5aodp-Ed-ak6NoX_4Aeg_-889539247")]
    [Description(@"Balance that is registered in the books of the account servicer.")]
    Book = BalanceTypeCode.Book, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at a precise moment in time.
    /// Encoded/decoded by serializers as &quot;CRRT&quot;.
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_Vn5aotp-Ed-ak6NoX_4Aeg_-889539230")]
    [Description(@"Balance of the account at a precise moment in time.")]
    Current = BalanceTypeCode.Current, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_Vn5ao9p-Ed-ak6NoX_4Aeg_-889539170")]
    [Description(@"Balance of securities pending delivery, eg, orders to sell securities have been executed but settlement of the open transactions has not been confirmed.")]
    Pending = BalanceTypeCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.
    /// Encoded/decoded by serializers as &quot;LRLD&quot;.
    /// </summary>
    [EnumMember(Value = "LRLD")]
    [IsoId("_Vn5apNp-Ed-ak6NoX_4Aeg_-889538879")]
    [Description(@"Balance of a specific limit value, eg, a bilateral balance is calculated in relation to a given bilateral limit.")]
    LimitRelated = BalanceTypeCode.LimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_Vn5apdp-Ed-ak6NoX_4Aeg_-889538335")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance composed of the sum of all liquidity transfers made to or from an account.
    /// Encoded/decoded by serializers as &quot;LTSF&quot;.
    /// </summary>
    [EnumMember(Value = "LTSF")]
    [IsoId("_Vn5aptp-Ed-ak6NoX_4Aeg_-888615725")]
    [Description(@"Balance composed of the sum of all liquidity transfers made to or from an account.")]
    LiquidityTransfer = BalanceTypeCode.LiquidityTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of all credit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_Vn5ap9p-Ed-ak6NoX_4Aeg_-888615280")]
    [Description(@"Balance representing the sum of all credit entries booked to an account.")]
    Credit = BalanceTypeCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.
    /// Encoded/decoded by serializers as &quot;EAST&quot;.
    /// </summary>
    [EnumMember(Value = "EAST")]
    [IsoId("_Vn5aqNp-Ed-ak6NoX_4Aeg_-888615227")]
    [Description(@"Balance representing the potential loan a Central Bank would make in cash if the collateral is pledged, eg, securities available and eligible as collateral with the Central Bank.")]
    EligibleAssets = BalanceTypeCode.EligibleAssets, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.
    /// Encoded/decoded by serializers as &quot;PYMT&quot;.
    /// </summary>
    [EnumMember(Value = "PYMT")]
    [IsoId("_Vn5aqdp-Ed-ak6NoX_4Aeg_-888615202")]
    [Description(@"Balance representing the sum of entries as a result of payments processing. Entries relating to fees, interest, or other movements not a result of payments sent or received by the account owner are not included.")]
    Payment = BalanceTypeCode.Payment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a &apos;reserve&apos; balance.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_VoDLoNp-Ed-ak6NoX_4Aeg_-888615167")]
    [Description(@"Balance representing the regulatory reserve that a financial institution must have with the account servicing institution, eg, the minimum credit balance a financial institution is to keep with its Central Bank for mandatory reserve purposes. In some countries, a blocked balance is known as a 'reserve' balance.")]
    Blocked = BalanceTypeCode.Blocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_VoDLodp-Ed-ak6NoX_4Aeg_-888615142")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    Expected = BalanceTypeCode.Expected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.
    /// Encoded/decoded by serializers as &quot;DLOD&quot;.
    /// </summary>
    [EnumMember(Value = "DLOD")]
    [IsoId("_VoDLotp-Ed-ak6NoX_4Aeg_-888615090")]
    [Description(@"Balance representing the intra day overdraft granted by the Central Bank to financial institutions participating in a RTGS system. This balance may vary over time and shall be offset at the end of the day.")]
    DaylightOverdraft = BalanceTypeCode.DaylightOverdraft, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.
    /// Encoded/decoded by serializers as &quot;XCRD&quot;.
    /// </summary>
    [EnumMember(Value = "XCRD")]
    [IsoId("_VoDLo9p-Ed-ak6NoX_4Aeg_-888614830")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day credit balance if everything books to the account and no other credit entry is posted.")]
    ExpectedCredit = BalanceTypeCode.ExpectedCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.
    /// Encoded/decoded by serializers as &quot;XDBT&quot;.
    /// </summary>
    [EnumMember(Value = "XDBT")]
    [IsoId("_VoDLpNp-Ed-ak6NoX_4Aeg_-888614813")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day debit balance if everything books to the account and no other debit entry is posted.")]
    ExpectedDebit = BalanceTypeCode.ExpectedDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank&apos;s balance is equal to the reserve due during the remaining days of the maintenance period.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("_VoDLpdp-Ed-ak6NoX_4Aeg_-888614769")]
    [Description(@"Balance to be held in the settlement account in order to comply with the average reserve due, in the event that the bank's balance is equal to the reserve due during the remaining days of the maintenance period.")]
    Adjustment = BalanceTypeCode.Adjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.
    /// Encoded/decoded by serializers as &quot;PRAV&quot;.
    /// </summary>
    [EnumMember(Value = "PRAV")]
    [IsoId("_VoDLptp-Ed-ak6NoX_4Aeg_-888614734")]
    [Description(@"Average of the daily balances on the account used to fulfil the reserve requirements calculated from the beginning of the maintenance period.")]
    ProgressiveAverage = BalanceTypeCode.ProgressiveAverage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the sum of all debit entries booked to an account.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_VoDLp9p-Ed-ak6NoX_4Aeg_-888614699")]
    [Description(@"Balance representing the sum of all debit entries booked to an account.")]
    Debit = BalanceTypeCode.Debit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_VoDLqNp-Ed-ak6NoX_4Aeg_-706679233")]
    [Description(@"Balance representing the amount that will be destined for investment. Difference between available balance and threshold for investment limit.")]
    Threshold = BalanceTypeCode.Threshold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_VoDLqdp-Ed-ak6NoX_4Aeg_1077172093")]
    [Description(@"Balance representing the amount that a financial institution has set aside for a specific reason and which is therefore not available.")]
    Noted = BalanceTypeCode.Noted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account identified (as opposed to Master Balance).
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_VoDLqtp-Ed-ak6NoX_4Aeg_-1383680720")]
    [Description(@"Balance of the account identified (as opposed to Master Balance).")]
    Self = BalanceTypeCode.Self, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the identified account plus the balance of all of its subaccounts.
    /// Encoded/decoded by serializers as &quot;MSTR&quot;.
    /// </summary>
    [EnumMember(Value = "MSTR")]
    [IsoId("_VoMVkNp-Ed-ak6NoX_4Aeg_-1165731696")]
    [Description(@"Balance of the identified account plus the balance of all of its subaccounts.")]
    Master = BalanceTypeCode.Master, // same ordinal as derivation source for type conversions
    
}
