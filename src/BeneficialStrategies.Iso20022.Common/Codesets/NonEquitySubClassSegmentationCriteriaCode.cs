// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Criteria used to segment classes of non-equity instruments into sub classes as per local regulation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qDY5UGkfEeqf6OGS6ti91w")]
[Description(
    @"Criteria used to segment classes of non-equity instruments into sub classes as per local regulation."
)]
[Derivations(typeof(NonEquitySubClassSegmentationCriteria1Code))]
public enum NonEquitySubClassSegmentationCriteriaCode
{
    /// <summary>
    /// Sub-asset class.
    /// Encoded/decoded by serializers as &quot;SACL&quot;.
    /// </summary>
    [EnumMember(Value = "SACL")]
    [IsoId("_9tdQMGkfEeqf6OGS6ti91w")]
    [Description(@"Sub-asset class.")]
    SubAssetClass,

    /// <summary>
    /// Time to maturity bucket.
    /// Encoded/decoded by serializers as &quot;TTMB&quot;.
    /// </summary>
    [EnumMember(Value = "TTMB")]
    [IsoId("_ogEP8GkgEeqf6OGS6ti91w")]
    [Description(@"Time to maturity bucket.")]
    TimeToMaturityBucket,

    /// <summary>
    /// Time to maturity bucket of the option.
    /// Encoded/decoded by serializers as &quot;TTMO&quot;.
    /// </summary>
    [EnumMember(Value = "TTMO")]
    [IsoId("_rzkBAGkgEeqf6OGS6ti91w")]
    [Description(@"Time to maturity bucket of the option.")]
    OptionTimeToMaturityBucket,

    /// <summary>
    /// Time to maturity bucket of the swap.
    /// Encoded/decoded by serializers as &quot;TTMS&quot;.
    /// </summary>
    [EnumMember(Value = "TTMS")]
    [IsoId("_r1hv4GkgEeqf6OGS6ti91w")]
    [Description(@"Time to maturity bucket of the swap.")]
    SwapTimeToMaturityBucket,

    /// <summary>
    /// Underlying instrument identification, such as an ISIN code.
    /// Encoded/decoded by serializers as &quot;UINS&quot;.
    /// </summary>
    [EnumMember(Value = "UINS")]
    [IsoId("_102fwGkgEeqf6OGS6ti91w")]
    [Description(@"Underlying instrument identification, such as an ISIN code.")]
    UnderlyingInstrumentIdentification,

    /// <summary>
    /// Issuer of the underlying bond.
    /// Encoded/decoded by serializers as &quot;IOUB&quot;.
    /// </summary>
    [EnumMember(Value = "IOUB")]
    [IsoId("_8VPqoGkgEeqf6OGS6ti91w")]
    [Description(@"Issuer of the underlying bond.")]
    UnderlyingBondIssuer,

    /// <summary>
    /// Underlying interest rate.
    /// Encoded/decoded by serializers as &quot;UIRT&quot;.
    /// </summary>
    [EnumMember(Value = "UIRT")]
    [IsoId("_S5kMIGkhEeqf6OGS6ti91w")]
    [Description(@"Underlying interest rate.")]
    UnderlyingInterestRate,

    /// <summary>
    /// Term of the underlying bond.
    /// Encoded/decoded by serializers as &quot;TOUB&quot;.
    /// </summary>
    [EnumMember(Value = "TOUB")]
    [IsoId("_UCT84GkhEeqf6OGS6ti91w")]
    [Description(@"Term of the underlying bond.")]
    UnderlyingBondTerm,

    /// <summary>
    /// Asset class.
    /// Encoded/decoded by serializers as &quot;ASCL&quot;.
    /// </summary>
    [EnumMember(Value = "ASCL")]
    [IsoId("_Dk4k4G52EeqChceapNqdqQ")]
    [Description(@"Asset class.")]
    AssetClass,

    /// <summary>
    /// Underlying index identification such as an ISIN or an index name.
    /// Encoded/decoded by serializers as &quot;UIDX&quot;.
    /// </summary>
    [EnumMember(Value = "UIDX")]
    [IsoId("_xbe04G6IEeqTXeGPLsqb_w")]
    [Description(@"Underlying index identification such as an ISIN or an index name.")]
    UnderlyingIndexIdentification,

    /// <summary>
    /// Interest rate term of contract.
    /// Encoded/decoded by serializers as &quot;IRTC&quot;.
    /// </summary>
    [EnumMember(Value = "IRTC")]
    [IsoId("_6JxasG6IEeqTXeGPLsqb_w")]
    [Description(@"Interest rate term of contract.")]
    InterestRateTermOfContract,

