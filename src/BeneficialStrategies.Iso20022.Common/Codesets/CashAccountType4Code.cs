// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3K75Np-Ed-ak6NoX_4Aeg_-1444721348")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType4Code
{
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a3Us4Np-Ed-ak6NoX_4Aeg_-1444721331")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment = CashAccountTypeCode.CashPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for charges if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a3Us4dp-Ed-ak6NoX_4Aeg_-1444721313")]
    [Description(@"Account used for charges if different from the account for payment.")]
    Charges = CashAccountTypeCode.Charges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for commission if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_a3Us4tp-Ed-ak6NoX_4Aeg_-1444721288")]
    [Description(@"Account used for commission if different from the account for payment.")]
    Commission = CashAccountTypeCode.Commission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for taxes if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_a3Us49p-Ed-ak6NoX_4Aeg_-1444721271")]
    [Description(@"Account used for taxes if different from the account for payment.")]
    Tax = CashAccountTypeCode.Tax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for payment of income if different from the current cash account.
    /// Encoded/decoded by serializers as &quot;CISH&quot;.
    /// </summary>
    [EnumMember(Value = "CISH")]
    [IsoId("_a3Us5Np-Ed-ak6NoX_4Aeg_-1444721036")]
    [Description(@"Account used for payment of income if different from the current cash account.")]
    CashIncome = CashAccountTypeCode.CashIncome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for trading if different from the current cash account.
    /// Encoded/decoded by serializers as &quot;TRAS&quot;.
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_a3Us5dp-Ed-ak6NoX_4Aeg_-1444721019")]
    [Description(@"Account used for trading if different from the current cash account.")]
    CashTrading = CashAccountTypeCode.CashTrading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as &quot;SACC&quot;.
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a3Us5tp-Ed-ak6NoX_4Aeg_-1444721018")]
    [Description(@"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.")]
    Settlement = CashAccountTypeCode.Settlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a3Us59p-Ed-ak6NoX_4Aeg_-1444721001")]
    [Description(@"Account used to post debits and credits when no specific account has been nominated.")]
    Current = CashAccountTypeCode.Current, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a3Us6Np-Ed-ak6NoX_4Aeg_-1444720976")]
    [Description(@"Account used for savings.")]
    Savings = CashAccountTypeCode.Savings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for overnight deposits.
    /// Encoded/decoded by serializers as &quot;ONDP&quot;.
    /// </summary>
    [EnumMember(Value = "ONDP")]
    [IsoId("_a3Us6dp-Ed-ak6NoX_4Aeg_-1444720959")]
    [Description(@"Account used for overnight deposits.")]
    OverNightDeposit = CashAccountTypeCode.OverNightDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for a marginal lending facility.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_a3ed4Np-Ed-ak6NoX_4Aeg_-1444720940")]
    [Description(@"Account used for a marginal lending facility.")]
    MarginalLending = CashAccountTypeCode.MarginalLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for non-resident external.
    /// Encoded/decoded by serializers as &quot;NREX&quot;.
    /// </summary>
    [EnumMember(Value = "NREX")]
    [IsoId("_a3ed4dp-Ed-ak6NoX_4Aeg_-1385617969")]
    [Description(@"Account used for non-resident external.")]
    NonResidentExternal = CashAccountTypeCode.NonResidentExternal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for money markets if different from the cash account.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_a3ed4tp-Ed-ak6NoX_4Aeg_-1385617950")]
    [Description(@"Account used for money markets if different from the cash account.")]
    MoneyMarket = CashAccountTypeCode.MoneyMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account used for loans.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_a3ed49p-Ed-ak6NoX_4Aeg_-1385617925")]
    [Description(@"Account used for loans.")]
    Loan = CashAccountTypeCode.Loan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accounts used for salary payments.
    /// Encoded/decoded by serializers as &quot;SLRY&quot;.
    /// </summary>
    [EnumMember(Value = "SLRY")]
    [IsoId("_a3ed5Np-Ed-ak6NoX_4Aeg_-1385617908")]
    [Description(@"Accounts used for salary payments.")]
    Salary = CashAccountTypeCode.Salary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is used for overdrafts.
    /// Encoded/decoded by serializers as &quot;ODFT&quot;.
    /// </summary>
    [EnumMember(Value = "ODFT")]
    [IsoId("_a3ed5dp-Ed-ak6NoX_4Aeg_-1385617890")]
    [Description(@"Account is used for overdrafts.")]
    Overdraft = CashAccountTypeCode.Overdraft, // same ordinal as derivation source for type conversions
    
}
