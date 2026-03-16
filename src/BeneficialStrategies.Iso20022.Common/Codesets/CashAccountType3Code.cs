// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3Bx99p-Ed-ak6NoX_4Aeg_-801481171")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType3Code
{
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a3Bx-Np-Ed-ak6NoX_4Aeg_-729445965")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment = CashAccountTypeCode.CashPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for charges if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a3K74Np-Ed-ak6NoX_4Aeg_-728524735")]
    [Description(@"Account used for charges if different from the account for payment.")]
    Charges = CashAccountTypeCode.Charges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as &quot;SACC&quot;.
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a3K74dp-Ed-ak6NoX_4Aeg_-728524020")]
    [Description(
        @"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system."
    )]
    Settlement = CashAccountTypeCode.Settlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a3K74tp-Ed-ak6NoX_4Aeg_-728523977")]
    [Description(
        @"Account used to post debits and credits when no specific account has been nominated."
    )]
    Current = CashAccountTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a3K749p-Ed-ak6NoX_4Aeg_-728523942")]
    [Description(@"Account used for savings.")]
    Savings = CashAccountTypeCode.Savings, // same ordinal as derivation source for type conversions
}
