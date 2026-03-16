// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of party should be the assured on the insurance certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjRz9Np-Ed-ak6NoX_4Aeg_1647471497")]
[Description(@"Specifies which type of party should be the assured on the insurance certificate.")]
[Derivations(typeof(AssuredType1Code))]
public enum AssuredTypeCode
{
    /// <summary>
    /// The buyer should be the assured.
    /// Encoded/decoded by serializers as &quot;BUYE&quot;.
    /// </summary>
    [EnumMember(Value = "BUYE")]
    [IsoId("_bjbk8Np-Ed-ak6NoX_4Aeg_1647471499")]
    [Description(@"The buyer should be the assured.")]
    Buyer,

    /// <summary>
    /// The seller should be the assured.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_bjbk8dp-Ed-ak6NoX_4Aeg_1647471558")]
    [Description(@"The seller should be the assured.")]
    Seller,

    /// <summary>
    /// The buyer&apos;s bank should be the assured.
    /// Encoded/decoded by serializers as &quot;BUBA&quot;.
    /// </summary>
    [EnumMember(Value = "BUBA")]
    [IsoId("_bjbk8tp-Ed-ak6NoX_4Aeg_1971625958")]
    [Description(@"The buyer's bank should be the assured.")]
    BuyerBank,

    /// <summary>
    /// The seller&apos;s bank should be the assured.
    /// Encoded/decoded by serializers as &quot;SEBA&quot;.
    /// </summary>
    [EnumMember(Value = "SEBA")]
    [IsoId("_bjbk89p-Ed-ak6NoX_4Aeg_2001181880")]
    [Description(@"The seller's bank should be the assured.")]
    SellerBank,
}
