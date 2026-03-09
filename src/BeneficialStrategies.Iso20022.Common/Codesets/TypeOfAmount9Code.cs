// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dB5N0KHjEeagRbKvRt3LnA")]
[Description(@"Specifies the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount9Code
{
    /// <summary>
    /// Actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_hQXZYaHjEeagRbKvRt3LnA")]
    [Description(@"Actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.")]
    ConfirmedAmount = TypeOfAmountCode.ConfirmedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money to be moved between the debtor (ordering customer) and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_jbtPkqHjEeagRbKvRt3LnA")]
    [Description(@"Amount of money to be moved between the debtor (ordering customer) and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.|Usage: This amount has to be transported unchanged through the transaction chain.")]
    InstructedAmount = TypeOfAmountCode.InstructedAmount, // same ordinal as derivation source for type conversions
    
}
