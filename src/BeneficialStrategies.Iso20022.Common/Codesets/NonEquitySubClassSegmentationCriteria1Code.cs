// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Criteria used to segment classes of non-equity instruments into sub classes as per local regulation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AyeSgIMNEeq-_7a8Z6CuPA")]
[Description(
    @"Criteria used to segment classes of non-equity instruments into sub classes as per local regulation."
)]
[DerivedFrom(typeof(NonEquitySubClassSegmentationCriteriaCode))]
public enum NonEquitySubClassSegmentationCriteria1Code
{
    /// <summary>
    /// Asset class.
    /// Encoded/decoded by serializers as &quot;ASCL&quot;.
    /// </summary>
    [EnumMember(Value = "ASCL")]
    [IsoId("_DWfucYMNEeq-_7a8Z6CuPA")]
    [Description(@"Asset class.")]
    AssetClass = NonEquitySubClassSegmentationCriteriaCode.AssetClass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Base product.
    /// Encoded/decoded by serializers as &quot;BSPD&quot;.
    /// </summary>
    [EnumMember(Value = "BSPD")]
    [IsoId("_DtbnwYMNEeq-_7a8Z6CuPA")]
    [Description(@"Base product.")]
    BaseProduct = NonEquitySubClassSegmentationCriteriaCode.BaseProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract for difference notional currency 1.
    /// Encoded/decoded by serializers as &quot;CNC1&quot;.
    /// </summary>
    [EnumMember(Value = "CNC1")]
    [IsoId("_DxSNAYMNEeq-_7a8Z6CuPA")]
    [Description(@"Contract for difference notional currency 1.")]
    CFDNotionalCurrency1 = NonEquitySubClassSegmentationCriteriaCode.CFDNotionalCurrency1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract for difference notional currency 2.
    /// Encoded/decoded by serializers as &quot;CNC2&quot;.
    /// </summary>
    [EnumMember(Value = "CNC2")]
    [IsoId("_Dz5cIYMNEeq-_7a8Z6CuPA")]
    [Description(@"Contract for difference notional currency 2.")]
    CFDNotionalCurrency2 = NonEquitySubClassSegmentationCriteriaCode.CFDNotionalCurrency2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity derivative notional currency.
    /// Encoded/decoded by serializers as &quot;NCCO&quot;.
    /// </summary>
    [EnumMember(Value = "NCCO")]
    [IsoId("_D2h5YYMNEeq-_7a8Z6CuPA")]
    [Description(@"Commodity derivative notional currency.")]
    CommodityNotionalCurrency = NonEquitySubClassSegmentationCriteriaCode.CommodityNotionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract type.
    /// Encoded/decoded by serializers as &quot;CTYP&quot;.
    /// </summary>
    [EnumMember(Value = "CTYP")]
    [IsoId("_D5GFMYMNEeq-_7a8Z6CuPA")]
    [Description(@"Contract type.")]
    ContractType = NonEquitySubClassSegmentationCriteriaCode.ContractType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit derivative notional currency.
    /// Encoded/decoded by serializers as &quot;NCCR&quot;.
    /// </summary>
    [EnumMember(Value = "NCCR")]
    [IsoId("_D7mmoYMNEeq-_7a8Z6CuPA")]
    [Description(@"Credit derivative notional currency.")]
    CreditNotionalCurrency = NonEquitySubClassSegmentationCriteriaCode.CreditNotionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery cash settlement location.
    /// Encoded/decoded by serializers as &quot;DCSL&quot;.
    /// </summary>
    [EnumMember(Value = "DCSL")]
    [IsoId("_D-F58YMNEeq-_7a8Z6CuPA")]
    [Description(@"Delivery cash settlement location.")]
    DeliveryCashLocation = NonEquitySubClassSegmentationCriteriaCode.DeliveryCashLocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery settlement type.
    /// Encoded/decoded by serializers as &quot;DTYP&quot;.
    /// </summary>
    [EnumMember(Value = "DTYP")]
    [IsoId("_EAg70YMNEeq-_7a8Z6CuPA")]
    [Description(@"Delivery settlement type.")]
    DeliverySettlementType = NonEquitySubClassSegmentationCriteriaCode.DeliverySettlementType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity derivative underlying type.
    /// Encoded/decoded by serializers as &quot;EQUT&quot;.
    /// </summary>
    [EnumMember(Value = "EQUT")]
    [IsoId("_ECtUMYMNEeq-_7a8Z6CuPA")]
    [Description(@"Equity derivative underlying type.")]
    EquityUnderlyingType = NonEquitySubClassSegmentationCriteriaCode.EquityUnderlyingType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Foreign exchange derivative notional currency 1.
    /// Encoded/decoded by serializers as &quot;FNC1&quot;.
    /// </summary>
    [EnumMember(Value = "FNC1")]
    [IsoId("_EFKyUYMNEeq-_7a8Z6CuPA")]
    [Description(@"Foreign exchange derivative notional currency 1.")]
    FEXNotionalCurrency1 = NonEquitySubClassSegmentationCriteriaCode.FEXNotionalCurrency1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Foreign exchange derivative notional currency 2.
    /// Encoded/decoded by serializers as &quot;FNC2&quot;.
    /// </summary>
    [EnumMember(Value = "FNC2")]
    [IsoId("_EL-k8YMNEeq-_7a8Z6CuPA")]
    [Description(@"Foreign exchange derivative notional currency 2.")]
    FEXNotionalCurrency2 = NonEquitySubClassSegmentationCriteriaCode.FEXNotionalCurrency2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further sub product.
    /// Encoded/decoded by serializers as &quot;FSPD&quot;.
    /// </summary>
    [EnumMember(Value = "FSPD")]
    [IsoId("_ENg2AYMNEeq-_7a8Z6CuPA")]
    [Description(@"Further sub product.")]
    FurtherSubProduct = NonEquitySubClassSegmentationCriteriaCode.FurtherSubProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inflation index code or name.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_EOu-AYMNEeq-_7a8Z6CuPA")]
    [Description(@"Inflation index code or name.")]
    InflationIndexCodeName = NonEquitySubClassSegmentationCriteriaCode.InflationIndexCodeName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest rate term of contract.
    /// Encoded/decoded by serializers as &quot;IRTC&quot;.
    /// </summary>
    [EnumMember(Value = "IRTC")]
    [IsoId("_EP8e8YMNEeq-_7a8Z6CuPA")]
    [Description(@"Interest rate term of contract.")]
    InterestRateTermOfContract =
        NonEquitySubClassSegmentationCriteriaCode.InterestRateTermOfContract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest rate derivative notional currency 1.
    /// Encoded/decoded by serializers as &quot;INC1&quot;.
    /// </summary>
    [EnumMember(Value = "INC1")]
    [IsoId("_ER2jcYMNEeq-_7a8Z6CuPA")]
    [Description(@"Interest rate derivative notional currency 1.")]
    IRDNotionalCurrency1 = NonEquitySubClassSegmentationCriteriaCode.IRDNotionalCurrency1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest rate derivative notional currency 2.
    /// Encoded/decoded by serializers as &quot;INC2&quot;.
    /// </summary>
    [EnumMember(Value = "INC2")]
    [IsoId("_EUZhIYMNEeq-_7a8Z6CuPA")]
    [Description(@"Interest rate derivative notional currency 2.")]
    IRDNotionalCurrency2 = NonEquitySubClassSegmentationCriteriaCode.IRDNotionalCurrency2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instrument identification.
    /// Encoded/decoded by serializers as &quot;ISIN&quot;.
    /// </summary>
    [EnumMember(Value = "ISIN")]
    [IsoId("_EW8e0YMNEeq-_7a8Z6CuPA")]
    [Description(@"Instrument identification.")]
    ISIN = NonEquitySubClassSegmentationCriteriaCode.ISIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time to maturity bucket of the option.
    /// Encoded/decoded by serializers as &quot;TTMO&quot;.
    /// </summary>
    [EnumMember(Value = "TTMO")]
    [IsoId("_EZljIYMNEeq-_7a8Z6CuPA")]
    [Description(@"Time to maturity bucket of the option.")]
    OptionTimeToMaturityBucket =
        NonEquitySubClassSegmentationCriteriaCode.OptionTimeToMaturityBucket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parameter.
    /// Encoded/decoded by serializers as &quot;PRMT&quot;.
    /// </summary>
    [EnumMember(Value = "PRMT")]
    [IsoId("_Eb7FcYMNEeq-_7a8Z6CuPA")]
    [Description(@"Parameter.")]
    Parameter = NonEquitySubClassSegmentationCriteriaCode.Parameter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Size specification related to freight subtype.
    /// Encoded/decoded by serializers as &quot;SSRF&quot;.
    /// </summary>
    [EnumMember(Value = "SSRF")]
    [IsoId("_EeeDIYMNEeq-_7a8Z6CuPA")]
    [Description(@"Size specification related to freight subtype.")]
    SizeSpecificationRelatedToFreightSubtype =
        NonEquitySubClassSegmentationCriteriaCode.SizeSpecificationRelatedToFreightSubtype, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer of sovereign and public type.
    /// Encoded/decoded by serializers as &quot;ISPT&quot;.
    /// </summary>
    [EnumMember(Value = "ISPT")]
    [IsoId("_Eg66MYMNEeq-_7a8Z6CuPA")]
    [Description(@"Issuer of sovereign and public type.")]
    SovereignAndPublicTypeIssuer =
        NonEquitySubClassSegmentationCriteriaCode.SovereignAndPublicTypeIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specific route time charter average.
    /// Encoded/decoded by serializers as &quot;SRTC&quot;.
    /// </summary>
    [EnumMember(Value = "SRTC")]
    [IsoId("_EjS4wYMNEeq-_7a8Z6CuPA")]
    [Description(@"Specific route time charter average.")]
    SpecificRouteTimeCharterAverage =
        NonEquitySubClassSegmentationCriteriaCode.SpecificRouteTimeCharterAverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sub-asset class.
    /// Encoded/decoded by serializers as &quot;SACL&quot;.
    /// </summary>
    [EnumMember(Value = "SACL")]
    [IsoId("_EmEf8YMNEeq-_7a8Z6CuPA")]
    [Description(@"Sub-asset class.")]
    SubAssetClass = NonEquitySubClassSegmentationCriteriaCode.SubAssetClass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sub product.
    /// Encoded/decoded by serializers as &quot;SBPD&quot;.
    /// </summary>
    [EnumMember(Value = "SBPD")]
    [IsoId("_EopS0YMNEeq-_7a8Z6CuPA")]
    [Description(@"Sub product.")]
    SubProduct = NonEquitySubClassSegmentationCriteriaCode.SubProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time to maturity bucket of the swap.
    /// Encoded/decoded by serializers as &quot;TTMS&quot;.
    /// </summary>
    [EnumMember(Value = "TTMS")]
    [IsoId("_ErhAoYMNEeq-_7a8Z6CuPA")]
    [Description(@"Time to maturity bucket of the swap.")]
    SwapTimeToMaturityBucket = NonEquitySubClassSegmentationCriteriaCode.SwapTimeToMaturityBucket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notional currency of the swaption.
    /// Encoded/decoded by serializers as &quot;NCSW&quot;.
    /// </summary>
    [EnumMember(Value = "NCSW")]
    [IsoId("_EtQGAYMNEeq-_7a8Z6CuPA")]
    [Description(@"Notional currency of the swaption.")]
    SwaptionNotionalCurrency = NonEquitySubClassSegmentationCriteriaCode.SwaptionNotionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time to maturity bucket.
    /// Encoded/decoded by serializers as &quot;TTMB&quot;.
    /// </summary>
    [EnumMember(Value = "TTMB")]
    [IsoId("_Ev4jQYMNEeq-_7a8Z6CuPA")]
    [Description(@"Time to maturity bucket.")]
    TimeToMaturityBucket = NonEquitySubClassSegmentationCriteriaCode.TimeToMaturityBucket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer of the underlying bond.
    /// Encoded/decoded by serializers as &quot;IOUB&quot;.
    /// </summary>
    [EnumMember(Value = "IOUB")]
    [IsoId("_EyKbMYMNEeq-_7a8Z6CuPA")]
    [Description(@"Issuer of the underlying bond.")]
    UnderlyingBondIssuer = NonEquitySubClassSegmentationCriteriaCode.UnderlyingBondIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Term of the underlying bond.
    /// Encoded/decoded by serializers as &quot;TOUB&quot;.
    /// </summary>
    [EnumMember(Value = "TOUB")]
    [IsoId("_E0ogYYMNEeq-_7a8Z6CuPA")]
    [Description(@"Term of the underlying bond.")]
    UnderlyingBondTerm = NonEquitySubClassSegmentationCriteriaCode.UnderlyingBondTerm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sub class of the underlying index credit default swap (CDS).
    /// Encoded/decoded by serializers as &quot;UISC&quot;.
    /// </summary>
    [EnumMember(Value = "UISC")]
    [IsoId("_E3fnIYMNEeq-_7a8Z6CuPA")]
    [Description(@"Sub class of the underlying index credit default swap (CDS).")]
    UnderlyingIndexCDSSubClassIdentification =
        NonEquitySubClassSegmentationCriteriaCode.UnderlyingIndexCDSSubClassIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying index identification such as an ISIN or an index name.
    /// Encoded/decoded by serializers as &quot;UIDX&quot;.
    /// </summary>
    [EnumMember(Value = "UIDX")]
    [IsoId("_E56pAYMNEeq-_7a8Z6CuPA")]
    [Description(@"Underlying index identification such as an ISIN or an index name.")]
    UnderlyingIndexIdentification =
        NonEquitySubClassSegmentationCriteriaCode.UnderlyingIndexIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying instrument identification, such as an ISIN code.
    /// Encoded/decoded by serializers as &quot;UINS&quot;.
    /// </summary>
    [EnumMember(Value = "UINS")]
    [IsoId("_E8ligYMNEeq-_7a8Z6CuPA")]
    [Description(@"Underlying instrument identification, such as an ISIN code.")]
    UnderlyingInstrumentIdentification =
        NonEquitySubClassSegmentationCriteriaCode.UnderlyingInstrumentIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying interest rate.
    /// Encoded/decoded by serializers as &quot;UIRT&quot;.
    /// </summary>
    [EnumMember(Value = "UIRT")]
    [IsoId("_E-1lQYMNEeq-_7a8Z6CuPA")]
    [Description(@"Underlying interest rate.")]
    UnderlyingInterestRate = NonEquitySubClassSegmentationCriteriaCode.UnderlyingInterestRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying reference entity.
    /// Encoded/decoded by serializers as &quot;REOU&quot;.
    /// </summary>
    [EnumMember(Value = "REOU")]
    [IsoId("_FBOx8YMNEeq-_7a8Z6CuPA")]
    [Description(@"Underlying reference entity.")]
    UnderlyingReferenceEntity = NonEquitySubClassSegmentationCriteriaCode.UnderlyingReferenceEntity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying type.
    /// Encoded/decoded by serializers as &quot;UTYP&quot;.
    /// </summary>
    [EnumMember(Value = "UTYP")]
    [IsoId("_FLorIYMNEeq-_7a8Z6CuPA")]
    [Description(@"Underlying type.")]
    UnderlyingType = NonEquitySubClassSegmentationCriteriaCode.UnderlyingType, // same ordinal as derivation source for type conversions
}
