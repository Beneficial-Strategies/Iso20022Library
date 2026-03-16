// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type used for the calculation of the valuation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uSTAcPP4EeS_qLctCs2aRQ")]
[Description(@"Specifies the type used for the calculation of the valuation.")]
[DerivedFrom(typeof(ValuationTypeCode))]
public enum ValuationType1Code
{
    /// <summary>
    /// Central counterparty (CCP) valuation.
    /// Encoded/decoded by serializers as &quot;CCPV&quot;.
    /// </summary>
    [EnumMember(Value = "CCPV")]
    [IsoId("_wGC2AfP4EeS_qLctCs2aRQ")]
    [Description(@"Central counterparty (CCP) valuation.")]
    CCPValuation = ValuationTypeCode.CCPValuation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mark to market valuation.
    /// Encoded/decoded by serializers as &quot;MTMA&quot;.
    /// </summary>
    [EnumMember(Value = "MTMA")]
    [IsoId("_wQAqUfP4EeS_qLctCs2aRQ")]
    [Description(@"Mark to market valuation.||")]
    MarkToMarket = ValuationTypeCode.MarkToMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mark to model valuation.
    /// Encoded/decoded by serializers as &quot;MTMO&quot;.
    /// </summary>
    [EnumMember(Value = "MTMO")]
    [IsoId("_wbndY_P4EeS_qLctCs2aRQ")]
    [Description(@"Mark to model valuation.|")]
    MarkToModel = ValuationTypeCode.MarkToModel, // same ordinal as derivation source for type conversions
}
