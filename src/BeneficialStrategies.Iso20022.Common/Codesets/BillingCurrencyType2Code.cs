// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of currency to be used for the billing of a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WzSkZqlEeGSON8vddiWzQ_-1596461946")]
[Description(@"Defines the type of currency to be used for the billing of a service.")]
[DerivedFrom(typeof(BillingCurrencyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BillingCurrencyType2Code>))]
#endif
public enum BillingCurrencyType2Code
{
    /// <summary>
    /// Currency type used for the billing is the account currency.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_6WzSkpqlEeGSON8vddiWzQ_-1127654531")]
    [Description(@"Currency type used for the billing is the account currency.")]
    Account = BillingCurrencyTypeCode.Account, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency type used for the billing is the settlement currency.
    /// Encoded/decoded by serializers as &quot;STLM&quot;.
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_6WzSk5qlEeGSON8vddiWzQ_-541707505")]
    [Description(@"Currency type used for the billing is the settlement currency.")]
    Settlement = BillingCurrencyTypeCode.Settlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency type used for the billing is the pricing currency.
    /// Encoded/decoded by serializers as &quot;PRCG&quot;.
    /// </summary>
    [EnumMember(Value = "PRCG")]
    [IsoId("_6WzSlJqlEeGSON8vddiWzQ_-1424940792")]
    [Description(@"Currency type used for the billing is the pricing currency.")]
    Pricing = BillingCurrencyTypeCode.Pricing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency type used for the billing is the host currency.
    /// Encoded/decoded by serializers as &quot;HOST&quot;.
    /// </summary>
    [EnumMember(Value = "HOST")]
    [IsoId("_6WzSlZqlEeGSON8vddiWzQ_-1920390448")]
    [Description(@"Currency type used for the billing is the host currency.")]
    Host = BillingCurrencyTypeCode.Host, // same ordinal as derivation source for type conversions
}
