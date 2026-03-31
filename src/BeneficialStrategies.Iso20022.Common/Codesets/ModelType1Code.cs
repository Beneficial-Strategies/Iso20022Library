// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Categorisation of margin models used by central counterparties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mRl-ILC2EeaSl6vJk5Bd8w")]
[Description(@"Categorisation of margin models used by central counterparties.")]
[DerivedFrom(typeof(ModelTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ModelType1Code>))]
#endif
public enum ModelType1Code
{
    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposures whereby the model estimates the expected loss of a portfolio over a given holding period, or margin period of risk, to a set confidence interval.
    /// Encoded/decoded by serializers as &quot;EXPS&quot;.
    /// </summary>
    [EnumMember(Value = "EXPS")]
    [IsoId("_oGOkgbC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposures whereby the model estimates the expected loss of a portfolio over a given holding period, or margin period of risk, to a set confidence interval."
    )]
    ExpectedShortfall = ModelTypeCode.ExpectedShortfall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposures that is not classified by any other the model type code.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_oM7CYbC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposures that is not classified by any other the model type code."
    )]
    Other = ModelTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin model used to calculate collateral requirements where the total collateral requirement to cover potential future exposures for a portfolio is an aggregation of the estimated potential future exposure on each financial instrument of that portfolio. Such the methodology for such aggregation is defined explicitly by the model itself.
    /// Encoded/decoded by serializers as &quot;ORIA&quot;.
    /// </summary>
    [EnumMember(Value = "ORIA")]
    [IsoId("_oSISgbC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements where the total collateral requirement to cover potential future exposures for a portfolio is an aggregation of the estimated potential future exposure on each financial instrument of that portfolio. Such the methodology for such aggregation is defined explicitly by the model itself."
    )]
    OtherRiskAggregation = ModelTypeCode.OtherRiskAggregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposure developed by CME in the 1980s, or other derivatives thereof.
    /// Encoded/decoded by serializers as &quot;SPAN&quot;.
    /// </summary>
    [EnumMember(Value = "SPAN")]
    [IsoId("_okRycbC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposure developed by CME in the 1980s, or other derivatives thereof."
    )]
    Span = ModelTypeCode.Span, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposure whereby the model estimates the potential loss of a portfolio over a given holding period, or margin period of risk, to a given confidence interval.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_oqYacbC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposure whereby the model estimates the potential loss of a portfolio over a given holding period, or margin period of risk, to a given confidence interval."
    )]
    ValueAtRisk = ModelTypeCode.ValueAtRisk, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scenario analysis model other than SPAN.
    /// Encoded/decoded by serializers as &quot;SAMO&quot;.
    /// </summary>
    [EnumMember(Value = "SAMO")]
    [IsoId("_g2MMUTW1EemdWfjs3tykFQ")]
    [Description(@"Scenario analysis model other than SPAN.")]
    ScenarioAnalysisModel = ModelTypeCode.ScenarioAnalysisModel, // same ordinal as derivation source for type conversions
}
