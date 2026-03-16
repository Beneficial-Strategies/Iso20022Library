// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of user interface to display or print information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUc4MgEcEeCQm6a_G2yO_w_-1884432238")]
[Description(@"Type of user interface to display or print information.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface1Code
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as &quot;CDSP&quot;.
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_TUc4MwEcEeCQm6a_G2yO_w_1612057850")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay = UserInterfaceCode.CardholderDisplay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as &quot;CRCP&quot;.
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_TUc4NAEcEeCQm6a_G2yO_w_728824563")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt = UserInterfaceCode.CardholderReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant display or interface.
    /// Encoded/decoded by serializers as &quot;MDSP&quot;.
    /// </summary>
    [EnumMember(Value = "MDSP")]
    [IsoId("_TUmCEAEcEeCQm6a_G2yO_w_804922611")]
    [Description(@"Merchant display or interface.")]
    MerchantDisplay = UserInterfaceCode.MerchantDisplay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant receipt.
    /// Encoded/decoded by serializers as &quot;MRCP&quot;.
    /// </summary>
    [EnumMember(Value = "MRCP")]
    [IsoId("_TUmCEQEcEeCQm6a_G2yO_w_-1552819512")]
    [Description(@"Merchant receipt.")]
    MerchantReceipt = UserInterfaceCode.MerchantReceipt, // same ordinal as derivation source for type conversions
}
