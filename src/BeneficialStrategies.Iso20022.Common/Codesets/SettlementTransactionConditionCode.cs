// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Collateral position is available for other purposes (for example, onwards delivery).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZNhdh9p-Ed-ak6NoX_4Aeg_885272360")]
[Description(
    @"Collateral position is available for other purposes (for example, onwards delivery)."
)]
[Derivations(
    typeof(SettlementTransactionCondition8Code),
    typeof(SettlementTransactionCondition6Code),
    typeof(SettlementTransactionCondition11Code),
    typeof(SettlementTransactionCondition13Code),
    typeof(SettlementTransactionCondition10Code),
    typeof(SettlementTransactionCondition4Code),
    typeof(SettlementTransactionCondition12Code),
    typeof(SettlementTransactionCondition14Code),
    typeof(SettlementTransactionCondition3Code),
    typeof(SettlementTransactionCondition5Code),
    typeof(SettlementTransactionCondition2Code)
)]
public enum SettlementTransactionConditionCode
{
    /// <summary>
    /// Partial settlement is allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZM7nodp-Ed-ak6NoX_4Aeg_-423758793")]
    [Description(@"Partial settlement is allowed.")]
    PartialAllowed,

    /// <summary>
    /// Partial settlement is not allowed.
    /// Encoded/decoded by serializers as &quot;NPAR&quot;.
    /// </summary>
    [EnumMember(Value = "NPAR")]
    [IsoId("_ZM7notp-Ed-ak6NoX_4Aeg_-423758758")]
    [Description(@"Partial settlement is not allowed.")]
    PartialNotAllowed,

    /// <summary>
    /// Partial settlement is allowed but must satisfy a cash value minimum (value defined in static data).
    /// Encoded/decoded by serializers as &quot;PARC&quot;.
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_37gVQOBGEd-D2OAFXdoRmA")]
    [Description(
        @"Partial settlement is allowed but must satisfy a cash value minimum (value defined in static data)."
    )]
    PartialSettlementCashThresholdAllowed,

    /// <summary>
    /// Partial settlement is allowed but must satisfy a minimum quantity of securities (quantity defined in static data).
    /// Encoded/decoded by serializers as &quot;PARQ&quot;.
    /// </summary>
    [EnumMember(Value = "PARQ")]
    [IsoId("_HPHCMOBHEd-D2OAFXdoRmA")]
    [Description(
        @"Partial settlement is allowed but must satisfy a minimum quantity of securities (quantity defined in static data)."
    )]
    PartialSettlementQuantityThresholdAllowed,

    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_ZNhdiNp-Ed-ak6NoX_4Aeg_771433294")]
    [Description(
        @"Transfer of ownership of the asset to another party during the closing of an option."
    )]
    Assignement,