    /// <summary>
    /// Underlying reference entity.
    /// Encoded/decoded by serializers as &quot;REOU&quot;.
    /// </summary>
    [EnumMember(Value = "REOU")]
    [IsoId("_9gVt4G6IEeqTXeGPLsqb_w")]
    [Description(@"Underlying reference entity.")]
    UnderlyingReferenceEntity,

    /// <summary>
    /// Issuer of sovereign and public type.
    /// Encoded/decoded by serializers as &quot;ISPT&quot;.
    /// </summary>
    [EnumMember(Value = "ISPT")]
    [IsoId("_X3Ms4G6JEeqTXeGPLsqb_w")]
    [Description(@"Issuer of sovereign and public type.")]
    SovereignAndPublicTypeIssuer,

    /// <summary>
    /// Interest rate derivative notional currency 1.
    /// Encoded/decoded by serializers as &quot;INC1&quot;.
    /// </summary>
    [EnumMember(Value = "INC1")]
    [IsoId("_eKAuwG6JEeqTXeGPLsqb_w")]
    [Description(@"Interest rate derivative notional currency 1.")]
    IRDNotionalCurrency1,

    /// <summary>
    /// Foreign exchange derivative notional currency 1.
    /// Encoded/decoded by serializers as &quot;FNC1&quot;.
    /// </summary>
    [EnumMember(Value = "FNC1")]
    [IsoId("_72wrgG6JEeqTXeGPLsqb_w")]
    [Description(@"Foreign exchange derivative notional currency 1.")]
    FEXNotionalCurrency1,

    /// <summary>
    /// Contract for difference notional currency 1.
    /// Encoded/decoded by serializers as &quot;CNC1&quot;.
    /// </summary>
    [EnumMember(Value = "CNC1")]
    [IsoId("_WyeEAG6KEeqTXeGPLsqb_w")]
    [Description(@"Contract for difference notional currency 1.")]
    CFDNotionalCurrency1,

    /// <summary>
    /// Foreign exchange derivative notional currency 2.
    /// Encoded/decoded by serializers as &quot;FNC2&quot;.
    /// </summary>
    [EnumMember(Value = "FNC2")]
    [IsoId("_58YNAG6KEeqTXeGPLsqb_w")]
    [Description(@"Foreign exchange derivative notional currency 2.")]
    FEXNotionalCurrency2,

    /// <summary>
    /// Interest rate derivative notional currency 2.
    /// Encoded/decoded by serializers as &quot;INC2&quot;.
    /// </summary>
    [EnumMember(Value = "INC2")]
    [IsoId("_-LqQ4G6KEeqTXeGPLsqb_w")]
    [Description(@"Interest rate derivative notional currency 2.")]
    IRDNotionalCurrency2,

    /// <summary>
    /// Contract for difference notional currency 2.
    /// Encoded/decoded by serializers as &quot;CNC2&quot;.
    /// </summary>
    [EnumMember(Value = "CNC2")]
    [IsoId("_BkKdwG6LEeqTXeGPLsqb_w")]
    [Description(@"Contract for difference notional currency 2.")]
    CFDNotionalCurrency2,

    /// <summary>
    /// Notional currency of the swaption.
    /// Encoded/decoded by serializers as &quot;NCSW&quot;.
    /// </summary>
    [EnumMember(Value = "NCSW")]
    [IsoId("_HUF1AG6LEeqTXeGPLsqb_w")]
    [Description(@"Notional currency of the swaption.")]
    SwaptionNotionalCurrency,

    /// <summary>
    /// Credit derivative notional currency.
    /// Encoded/decoded by serializers as &quot;NCCR&quot;.
    /// </summary>
    [EnumMember(Value = "NCCR")]
    [IsoId("_Hvq9wG6LEeqTXeGPLsqb_w")]
    [Description(@"Credit derivative notional currency.")]
    CreditNotionalCurrency,

    /// <summary>
    /// Commodity derivative notional currency.
    /// Encoded/decoded by serializers as &quot;NCCO&quot;.
    /// </summary>
    [EnumMember(Value = "NCCO")]
    [IsoId("_YvKkwG6LEeqTXeGPLsqb_w")]
    [Description(@"Commodity derivative notional currency.")]
    CommodityNotionalCurrency,

    /// <summary>
    /// Contract type.
    /// Encoded/decoded by serializers as &quot;CTYP&quot;.
    /// </summary>
    [EnumMember(Value = "CTYP")]
    [IsoId("_dcJRQG6LEeqTXeGPLsqb_w")]
    [Description(@"Contract type.")]
    ContractType,

