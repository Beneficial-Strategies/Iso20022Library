// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__uywsNojEeC60axPepSq7g_-615097257")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[Derivations(typeof(SettlementTransactionCondition7Code))]
public enum SettlementTransactionConditionV2Code
{
    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("__uywsdojEeC60axPepSq7g_-728936323")]
    [Description(@"Transfer of ownership of the asset to another party during the closing of an option.")]
    Assignment,
    
    /// <summary>
    /// Transaction is a buy to cover.
    /// Encoded/decoded by serializers as &quot;BUTC&quot;.
    /// </summary>
    [EnumMember(Value = "BUTC")]
    [IsoId("__uywstojEeC60axPepSq7g_-1904127348")]
    [Description(@"Transaction is a buy to cover.")]
    BuytoCover,
    
    /// <summary>
    /// Indicates that the trade was executed clean, ie government tax must not be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("__uyws9ojEeC60axPepSq7g_1685725333")]
    [Description(@"Indicates that the trade was executed clean, ie government tax must not be paid on the accrued interest on the bond.")]
    Clean,
    
    /// <summary>
    /// Indicates that the trade was executed dirty, ie government tax must be paid on the accrued interest on the bond.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("__uywtNojEeC60axPepSq7g_-1377131405")]
    [Description(@"Indicates that the trade was executed dirty, ie government tax must be paid on the accrued interest on the bond.")]
    Dirty,
    
    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as &quot;DLWM&quot;.
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("__uywtdojEeC60axPepSq7g_574813914")]
    [Description(@"Matching receipt instruction not required (only for concerned international or national central securities depositories).")]
    DeliveryWithoutMatching,
    
    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("__u76oNojEeC60axPepSq7g_-600377111")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("__u76odojEeC60axPepSq7g_-1305491726")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are exercised.")]
    Exercised,
    
    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as &quot;FRCL&quot;.
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("__u76otojEeC60axPepSq7g_-73381168")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("__u76o9ojEeC60axPepSq7g_1878564151")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are expired worthless.")]
    KnockedOut,
    
    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("__u76pNojEeC60axPepSq7g_703373126")]
    [Description(@"Securities are to be physically settled.")]
    Physical,
    
    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("__u76pdojEeC60axPepSq7g_-1741489")]
    [Description(@"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.")]
    Residual,
    
    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("__u76ptojEeC60axPepSq7g_1230369069")]
    [Description(@"Account is used for short sale orders.")]
    ShortSell,
    
    /// <summary>
    /// Settlement is in two different currencies.
    /// Encoded/decoded by serializers as &quot;SPCS&quot;.
    /// </summary>
    [EnumMember(Value = "SPCS")]
    [IsoId("__vFroNojEeC60axPepSq7g_-1112652908")]
    [Description(@"Settlement is in two different currencies.")]
    SplitCurrencySettlement,
    
    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as &quot;SPDL&quot;.
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("__vFrodojEeC60axPepSq7g_2007123363")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery,
    
    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as &quot;SPST&quot;.
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("__vFrotojEeC60axPepSq7g_1302008748")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement,
    
    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as &quot;UNEX&quot;.
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("__vFro9ojEeC60axPepSq7g_-1760847990")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that have expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("__vFrpNojEeC60axPepSq7g_191097329")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that have expired.")]
    Expired,
    
    /// <summary>
    /// The position to cover the pending sale will be available by contractual settlement date (accounting information).
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("__vFrpdojEeC60axPepSq7g_-984093696")]
    [Description(@"The position to cover the pending sale will be available by contractual settlement date (accounting information).")]
    PendingSale,
    
    /// <summary>
    /// Securities are not be delivered but segregated following triparty collateral transaction.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("__vFrptojEeC60axPepSq7g_626334425")]
    [Description(@"Securities are not be delivered but segregated following triparty collateral transaction.")]
    TripartySegregation,
    
    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as &quot;NOMC&quot;.
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("__vPcoNojEeC60axPepSq7g_-370737928")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim,
    
    /// <summary>
    /// Transaction on a security that is not eligible at the Central Securities Depository (CSD) but for which the payment will be enacted by the CSD.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("__vPcodojEeC60axPepSq7g_1779769601")]
    [Description(@"Transaction on a security that is not eligible at the Central Securities Depository (CSD) but for which the payment will be enacted by the CSD.")]
    CSDPaymentOnly,
    
    /// <summary>
    /// Change
    /// Encoded/decoded by serializers as &quot;YBEN&quot;.
    /// </summary>
    [EnumMember(Value = "YBEN")]
    [IsoId("_O4sYcdUjEeOz093LM8f3Hw")]
    [Description(@"Change|")]
    Change,
    
    /// <summary>
    /// Do Not Change
    /// Encoded/decoded by serializers as &quot;NBEN&quot;.
    /// </summary>
    [EnumMember(Value = "NBEN")]
    [IsoId("_RwlLkdUjEeOz093LM8f3Hw")]
    [Description(@"Do Not Change|")]
    DoNotChange,
    
    /// <summary>
    /// Eligible for netting
    /// Encoded/decoded by serializers as &quot;YNET&quot;.
    /// </summary>
    [EnumMember(Value = "YNET")]
    [IsoId("_Ta9CsdUjEeOz093LM8f3Hw")]
    [Description(@"Eligible for netting|")]
    EligibleForNetting,
    
    /// <summary>
    /// Full Payment.
    /// Encoded/decoded by serializers as &quot;FUSD&quot;.
    /// </summary>
    [EnumMember(Value = "FUSD")]
    [IsoId("_WzbaYtUjEeOz093LM8f3Hw")]
    [Description(@"Full Payment.")]
    FullPayment,
    
    /// <summary>
    /// Half Payment.
    /// Encoded/decoded by serializers as &quot;HASD&quot;.
    /// </summary>
    [EnumMember(Value = "HASD")]
    [IsoId("_WzbaY9UjEeOz093LM8f3Hw")]
    [Description(@"Half Payment.")]
    HalfPayment,
    
    /// <summary>
    /// Letter of guarantee is accepted
    /// Encoded/decoded by serializers as &quot;YLEG&quot;.
    /// </summary>
    [EnumMember(Value = "YLEG")]
    [IsoId("_a0hRQtUjEeOz093LM8f3Hw")]
    [Description(@"Letter of guarantee is accepted|")]
    LetterOfGuaranteeIsAccepted,
    
    /// <summary>
    /// Letter of guarantee is not accepted.
    /// Encoded/decoded by serializers as &quot;NLEG&quot;.
    /// </summary>
    [EnumMember(Value = "NLEG")]
    [IsoId("_a0hRQ9UjEeOz093LM8f3Hw")]
    [Description(@"Letter of guarantee is not accepted.")]
    LetterOfGuaranteeIsNotAccepted,
    
    /// <summary>
    /// Not eligible for netting
    /// Encoded/decoded by serializers as &quot;NNET&quot;.
    /// </summary>
    [EnumMember(Value = "NNET")]
    [IsoId("_dl2wc9UjEeOz093LM8f3Hw")]
    [Description(@"Not eligible for netting|")]
    NotEligibleForNetting,
    
    /// <summary>
    /// Partial Settlement
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_dl2wdNUjEeOz093LM8f3Hw")]
    [Description(@"Partial Settlement|")]
    PartialSettlement,
    
    /// <summary>
    /// Partial Settlement Not Allowed
    /// Encoded/decoded by serializers as &quot;NPAR&quot;.
    /// </summary>
    [EnumMember(Value = "NPAR")]
    [IsoId("_dl2wddUjEeOz093LM8f3Hw")]
    [Description(@"Partial Settlement Not Allowed|")]
    PartialSettlementNotAllowed,
    
    /// <summary>
    /// Re-hypothecation
    /// Encoded/decoded by serializers as &quot;RHYP&quot;.
    /// </summary>
    [EnumMember(Value = "RHYP")]
    [IsoId("_lulLF9UjEeOz093LM8f3Hw")]
    [Description(@"Re-hypothecation|")]
    ReHypothecation,
    
    /// <summary>
    /// Security eligible for collateral purposes.
    /// Encoded/decoded by serializers as &quot;COLA&quot;.
    /// </summary>
    [EnumMember(Value = "COLA")]
    [IsoId("_lulLGNUjEeOz093LM8f3Hw")]
    [Description(@"Security eligible for collateral purposes.")]
    SecurityEligibleForCollateralPurposes,
    
    /// <summary>
    /// Security not eligible for collateral purposes
    /// Encoded/decoded by serializers as &quot;COLN&quot;.
    /// </summary>
    [EnumMember(Value = "COLN")]
    [IsoId("_lulLGdUjEeOz093LM8f3Hw")]
    [Description(@"Security not eligible for collateral purposes|")]
    SecurityNotEligibleForCollateralPurposes,
    
    /// <summary>
    /// Settlement Instruction is CCP eligible
    /// Encoded/decoded by serializers as &quot;YCCP&quot;.
    /// </summary>
    [EnumMember(Value = "YCCP")]
    [IsoId("_lulLGtUjEeOz093LM8f3Hw")]
    [Description(@"Settlement Instruction is CCP eligible|")]
    SettlementInstructionIsCCPEligible,
    
    /// <summary>
    /// Settlement Instruction is not CCP eligible.
    /// Encoded/decoded by serializers as &quot;NCCP&quot;.
    /// </summary>
    [EnumMember(Value = "NCCP")]
    [IsoId("_lulLG9UjEeOz093LM8f3Hw")]
    [Description(@"Settlement Instruction is not CCP eligible.")]
    SettlementInstructionIsNotCCPEligible,
    
    /// <summary>
    /// Settle through the Non-RTGS System.
    /// Encoded/decoded by serializers as &quot;NRTG&quot;.
    /// </summary>
    [EnumMember(Value = "NRTG")]
    [IsoId("_lulLHNUjEeOz093LM8f3Hw")]
    [Description(@"Settle through the Non-RTGS System.")]
    SettleThroughTheNon_RTGSSystem,
    
    /// <summary>
    /// Settle through the RTGS System
    /// Encoded/decoded by serializers as &quot;YRTG&quot;.
    /// </summary>
    [EnumMember(Value = "YRTG")]
    [IsoId("_lulLHdUjEeOz093LM8f3Hw")]
    [Description(@"Settle through the RTGS System|")]
    SettleThroughTheRTGSSystem,
    
    /// <summary>
    /// Uncertified Securities Tax not applicable
    /// Encoded/decoded by serializers as &quot;USTN&quot;.
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_rLBlo9UjEeOz093LM8f3Hw")]
    [Description(@"Uncertified Securities Tax not applicable|")]
    UncertifiedSecuritiesTaxNotApplicable,
    
    /// <summary>
    /// Unregistered Security Issued Pursuant to Rule 144A.
    /// Encoded/decoded by serializers as &quot;USLE&quot;.
    /// </summary>
    [EnumMember(Value = "USLE")]
    [IsoId("_rLBlpNUjEeOz093LM8f3Hw")]
    [Description(@"Unregistered Security Issued Pursuant to Rule 144A.")]
    USLegal144A,
    
    /// <summary>
    /// Zengin (JP)
    /// Encoded/decoded by serializers as &quot;ZENG&quot;.
    /// </summary>
    [EnumMember(Value = "ZENG")]
    [IsoId("_rLBlpdUjEeOz093LM8f3Hw")]
    [Description(@"Zengin (JP)|")]
    Zengin,
    
    /// <summary>
    /// Transformation.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_tI5g4dZ-EeOU8580Vi8J4Q")]
    [Description(@"Transformation.")]
    Transformation,
    
}
