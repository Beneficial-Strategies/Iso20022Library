// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies charges linked to the conveyance of goods.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a9SK9Np-Ed-ak6NoX_4Aeg_-1551316006")]
[Description(@"Identifies charges linked to the conveyance of goods.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType8Code
{
    /// <summary>
    /// Charge is for signature services.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_a9SK9dp-Ed-ak6NoX_4Aeg_-1526379993")]
    [Description(@"Charge is for signature services.")]
    SignatureService = ChargeTypeCode.SignatureService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for storage of goods at destination.
    /// Encoded/decoded by serializers as &quot;STDE&quot;.
    /// </summary>
    [EnumMember(Value = "STDE")]
    [IsoId("_a9SK9tp-Ed-ak6NoX_4Aeg_-1526379992")]
    [Description(@"Charge is for storage of goods at destination.")]
    StorageAtDestination = ChargeTypeCode.StorageAtDestination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for storage of goods at origin.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_a9SK99p-Ed-ak6NoX_4Aeg_-1526379976")]
    [Description(@"Charge is for storage of goods at origin.")]
    StorageAtOrigin = ChargeTypeCode.StorageAtOrigin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for packaging of goods.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_a9SK-Np-Ed-ak6NoX_4Aeg_-1526379958")]
    [Description(@"Charge is for packaging of goods.")]
    Packaging = ChargeTypeCode.Packaging, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for pick-up of goods.
    /// Encoded/decoded by serializers as &quot;PICK&quot;.
    /// </summary>
    [EnumMember(Value = "PICK")]
    [IsoId("_a9b78Np-Ed-ak6NoX_4Aeg_-1526379933")]
    [Description(@"Charge is for pick-up of goods.")]
    PickUp = ChargeTypeCode.PickUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for dangerous goods.
    /// Encoded/decoded by serializers as &quot;DNGR&quot;.
    /// </summary>
    [EnumMember(Value = "DNGR")]
    [IsoId("_a9b78dp-Ed-ak6NoX_4Aeg_-1526379932")]
    [Description(@"Charge is for dangerous goods.")]
    DangerousGoodsFee = ChargeTypeCode.DangerousGoodsFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for security.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_a9b78tp-Ed-ak6NoX_4Aeg_-1526379916")]
    [Description(@"Charge is for security.")]
    SecurityCharge = ChargeTypeCode.SecurityCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is a premium for insurance.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_a9b789p-Ed-ak6NoX_4Aeg_-1526379898")]
    [Description(@"Charge is a premium for insurance.")]
    InsurancePremium = ChargeTypeCode.InsurancePremium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for the collection of the freight.
    /// Encoded/decoded by serializers as &quot;COLF&quot;.
    /// </summary>
    [EnumMember(Value = "COLF")]
    [IsoId("_a9b79Np-Ed-ak6NoX_4Aeg_-1526379873")]
    [Description(@"Charge is for the collection of the freight.")]
    CollectFreight = ChargeTypeCode.CollectFreight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for clearance and handling of goods at origin.
    /// Encoded/decoded by serializers as &quot;CHOR&quot;.
    /// </summary>
    [EnumMember(Value = "CHOR")]
    [IsoId("_a9b79dp-Ed-ak6NoX_4Aeg_-1526379872")]
    [Description(@"Charge is for clearance and handling of goods at origin.")]
    ClearanceAndHandlingAtOrigin = ChargeTypeCode.ClearanceAndHandlingAtOrigin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for clearance and handling of goods at destination.
    /// Encoded/decoded by serializers as &quot;CHDE&quot;.
    /// </summary>
    [EnumMember(Value = "CHDE")]
    [IsoId("_a9b79tp-Ed-ak6NoX_4Aeg_-1526379856")]
    [Description(@"Charge is for clearance and handling of goods at destination.")]
    ClearanceAndHandlingAtDestination = ChargeTypeCode.ClearanceAndHandlingAtDestination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is an airway bill fee.
    /// Encoded/decoded by serializers as &quot;AIRF&quot;.
    /// </summary>
    [EnumMember(Value = "AIRF")]
    [IsoId("_a9b799p-Ed-ak6NoX_4Aeg_-1526379838")]
    [Description(@"Charge is an airway bill fee.")]
    AirWayBillFee = ChargeTypeCode.AirWayBillFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is for transport.
    /// Encoded/decoded by serializers as &quot;TRPT&quot;.
    /// </summary>
    [EnumMember(Value = "TRPT")]
    [IsoId("_a9b7-Np-Ed-ak6NoX_4Aeg_1348844149")]
    [Description(@"Charge is for transport.")]
    TransportCharges = ChargeTypeCode.TransportCharges, // same ordinal as derivation source for type conversions
}
