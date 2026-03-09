// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wuqZNojEeC60axPepSq7g_237623552")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionV2Code))]
public enum SettlementTransactionCondition7Code
{
    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("__wuqZdojEeC60axPepSq7g_724870590")]
    [Description(@"Transfer of ownership of the asset to another party during the closing of an option.")]
    Assignment = SettlementTransactionConditionV2Code.Assignment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade was executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("__w30UNojEeC60axPepSq7g_-650054422")]
    [Description(@"Indicates that the trade was executed clean, ie government tax must not be paid on the accrued interest on the bond.")]
    Clean = SettlementTransactionConditionV2Code.Clean, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade was executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("__w30UdojEeC60axPepSq7g_874013874")]
    [Description(@"Indicates that the trade was executed dirty, ie government tax must be paid on the accrued interest on the bond.")]
    Dirty = SettlementTransactionConditionV2Code.Dirty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as &quot;DLWM&quot;.
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("__w30UtojEeC60axPepSq7g_402380554")]
    [Description(@"Matching receipt instruction not required (only for concerned international or national central securities depositories).")]
    DeliveryWithoutMatching = SettlementTransactionConditionV2Code.DeliveryWithoutMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("__w30U9ojEeC60axPepSq7g_1926448850")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SettlementTransactionConditionV2Code.Drawn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("__xBlUNojEeC60axPepSq7g_1480400892")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are exercised.")]
    Exercised = SettlementTransactionConditionV2Code.Exercised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as &quot;FRCL&quot;.
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("__xBlUdojEeC60axPepSq7g_-1290498108")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement = SettlementTransactionConditionV2Code.FreeCleanSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("__xBlUtojEeC60axPepSq7g_2066347918")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are expired worthless.")]
    KnockedOut = SettlementTransactionConditionV2Code.KnockedOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("__xBlU9ojEeC60axPepSq7g_687664975")]
    [Description(@"Securities are to be physically settled.")]
    Physical = SettlementTransactionConditionV2Code.Physical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction on a security that is not eligible at the Central Securities Depository (CSD) but for which the payment will be enacted by the CSD.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("__xBlVNojEeC60axPepSq7g_1823372701")]
    [Description(@"Transaction on a security that is not eligible at the Central Securities Depository (CSD) but for which the payment will be enacted by the CSD.")]
    CSDPaymentOnly = SettlementTransactionConditionV2Code.CSDPaymentOnly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is in two different currencies.
    /// Encoded/decoded by serializers as &quot;SPCS&quot;.
    /// </summary>
    [EnumMember(Value = "SPCS")]
    [IsoId("__xBlVdojEeC60axPepSq7g_-1322468872")]
    [Description(@"Settlement is in two different currencies.")]
    SplitCurrencySettlement = SettlementTransactionConditionV2Code.SplitCurrencySettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as &quot;SPDL&quot;.
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("__xBlVtojEeC60axPepSq7g_1130653467")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery = SettlementTransactionConditionV2Code.SpecialDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as &quot;SPST&quot;.
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("__xBlV9ojEeC60axPepSq7g_-561526730")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement = SettlementTransactionConditionV2Code.SplitSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as &quot;UNEX&quot;.
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("__xLWUNojEeC60axPepSq7g_962541566")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed = SettlementTransactionConditionV2Code.Unexposed, // same ordinal as derivation source for type conversions
    
}
