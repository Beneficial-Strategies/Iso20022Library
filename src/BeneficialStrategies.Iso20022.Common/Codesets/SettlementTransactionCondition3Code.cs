// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZNYTk9p-Ed-ak6NoX_4Aeg_-969430836")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
public enum SettlementTransactionCondition3Code
{
    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_ZNYTlNp-Ed-ak6NoX_4Aeg_-905151230")]
    [Description(
        @"Transfer of ownership of the asset to another party during the closing of an option."
    )]
    Assignement = SettlementTransactionConditionCode.Assignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZNYTldp-Ed-ak6NoX_4Aeg_-1788384517")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean = SettlementTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZNYTltp-Ed-ak6NoX_4Aeg_-2080342255")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty = SettlementTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as &quot;DLWM&quot;.
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_ZNYTl9p-Ed-ak6NoX_4Aeg_-1902223583")]
    [Description(
        @"Matching receipt instruction not required (only for concerned international or national central securities depositories)."
    )]
    DeliveryWithoutMatching = SettlementTransactionConditionCode.DeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZNYTmNp-Ed-ak6NoX_4Aeg_1331391754")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SettlementTransactionConditionCode.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_ZNYTmdp-Ed-ak6NoX_4Aeg_1509510426")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are exercised."
    )]
    Exercised = SettlementTransactionConditionCode.Exercised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as &quot;FRCL&quot;.
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_ZNhdgNp-Ed-ak6NoX_4Aeg_1217552688")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement = SettlementTransactionConditionCode.FreeCleanSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_ZNhdgdp-Ed-ak6NoX_4Aeg_1395671360")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are expired worthless."
    )]
    KnockedOut = SettlementTransactionConditionCode.KnockedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZNhdgtp-Ed-ak6NoX_4Aeg_334319401")]
    [Description(@"Securities are to be physically settled.")]
    Physical = SettlementTransactionConditionCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_ZNhdg9p-Ed-ak6NoX_4Aeg_512438073")]
    [Description(
        @"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository."
    )]
    Residual = SettlementTransactionConditionCode.Residual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as &quot;SPDL&quot;.
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_ZNhdhNp-Ed-ak6NoX_4Aeg_-662752952")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery = SettlementTransactionConditionCode.SpecialDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as &quot;SPST&quot;.
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_ZNhdhdp-Ed-ak6NoX_4Aeg_-484634280")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement = SettlementTransactionConditionCode.SplitSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as &quot;UNEX&quot;.
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_ZNhdhtp-Ed-ak6NoX_4Aeg_-2125897437")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed = SettlementTransactionConditionCode.Unexposed, // same ordinal as derivation source for type conversions
}
