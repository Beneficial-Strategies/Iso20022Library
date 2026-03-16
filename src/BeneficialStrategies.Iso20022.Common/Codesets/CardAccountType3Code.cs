// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cardholder account used for the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OJP9cY0kEeWzoK7sd7oTyw")]
[Description(@"Type of cardholder account used for the transaction.")]
[DerivedFrom(typeof(CardAccountTypeCode))]
public enum CardAccountType3Code
{
    /// <summary>
    /// Certificate of deposit saving account.
    /// Encoded/decoded by serializers as &quot;CTDP&quot;.
    /// </summary>
    [EnumMember(Value = "CTDP")]
    [IsoId("_OXtQMY0kEeWzoK7sd7oTyw")]
    [Description(@"Certificate of deposit saving account.")]
    CertificateOfDeposit = CardAccountTypeCode.CertificateOfDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Checking account.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_OXtQM40kEeWzoK7sd7oTyw")]
    [Description(@"Checking account.")]
    Checking = CardAccountTypeCode.Checking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_OXtQNY0kEeWzoK7sd7oTyw")]
    [Description(@"Credit card account.")]
    CreditCard = CardAccountTypeCode.CreditCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Current account.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_OXtQN40kEeWzoK7sd7oTyw")]
    [Description(@"Current account.")]
    Current = CardAccountTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit card account.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("_OXtQOY0kEeWzoK7sd7oTyw")]
    [Description(@"Debit card account.")]
    DebitCard = CardAccountTypeCode.DebitCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default account.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_OXtQO40kEeWzoK7sd7oTyw")]
    [Description(@"Default account.")]
    Default = CardAccountTypeCode.Default, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as &quot;EPRS&quot;.
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("_OXtQPY0kEeWzoK7sd7oTyw")]
    [Description(@"Electronic purse card account.")]
    EpurseCard = CardAccountTypeCode.EpurseCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Home equity loan credit account.
    /// Encoded/decoded by serializers as &quot;HEQL&quot;.
    /// </summary>
    [EnumMember(Value = "HEQL")]
    [IsoId("_OXtQP40kEeWzoK7sd7oTyw")]
    [Description(@"Home equity loan credit account.")]
    HomeEquityLoan = CardAccountTypeCode.HomeEquityLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment loan credit account.
    /// Encoded/decoded by serializers as &quot;ISTL&quot;.
    /// </summary>
    [EnumMember(Value = "ISTL")]
    [IsoId("_OXtQQY0kEeWzoK7sd7oTyw")]
    [Description(@"Instalment loan credit account.")]
    InstalmentLoan = CardAccountTypeCode.InstalmentLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_OXtQQ40kEeWzoK7sd7oTyw")]
    [Description(@"Investment account.")]
    Investment = CardAccountTypeCode.Investment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line of credit account.
    /// Encoded/decoded by serializers as &quot;LCDT&quot;.
    /// </summary>
    [EnumMember(Value = "LCDT")]
    [IsoId("_OXtQRY0kEeWzoK7sd7oTyw")]
    [Description(@"Line of credit account.")]
    LineOfCredit = CardAccountTypeCode.LineOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mobile Station Integrated Services Digital Network Number (MSISDN).
    /// Encoded/decoded by serializers as &quot;MBNW&quot;.
    /// </summary>
    [EnumMember(Value = "MBNW")]
    [IsoId("_OXtQR40kEeWzoK7sd7oTyw")]
    [Description(@"Mobile Station Integrated Services Digital Network Number (MSISDN).")]
    MobilePhoneAccount = CardAccountTypeCode.MobilePhoneAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money market saving account.
    /// Encoded/decoded by serializers as &quot;MNMK&quot;.
    /// </summary>
    [EnumMember(Value = "MNMK")]
    [IsoId("_OXtQSY0kEeWzoK7sd7oTyw")]
    [Description(@"Money market saving account.")]
    MoneyMarket = CardAccountTypeCode.MoneyMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money market checking account.
    /// Encoded/decoded by serializers as &quot;MNMC&quot;.
    /// </summary>
    [EnumMember(Value = "MNMC")]
    [IsoId("_OXtQS40kEeWzoK7sd7oTyw")]
    [Description(@"Money market checking account.")]
    MoneyMarketChecking = CardAccountTypeCode.MoneyMarketChecking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mortgage loan credit account.
    /// Encoded/decoded by serializers as &quot;MTGL&quot;.
    /// </summary>
    [EnumMember(Value = "MTGL")]
    [IsoId("_OXtQTY0kEeWzoK7sd7oTyw")]
    [Description(@"Mortgage loan credit account.")]
    MortgageLoan = CardAccountTypeCode.MortgageLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retirement account.
    /// Encoded/decoded by serializers as &quot;RTRM&quot;.
    /// </summary>
    [EnumMember(Value = "RTRM")]
    [IsoId("_OXtQT40kEeWzoK7sd7oTyw")]
    [Description(@"Retirement account.")]
    RetirementAccount = CardAccountTypeCode.RetirementAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Revolving loan account.
    /// Encoded/decoded by serializers as &quot;RVLV&quot;.
    /// </summary>
    [EnumMember(Value = "RVLV")]
    [IsoId("_OXtQUY0kEeWzoK7sd7oTyw")]
    [Description(@"Revolving loan account.")]
    RevolvingLoanAccount = CardAccountTypeCode.RevolvingLoanAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as &quot;SVNG&quot;.
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_OXtQU40kEeWzoK7sd7oTyw")]
    [Description(@"Savings account.")]
    Savings = CardAccountTypeCode.Savings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stock or bond investment account.
    /// Encoded/decoded by serializers as &quot;STBD&quot;.
    /// </summary>
    [EnumMember(Value = "STBD")]
    [IsoId("_OXtQVY0kEeWzoK7sd7oTyw")]
    [Description(@"Stock or bond investment account.")]
    StockOrBond = CardAccountTypeCode.StockOrBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as &quot;UVRL&quot;.
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_OXtQV40kEeWzoK7sd7oTyw")]
    [Description(@"Universal account.")]
    Universal = CardAccountTypeCode.Universal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-paid account.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_S8TcwY0kEeWzoK7sd7oTyw")]
    [Description(@"Pre-paid account.")]
    PrePaid = CardAccountTypeCode.PrePaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fleet card account.
    /// Encoded/decoded by serializers as &quot;FLTC&quot;.
    /// </summary>
    [EnumMember(Value = "FLTC")]
    [IsoId("_hpLzkZKYEeWRcecbKhfKuQ")]
    [Description(@"Fleet card account.")]
    FleetCard = CardAccountTypeCode.FleetCard, // same ordinal as derivation source for type conversions
}
