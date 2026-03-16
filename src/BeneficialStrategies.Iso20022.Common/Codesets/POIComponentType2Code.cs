// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Generic component type belonging to a POI (Point of Interaction) Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTVhw31DEeCF8NjrBemJWQ_-502719027")]
[Description(@"Generic component type belonging to a POI (Point of Interaction) Terminal.")]
[DerivedFrom(typeof(POIComponentTypeCode))]
public enum POIComponentType2Code
{
    /// <summary>
    /// Payment or other software application.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_KTVhxH1DEeCF8NjrBemJWQ_1908221676")]
    [Description(@"Payment or other software application.")]
    Soft = POIComponentTypeCode.Soft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVK&quot;.
    /// </summary>
    [EnumMember(Value = "EMVK")]
    [IsoId("_KTVhxX1DEeCF8NjrBemJWQ_-847957178")]
    [Description(
        @"EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa)."
    )]
    EMVKernel = POIComponentTypeCode.EMVKernel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;EMVO&quot;.
    /// </summary>
    [EnumMember(Value = "EMVO")]
    [IsoId("_KTVhxn1DEeCF8NjrBemJWQ_-403699691")]
    [Description(
        @"EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa)."
    )]
    EMVLevel1 = POIComponentTypeCode.EMVLevel1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant interface.
    /// Encoded/decoded by serializers as &quot;MRIT&quot;.
    /// </summary>
    [EnumMember(Value = "MRIT")]
    [IsoId("_KTVhx31DEeCF8NjrBemJWQ_1135088751")]
    [Description(@"Merchant interface.")]
    MerchantInterface = POIComponentTypeCode.MerchantInterface, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Interface.
    /// Encoded/decoded by serializers as &quot;CHIT&quot;.
    /// </summary>
    [EnumMember(Value = "CHIT")]
    [IsoId("_KTVhyH1DEeCF8NjrBemJWQ_1438145266")]
    [Description(@"Cardholder Interface.")]
    CardholderInterface = POIComponentTypeCode.CardholderInterface, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security module.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_KTersH1DEeCF8NjrBemJWQ_262954241")]
    [Description(@"Security module.")]
    SecureModule = POIComponentTypeCode.SecureModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Personal identification number (or PIN) entry device (PED).
    /// Encoded/decoded by serializers as &quot;PEDV&quot;.
    /// </summary>
    [EnumMember(Value = "PEDV")]
    [IsoId("_KTersX1DEeCF8NjrBemJWQ_-2048967126")]
    [Description(@"Personal identification number (or PIN) entry device (PED).")]
    PINEntryDevice = POIComponentTypeCode.PINEntryDevice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_KTersn1DEeCF8NjrBemJWQ_1452865412")]
    [Description(
        @"Acquirer specific configuration parameters for the point of interaction (POI) system."
    )]
    AcquirerParameters = POIComponentTypeCode.AcquirerParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_KTers31DEeCF8NjrBemJWQ_-2037868349")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = POIComponentTypeCode.MerchantParameters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as &quot;VDPR&quot;.
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_KTertH1DEeCF8NjrBemJWQ_-1553071793")]
    [Description(
        @"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities."
    )]
    VendorParameters = POIComponentTypeCode.VendorParameters, // same ordinal as derivation source for type conversions
}
