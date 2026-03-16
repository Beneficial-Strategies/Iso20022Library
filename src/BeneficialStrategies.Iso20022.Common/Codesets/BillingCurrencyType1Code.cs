// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of currency to be used for the billing of a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WXNs5qlEeGSON8vddiWzQ_-124984192")]
[Description(@"Defines the type of currency to be used for the billing of a service.")]
[DerivedFrom(typeof(BillingCurrencyTypeCode))]
public enum BillingCurrencyType1Code
{
    /// <summary>
    /// Currency type used for the billing is the account currency.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_6WXNtJqlEeGSON8vddiWzQ_42035703")]
    [Description(@"Currency type used for the billing is the account currency.")]
    Account = BillingCurrencyTypeCode.Account, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency type used for the billing is the settlement currency.
    /// Encoded/decoded by serializers as &quot;STLM&quot;.
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_6WXNtZqlEeGSON8vddiWzQ_-2111377502")]
    [Description(@"Currency type used for the billing is the settlement currency.")]
    Settlement = BillingCurrencyTypeCode.Settlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency type used for the billing is the pricing currency.
    /// Encoded/decoded by serializers as &quot;PRCG&quot;.
    /// </summary>
    [EnumMember(Value = "PRCG")]
    [IsoId("_6WXNtpqlEeGSON8vddiWzQ_-644228739")]
    [Description(@"Currency type used for the billing is the pricing currency.")]
    Pricing = BillingCurrencyTypeCode.Pricing, // same ordinal as derivation source for type conversions
}
