// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of party should be the assured on the insurance certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bfaAl9p-Ed-ak6NoX_4Aeg_1045068469")]
[Description(@"Specifies which type of party should be the assured on the insurance certificate.")]
[DerivedFrom(typeof(AssuredTypeCode))]
public enum AssuredType1Code
{
    /// <summary>
    /// The buyer should be the assured.
    /// Encoded/decoded by serializers as &quot;BUYE&quot;.
    /// </summary>
    [EnumMember(Value = "BUYE")]
    [IsoId("_bjRz8Np-Ed-ak6NoX_4Aeg_1342444833")]
    [Description(@"The buyer should be the assured.")]
    Buyer = AssuredTypeCode.Buyer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The seller should be the assured.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_bjRz8dp-Ed-ak6NoX_4Aeg_1345214881")]
    [Description(@"The seller should be the assured.")]
    Seller = AssuredTypeCode.Seller, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The buyer&apos;s bank should be the assured.
    /// Encoded/decoded by serializers as &quot;BUBA&quot;.
    /// </summary>
    [EnumMember(Value = "BUBA")]
    [IsoId("_bjRz8tp-Ed-ak6NoX_4Aeg_1370148507")]
    [Description(@"The buyer's bank should be the assured.")]
    BuyerBank = AssuredTypeCode.BuyerBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The seller&apos;s bank should be the assured.
    /// Encoded/decoded by serializers as &quot;SEBA&quot;.
    /// </summary>
    [EnumMember(Value = "SEBA")]
    [IsoId("_bjRz89p-Ed-ak6NoX_4Aeg_1384000890")]
    [Description(@"The seller's bank should be the assured.")]
    SellerBank = AssuredTypeCode.SellerBank, // same ordinal as derivation source for type conversions
}
