// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Generic component type belonging to a POI (Point of Interaction) Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TT2bMAEcEeCQm6a_G2yO_w_-1074872914")]
[Description(@"Generic component type belonging to a POI (Point of Interaction) Terminal.")]
[DerivedFrom(typeof(POIComponentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<POIComponentType1Code>))]
#endif
public enum POIComponentType1Code
{
    /// <summary>
    /// Payment or other software application.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_TT2bMQEcEeCQm6a_G2yO_w_570622537")]
    [Description(@"Payment or other software application.")]
    Soft = POIComponentTypeCode.Soft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVK&quot;.
    /// </summary>
    [EnumMember(Value = "EMVK")]
    [IsoId("_TT2bMgEcEeCQm6a_G2yO_w_846591134")]
    [Description(
        @"EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa)."
    )]
    EMVKernel = POIComponentTypeCode.EMVKernel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVO&quot;.
    /// </summary>
    [EnumMember(Value = "EMVO")]
    [IsoId("_TT2bMwEcEeCQm6a_G2yO_w_-1511150989")]
    [Description(
        @"EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa)."
    )]
    EMVLevel1 = POIComponentTypeCode.EMVLevel1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant interface.
    /// Encoded/decoded by serializers as &quot;MRIT&quot;.
    /// </summary>
    [EnumMember(Value = "MRIT")]
    [IsoId("_TT2bNAEcEeCQm6a_G2yO_w_835492357")]
    [Description(@"Merchant interface.")]
    MerchantInterface = POIComponentTypeCode.MerchantInterface, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Interface.
    /// Encoded/decoded by serializers as &quot;CHIT&quot;.
    /// </summary>
    [EnumMember(Value = "CHIT")]
    [IsoId("_TT2bNQEcEeCQm6a_G2yO_w_239772121")]
    [Description(@"Cardholder Interface.")]
    CardholderInterface = POIComponentTypeCode.CardholderInterface, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security module.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_TT2bNgEcEeCQm6a_G2yO_w_-1564196365")]
    [Description(@"Security module.")]
    SecureModule = POIComponentTypeCode.SecureModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Personal identification number (or PIN) entry device (PED).
    /// Encoded/decoded by serializers as &quot;PEDV&quot;.
    /// </summary>
    [EnumMember(Value = "PEDV")]
    [IsoId("_TT2bNwEcEeCQm6a_G2yO_w_373028808")]
    [Description(@"Personal identification number (or PIN) entry device (PED).")]
    PINEntryDevice = POIComponentTypeCode.PINEntryDevice, // same ordinal as derivation source for type conversions
}