    /// <summary>
    /// Base product.
    /// Encoded/decoded by serializers as &quot;BSPD&quot;.
    /// </summary>
    [EnumMember(Value = "BSPD")]
    [IsoId("_kPZGsG6LEeqTXeGPLsqb_w")]
    [Description(@"Base product.")]
    BaseProduct,

    /// <summary>
    /// Sub product.
    /// Encoded/decoded by serializers as &quot;SBPD&quot;.
    /// </summary>
    [EnumMember(Value = "SBPD")]
    [IsoId("_qZRPAG6LEeqTXeGPLsqb_w")]
    [Description(@"Sub product.")]
    SubProduct,

    /// <summary>
    /// Further sub product.
    /// Encoded/decoded by serializers as &quot;FSPD&quot;.
    /// </summary>
    [EnumMember(Value = "FSPD")]
    [IsoId("_yCr3cG6LEeqTXeGPLsqb_w")]
    [Description(@"Further sub product.")]
    FurtherSubProduct,

    /// <summary>
    /// Delivery cash settlement location.
    /// Encoded/decoded by serializers as &quot;DCSL&quot;.
    /// </summary>
    [EnumMember(Value = "DCSL")]
    [IsoId("_0TPk0G6LEeqTXeGPLsqb_w")]
    [Description(@"Delivery cash settlement location.")]
    DeliveryCashLocation,

    /// <summary>
    /// Delivery settlement type.
    /// Encoded/decoded by serializers as &quot;DTYP&quot;.
    /// </summary>
    [EnumMember(Value = "DTYP")]
    [IsoId("_5fFXkG6LEeqTXeGPLsqb_w")]
    [Description(@"Delivery settlement type.")]
    DeliverySettlementType,

    /// <summary>
    /// Size specification related to freight subtype.
    /// Encoded/decoded by serializers as &quot;SSRF&quot;.
    /// </summary>
    [EnumMember(Value = "SSRF")]
    [IsoId("_QEl58G6OEeqTXeGPLsqb_w")]
    [Description(@"Size specification related to freight subtype.")]
    SizeSpecificationRelatedToFreightSubtype,

    /// <summary>
    /// Specific route time charter average.
    /// Encoded/decoded by serializers as &quot;SRTC&quot;.
    /// </summary>
    [EnumMember(Value = "SRTC")]
    [IsoId("_Xgfq0G6OEeqTXeGPLsqb_w")]
    [Description(@"Specific route time charter average.")]
    SpecificRouteTimeCharterAverage,

    /// <summary>
    /// Equity derivative underlying type.
    /// Encoded/decoded by serializers as &quot;EQUT&quot;.
    /// </summary>
    [EnumMember(Value = "EQUT")]
    [IsoId("_igOu0G6OEeqTXeGPLsqb_w")]
    [Description(@"Equity derivative underlying type.")]
    EquityUnderlyingType,

    /// <summary>
    /// Parameter.
    /// Encoded/decoded by serializers as &quot;PRMT&quot;.
    /// </summary>
    [EnumMember(Value = "PRMT")]
    [IsoId("_4fjs4G6OEeqTXeGPLsqb_w")]
    [Description(@"Parameter.")]
    Parameter,

    /// <summary>
    /// Inflation index code or name.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_iQNgYG6PEeqTXeGPLsqb_w")]
    [Description(@"Inflation index code or name.")]
    InflationIndexCodeName,

    /// <summary>
    /// Instrument identification.
    /// Encoded/decoded by serializers as &quot;ISIN&quot;.
    /// </summary>
    [EnumMember(Value = "ISIN")]
    [IsoId("_PMaC0G6QEeqTXeGPLsqb_w")]
    [Description(@"Instrument identification.")]
    ISIN,

    /// <summary>
    /// Sub class of the underlying index credit default swap (CDS).
    /// Encoded/decoded by serializers as &quot;UISC&quot;.
    /// </summary>
    [EnumMember(Value = "UISC")]
    [IsoId("_NUtE4G6REeqTXeGPLsqb_w")]
    [Description(@"Sub class of the underlying index credit default swap (CDS).")]
    UnderlyingIndexCDSSubClassIdentification,

    /// <summary>
    /// Underlying type.
    /// Encoded/decoded by serializers as &quot;UTYP&quot;.
    /// </summary>
    [EnumMember(Value = "UTYP")]
    [IsoId("_bll6QG-GEeqI8dOxSar9sQ")]
    [Description(@"Underlying type.")]
    UnderlyingType,
}
