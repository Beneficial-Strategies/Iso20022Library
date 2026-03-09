// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3ed5tp-Ed-ak6NoX_4Aeg_-1826678245")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[Derivations(typeof(CashAccountType1Code),typeof(CashAccountType4Code),typeof(CashAccountType3Code),typeof(CashAccountType2Code),typeof(CashAccountType5Code))]
public enum CashAccountTypeCode
{
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a3ed59p-Ed-ak6NoX_4Aeg_-1801743163")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment,
    
    /// <summary>
    /// Account used for charges if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a3ed6Np-Ed-ak6NoX_4Aeg_-1784198077")]
    [Description(@"Account used for charges if different from the account for payment.")]
    Charges,
    
    /// <summary>
    /// Account used for commission if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_a3ed6dp-Ed-ak6NoX_4Aeg_-1771269963")]
    [Description(@"Account used for commission if different from the account for payment.")]
    Commission,
    
    /// <summary>
    /// Account used for taxes if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_a3nn0Np-Ed-ak6NoX_4Aeg_-1525610822")]
    [Description(@"Account used for taxes if different from the account for payment.")]
    Tax,
    
    /// <summary>
    /// Account used for payment of income if different from the current cash account.
    /// Encoded/decoded by serializers as &quot;CISH&quot;.
    /// </summary>
    [EnumMember(Value = "CISH")]
    [IsoId("_a3nn0dp-Ed-ak6NoX_4Aeg_5556843")]
    [Description(@"Account used for payment of income if different from the current cash account.")]
    CashIncome,
    
    /// <summary>
    /// Account used for trading if different from the current cash account.
    /// Encoded/decoded by serializers as &quot;TRAS&quot;.
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_a3nn0tp-Ed-ak6NoX_4Aeg_5556844")]
    [Description(@"Account used for trading if different from the current cash account.")]
    CashTrading,
    
    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as &quot;SACC&quot;.
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a3nn09p-Ed-ak6NoX_4Aeg_5556853")]
    [Description(@"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.")]
    Settlement,
    
    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a3nn1Np-Ed-ak6NoX_4Aeg_5556854")]
    [Description(@"Account used to post debits and credits when no specific account has been nominated.")]
    Current,
    
    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a3nn1dp-Ed-ak6NoX_4Aeg_2076628417")]
    [Description(@"Account used for savings.")]
    Savings,
    
    /// <summary>
    /// Account used for overnight deposits.
    /// Encoded/decoded by serializers as &quot;ONDP&quot;.
    /// </summary>
    [EnumMember(Value = "ONDP")]
    [IsoId("_a3nn1tp-Ed-ak6NoX_4Aeg_1132707560")]
    [Description(@"Account used for overnight deposits.")]
    OverNightDeposit,
    
    /// <summary>
    /// Account used for a marginal lending facility.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_a3nn19p-Ed-ak6NoX_4Aeg_1132707561")]
    [Description(@"Account used for a marginal lending facility.")]
    MarginalLending,
    
    /// <summary>
    /// Account used for non-resident external.
    /// Encoded/decoded by serializers as &quot;NREX&quot;.
    /// </summary>
    [EnumMember(Value = "NREX")]
    [IsoId("_a3nn2Np-Ed-ak6NoX_4Aeg_-2105961045")]
    [Description(@"Account used for non-resident external.")]
    NonResidentExternal,
    
    /// <summary>
    /// Account used for money markets if different from the cash account.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_a3nn2dp-Ed-ak6NoX_4Aeg_-2076408775")]
    [Description(@"Account used for money markets if different from the cash account.")]
    MoneyMarket,
    
    /// <summary>
    /// Account used for loans.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_a3xY0Np-Ed-ak6NoX_4Aeg_-1843684449")]
    [Description(@"Account used for loans.")]
    Loan,
    
    /// <summary>
    /// Accounts used for salary payments.
    /// Encoded/decoded by serializers as &quot;SLRY&quot;.
    /// </summary>
    [EnumMember(Value = "SLRY")]
    [IsoId("_a3xY0dp-Ed-ak6NoX_4Aeg_-1832601749")]
    [Description(@"Accounts used for salary payments.")]
    Salary,
    
    /// <summary>
    /// Account is used for overdrafts.
    /// Encoded/decoded by serializers as &quot;ODFT&quot;.
    /// </summary>
    [EnumMember(Value = "ODFT")]
    [IsoId("_a3xY0tp-Ed-ak6NoX_4Aeg_-1819672967")]
    [Description(@"Account is used for overdrafts.")]
    Overdraft,
    
    /// <summary>
    /// Account is for the coverage of lending.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("_bu-5YCCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for the coverage of lending.")]
    Lending,
    
    /// <summary>
    /// Account is for collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_fQOykCCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for collateral.")]
    Collateral,
    
    /// <summary>
    /// Account is for financial settlements.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ikYq8CCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for financial settlements.")]
    FinancialSettlement,
    
    /// <summary>
    /// Account is for margin returns.
    /// Encoded/decoded by serializers as &quot;MARR&quot;.
    /// </summary>
    [EnumMember(Value = "MARR")]
    [IsoId("_m1ZNICCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for margin returns.")]
    MarginReturn,
    
    /// <summary>
    /// Account is an segregated account.
    /// Encoded/decoded by serializers as &quot;SEGT&quot;.
    /// </summary>
    [EnumMember(Value = "SEGT")]
    [IsoId("_sFVcwCCyEeWJd9HF2tO7BA")]
    [Description(@"Account is an segregated account.")]
    Segregated,
    
}