    /// <summary>
    /// Transaction is a buy to cover.
    /// Encoded/decoded by serializers as &quot;BUTC&quot;.
    /// </summary>
    [EnumMember(Value = "BUTC")]
    [IsoId("_ZNrOgNp-Ed-ak6NoX_4Aeg_-403757731")]
    [Description(@"Transaction is a buy to cover.")]
    BuytoCover,

    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;CLEN&quot;.
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZNrOgdp-Ed-ak6NoX_4Aeg_-1108872346")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean,

    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as &quot;DIRT&quot;.
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZNrOgtp-Ed-ak6NoX_4Aeg_536395089")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty,

    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as &quot;DLWM&quot;.
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_ZNrOg9p-Ed-ak6NoX_4Aeg_2075183531")]
    [Description(
        @"Matching receipt instruction not required (only for concerned international or national central securities depositories)."
    )]
    DeliveryWithoutMatching,

    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZNrOhNp-Ed-ak6NoX_4Aeg_-1628992347")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn,

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_ZNrOhdp-Ed-ak6NoX_4Aeg_1960860334")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are exercised."
    )]
    Exercised,

    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as &quot;FRCL&quot;.
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_ZNrOhtp-Ed-ak6NoX_4Aeg_-688839527")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement,

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_ZNrOh9p-Ed-ak6NoX_4Aeg_849948915")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that are expired worthless."
    )]
    KnockedOut,

    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZNrOiNp-Ed-ak6NoX_4Aeg_-325242110")]
    [Description(@"Securities are to be physically settled.")]
    Physical,

    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_ZNrOidp-Ed-ak6NoX_4Aeg_-1030356725")]
    [Description(
        @"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository."
    )]
    Residual,

    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_ZN0YcNp-Ed-ak6NoX_4Aeg_614910710")]
    [Description(@"Account is used for short sale orders.")]
    ShortSell,

    /// <summary>
    /// Settlement is in two different currencies.
    /// Encoded/decoded by serializers as &quot;SPCS&quot;.
    /// </summary>
    [EnumMember(Value = "SPCS")]
    [IsoId("_ZN0Ycdp-Ed-ak6NoX_4Aeg_-2141268144")]
    [Description(@"Settlement is in two different currencies.")]
    SplitCurrencySettlement,

    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as &quot;SPDL&quot;.
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_ZN0Yctp-Ed-ak6NoX_4Aeg_978508127")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery,

    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as &quot;SPST&quot;.
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_ZN0Yc9p-Ed-ak6NoX_4Aeg_273393512")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement,

    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as &quot;UNEX&quot;.
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_ZN0YdNp-Ed-ak6NoX_4Aeg_1918660947")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed,

    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that have expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ZN0Yddp-Ed-ak6NoX_4Aeg_-837517907")]
    [Description(
        @"Settlement transaction relates to options, futures or derivatives that have expired."
    )]
    Expired,

    /// <summary>
    /// Position to cover the pending sale will be available by contractual settlement date (accounting information).
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_ZN0Ydtp-Ed-ak6NoX_4Aeg_-2012708932")]
    [Description(
        @"Position to cover the pending sale will be available by contractual settlement date (accounting information)."
    )]
    PendingSale,

    /// <summary>
    /// Securities are not be delivered but segregated following triparty collateral transaction.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_ZN0Yd9p-Ed-ak6NoX_4Aeg_-1846180219")]
    [Description(
        @"Securities are not be delivered but segregated following triparty collateral transaction."
    )]
    TripartySegregation,

    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as &quot;NOMC&quot;.
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("_ZN-JcNp-Ed-ak6NoX_4Aeg_-772708128")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim,

    /// <summary>
    /// Transaction resulting from a transformation.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("__Um1QOEAEd-udr336SN7mQ")]
    [Description(@"Transaction resulting from a transformation.")]
    Transformation,

    /// <summary>
    /// Collateral position is available for other purposes (for example, onwards delivery).
    /// Encoded/decoded by serializers as &quot;RHYP&quot;.
    /// </summary>
    [EnumMember(Value = "RHYP")]
    [IsoId("_3NA_cOZYEd-q8fx_Zl_34A")]
    [Description(
        @"Collateral position is available for other purposes (for example, onwards delivery)."
    )]
    Rehypothecation,

    /// <summary>
    /// Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Y2qUOUAtEeCObp7JtQfOGg")]
    [Description(
        @"Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline."
    )]
    AcceptAfterRegularSettlementDeadline,

    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_aMaEJ_vzEeC5cppCUzSD9A")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting,

    /// <summary>
    /// Security transaction is not for accounting.
    /// Encoded/decoded by serializers as &quot;NACT&quot;.
    /// </summary>
    [EnumMember(Value = "NACT")]
    [IsoId("_zgyVEGXnEeWsrOWU209RUg")]
    [Description(@"Security transaction is not for accounting.")]
    NotAccountingRelated,

    /// <summary>
    /// The instruction was settled by the settlement internaliser/account servicer (eg custodian) in its own books and not through a securities settlement system (e.g. CSD system).
    /// Encoded/decoded by serializers as &quot;INTS&quot;.
    /// </summary>
    [EnumMember(Value = "INTS")]
    [IsoId("_tz31UAllEeuQ1MenzX1l-g")]
    [Description(
        @"The instruction was settled by the settlement internaliser/account servicer (eg custodian) in its own books and not through a securities settlement system (e.g. CSD system)."
    )]
    InternalisedSettlement,

    /// <summary>
    /// Identification of settlement instructions created as a result of a partial successful buy-in.
    /// Encoded/decoded by serializers as &quot;BPSS&quot;.
    /// </summary>
    [EnumMember(Value = "BPSS")]
    [IsoId("_I7JNoAzUEeuTPv2wqaotHg")]
    [Description(
        @"Identification of settlement instructions created as a result of a partial successful buy-in."
    )]
    PartialSuccessfulBuyIn,
}
