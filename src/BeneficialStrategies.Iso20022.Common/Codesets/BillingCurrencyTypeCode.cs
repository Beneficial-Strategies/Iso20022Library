// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the currency type to be used in the billing balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WXNt5qlEeGSON8vddiWzQ_-277040483")]
[Description(@"Defines the currency type to be used in the billing balance.")]
[Derivations(typeof(BillingCurrencyType1Code),typeof(BillingCurrencyType2Code))]
public enum BillingCurrencyTypeCode
{
    /// <summary>
    /// Currency type used for the billing is the account currency.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_6WgXoJqlEeGSON8vddiWzQ_31738483")]
    [Description(@"Currency type used for the billing is the account currency.")]
    Account,
    
    /// <summary>
    /// Currency type used for the billing is the settlement currency.
    /// Encoded/decoded by serializers as &quot;STLM&quot;.
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_6WgXoZqlEeGSON8vddiWzQ_980341693")]
    [Description(@"Currency type used for the billing is the settlement currency.")]
    Settlement,
    
    /// <summary>
    /// Currency type used for the billing is the pricing currency.
    /// Encoded/decoded by serializers as &quot;PRCG&quot;.
    /// </summary>
    [EnumMember(Value = "PRCG")]
    [IsoId("_6WgXopqlEeGSON8vddiWzQ_1527764681")]
    [Description(@"Currency type used for the billing is the pricing currency.")]
    Pricing,
    
    /// <summary>
    /// Currency type used for the billing is the host currency.
    /// Encoded/decoded by serializers as &quot;HOST&quot;.
    /// </summary>
    [EnumMember(Value = "HOST")]
    [IsoId("_6WgXo5qlEeGSON8vddiWzQ_2058003514")]
    [Description(@"Currency type used for the billing is the host currency.")]
    Host,
    
}
