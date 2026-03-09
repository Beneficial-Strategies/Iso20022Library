// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cardholder account used for the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xA5FIGkFEeS7zPBpvm732w")]
[Description(@"Type of cardholder account used for the transaction.")]
[DerivedFrom(typeof(CardAccountTypeCode))]
public enum CardAccountType2Code
{
    /// <summary>
    /// Certificate of deposit saving account.
    /// Encoded/decoded by serializers as &quot;CTDP&quot;.
    /// </summary>
    [EnumMember(Value = "CTDP")]
    [IsoId("_4Q354WkFEeS7zPBpvm732w")]
    [Description(@"Certificate of deposit saving account.")]
    CertificateOfDeposit = CardAccountTypeCode.CertificateOfDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Checking account.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_4WziwWkFEeS7zPBpvm732w")]
    [Description(@"Checking account.")]
    Checking = CardAccountTypeCode.Checking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_4dNswWkFEeS7zPBpvm732w")]
    [Description(@"Credit card account.")]
    CreditCard = CardAccountTypeCode.CreditCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Current account.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_4kKpUWkFEeS7zPBpvm732w")]
    [Description(@"Current account.")]
    Current = CardAccountTypeCode.Current, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debit card account.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("_4uAh0WkFEeS7zPBpvm732w")]
    [Description(@"Debit card account.")]
    DebitCard = CardAccountTypeCode.DebitCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Default account.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_41VR0WkFEeS7zPBpvm732w")]
    [Description(@"Default account.")]
    Default = CardAccountTypeCode.Default, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as &quot;EPRS&quot;.
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("_48Mu0WkFEeS7zPBpvm732w")]
    [Description(@"Electronic purse card account.")]
    EpurseCard = CardAccountTypeCode.EpurseCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Home equity loan credit account.
    /// Encoded/decoded by serializers as &quot;HEQL&quot;.
    /// </summary>
    [EnumMember(Value = "HEQL")]
    [IsoId("_6KsiQWkFEeS7zPBpvm732w")]
    [Description(@"Home equity loan credit account.")]
    HomeEquityLoan = CardAccountTypeCode.HomeEquityLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instalment loan credit account.
    /// Encoded/decoded by serializers as &quot;ISTL&quot;.
    /// </summary>
    [EnumMember(Value = "ISTL")]
    [IsoId("_6QpZQWkFEeS7zPBpvm732w")]
    [Description(@"Instalment loan credit account.")]
    InstalmentLoan = CardAccountTypeCode.InstalmentLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_6X0_UWkFEeS7zPBpvm732w")]
    [Description(@"Investment account.")]
    Investment = CardAccountTypeCode.Investment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Line of credit account.
    /// Encoded/decoded by serializers as &quot;LCDT&quot;.
    /// </summary>
    [EnumMember(Value = "LCDT")]
    [IsoId("_6hvJQWkFEeS7zPBpvm732w")]
    [Description(@"Line of credit account.")]
    LineOfCredit = CardAccountTypeCode.LineOfCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mobile Station Integrated Services Digital Network Number (MSISDN).
    /// Encoded/decoded by serializers as &quot;MBNW&quot;.
    /// </summary>
    [EnumMember(Value = "MBNW")]
    [IsoId("_6tftUWkFEeS7zPBpvm732w")]
    [Description(@"Mobile Station Integrated Services Digital Network Number (MSISDN).")]
    MobilePhoneAccount = CardAccountTypeCode.MobilePhoneAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Money market saving account.
    /// Encoded/decoded by serializers as &quot;MNMK&quot;.
    /// </summary>
    [EnumMember(Value = "MNMK")]
    [IsoId("_70cHQWkFEeS7zPBpvm732w")]
    [Description(@"Money market saving account.")]
    MoneyMarket = CardAccountTypeCode.MoneyMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Money market checking account.
    /// Encoded/decoded by serializers as &quot;MNMC&quot;.
    /// </summary>
    [EnumMember(Value = "MNMC")]
    [IsoId("_77nGQWkFEeS7zPBpvm732w")]
    [Description(@"Money market checking account.")]
    MoneyMarketChecking = CardAccountTypeCode.MoneyMarketChecking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mortgage loan credit account.
    /// Encoded/decoded by serializers as &quot;MTGL&quot;.
    /// </summary>
    [EnumMember(Value = "MTGL")]
    [IsoId("_8DeBwWkFEeS7zPBpvm732w")]
    [Description(@"Mortgage loan credit account.")]
    MortgageLoan = CardAccountTypeCode.MortgageLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Retirement account.
    /// Encoded/decoded by serializers as &quot;RTRM&quot;.
    /// </summary>
    [EnumMember(Value = "RTRM")]
    [IsoId("_8LU9QWkFEeS7zPBpvm732w")]
    [Description(@"Retirement account.")]
    RetirementAccount = CardAccountTypeCode.RetirementAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Revolving loan account.
    /// Encoded/decoded by serializers as &quot;RVLV&quot;.
    /// </summary>
    [EnumMember(Value = "RVLV")]
    [IsoId("_8VPuQWkFEeS7zPBpvm732w")]
    [Description(@"Revolving loan account.")]
    RevolvingLoanAccount = CardAccountTypeCode.RevolvingLoanAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as &quot;SVNG&quot;.
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_89JbwWkFEeS7zPBpvm732w")]
    [Description(@"Savings account.")]
    Savings = CardAccountTypeCode.Savings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stock or bond investment account.
    /// Encoded/decoded by serializers as &quot;STBD&quot;.
    /// </summary>
    [EnumMember(Value = "STBD")]
    [IsoId("_9CVdwWkFEeS7zPBpvm732w")]
    [Description(@"Stock or bond investment account.")]
    StockOrBond = CardAccountTypeCode.StockOrBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as &quot;UVRL&quot;.
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_9IXNQWkFEeS7zPBpvm732w")]
    [Description(@"Universal account.")]
    Universal = CardAccountTypeCode.Universal, // same ordinal as derivation source for type conversions
    
}
