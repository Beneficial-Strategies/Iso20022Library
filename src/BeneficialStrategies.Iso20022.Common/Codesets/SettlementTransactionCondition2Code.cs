// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZNExktp-Ed-ak6NoX_4Aeg_-736534954")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
public enum SettlementTransactionCondition2Code
{
    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_ZNExk9p-Ed-ak6NoX_4Aeg_908732481")]
    [Description(
        @"Transfer of ownership of the asset to another party during the closing of an option."
    )]
    Assignement = SettlementTransactionConditionCode.Assignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a buy to cover.
    /// Encoded/decoded by serializers as &quot;BUTC&quot;.
    /// </summary>
    [EnumMember(Value = "BUTC")]
    [IsoId("_ZNExlNp-Ed-ak6NoX_4Aeg_-1733607307")]
    [Description(@"Transaction is a buy to cover.")]
    BuytoCover = SettlementTransactionConditionCode.BuytoCover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZNExldp-Ed-ak6NoX_4Aeg_-2025565045")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean = SettlementTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZNExltp-Ed-ak6NoX_4Aeg_-1847446373")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty = SettlementTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as &quot;DLWM&quot;.
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_ZNExl9p-Ed-ak6NoX_4Aeg_-88339872")]
    [Description(
        @"Matching receipt instruction not required (only for concerned international or national central securities depositories)."
    )]
    DeliveryWithoutMatching = SettlementTransactionConditionCode.DeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZNExmNp-Ed-ak6NoX_4Aeg_1564287636")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SettlementTransactionConditionCode.Drawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_ZNOikNp-Ed-ak6NoX_4Aeg_1272329898")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are exercised."
    )]
    Exercised = SettlementTransactionConditionCode.Exercised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as &quot;FRCL&quot;.
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_ZNOikdp-Ed-ak6NoX_4Aeg_1450448570")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement = SettlementTransactionConditionCode.FreeCleanSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_ZNOiktp-Ed-ak6NoX_4Aeg_-1085412225")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are expired worthless."
    )]
    KnockedOut = SettlementTransactionConditionCode.KnockedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZNOik9p-Ed-ak6NoX_4Aeg_567215283")]
    [Description(@"Securities are to be physically settled.")]
    Physical = SettlementTransactionConditionCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_ZNOilNp-Ed-ak6NoX_4Aeg_275257545")]
    [Description(
        @"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository."
    )]
    Residual = SettlementTransactionConditionCode.Residual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_ZNOildp-Ed-ak6NoX_4Aeg_453376217")]
    [Description(@"Account is used for short sale orders.")]
    ShortSell = SettlementTransactionConditionCode.ShortSell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as &quot;SPDL&quot;.
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_ZNOiltp-Ed-ak6NoX_4Aeg_-429857070")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery = SettlementTransactionConditionCode.SpecialDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as &quot;SPST&quot;.
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_ZNOil9p-Ed-ak6NoX_4Aeg_-721814808")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement = SettlementTransactionConditionCode.SplitSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that have expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ZNOimNp-Ed-ak6NoX_4Aeg_1215410365")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that have expired."
    )]
    Expired = SettlementTransactionConditionCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position to cover the pending sale will be available by contractual settlement date (accounting information).
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_ZNOimdp-Ed-ak6NoX_4Aeg_-1426929423")]
    [Description(
        @"Position to cover the pending sale will be available by contractual settlement date (accounting information)."
    )]
    PendingSale = SettlementTransactionConditionCode.PendingSale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as &quot;UNEX&quot;.
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_ZNYTkNp-Ed-ak6NoX_4Aeg_-1067811063")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed = SettlementTransactionConditionCode.Unexposed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities are not be delivered but segregated following triparty collateral transaction.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_ZNYTkdp-Ed-ak6NoX_4Aeg_-577391150")]
    [Description(
        @"Securities are not be delivered but segregated following triparty collateral transaction."
    )]
    TripartySegregation = SettlementTransactionConditionCode.TripartySegregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as &quot;NOMC&quot;.
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("_ZNYTktp-Ed-ak6NoX_4Aeg_-1819459594")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim = SettlementTransactionConditionCode.NoAutomaticMarketClaim, // same ordinal as derivation source for type conversions
}
