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
[IsoId("_0hGmQLC1EeaSl6vJk5Bd8w")]
[Description(@"Categorisation of margin models used by central counterparties.")]
[Derivations(typeof(ModelType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ModelTypeCode>))]
#endif
public enum ModelTypeCode
{
    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposures whereby the model estimates the expected loss of a portfolio over a given holding period, or margin period of risk, to a set confidence interval.
    /// Encoded/decoded by serializers as &quot;EXPS&quot;.
    /// </summary>
    [EnumMember(Value = "EXPS")]
    [IsoId("_7p-tcLC1EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposures whereby the model estimates the expected loss of a portfolio over a given holding period, or margin period of risk, to a set confidence interval."
    )]
    ExpectedShortfall,

    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposure developed by CME in the 1980s, or other derivatives thereof.
    /// Encoded/decoded by serializers as &quot;SPAN&quot;.
    /// </summary>
    [EnumMember(Value = "SPAN")]
    [IsoId("_AliBcLC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposure developed by CME in the 1980s, or other derivatives thereof."
    )]
    Span,

    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposure whereby the model estimates the potential loss of a portfolio over a given holding period, or margin period of risk, to a given confidence interval.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_IaADULC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposure whereby the model estimates the potential loss of a portfolio over a given holding period, or margin period of risk, to a given confidence interval."
    )]
    ValueAtRisk,

    /// <summary>
    /// Margin model used to calculate collateral requirements where the total collateral requirement to cover potential future exposures for a portfolio is an aggregation of the estimated potential future exposure on each financial instrument of that portfolio. Such the methodology for such aggregation is defined explicitly by the model itself.
    /// Encoded/decoded by serializers as &quot;ORIA&quot;.
    /// </summary>
    [EnumMember(Value = "ORIA")]
    [IsoId("_TQ7JkLC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements where the total collateral requirement to cover potential future exposures for a portfolio is an aggregation of the estimated potential future exposure on each financial instrument of that portfolio. Such the methodology for such aggregation is defined explicitly by the model itself."
    )]
    OtherRiskAggregation,

    /// <summary>
    /// Margin model used to calculate collateral requirements to cover potential future exposures that is not classified by any other the model type code.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Zw5dsLC2EeaSl6vJk5Bd8w")]
    [Description(
        @"Margin model used to calculate collateral requirements to cover potential future exposures that is not classified by any other the model type code."
    )]
    Other,

    /// <summary>
    /// Scenario analysis model other than SPAN.
    /// Encoded/decoded by serializers as &quot;SAMO&quot;.
    /// </summary>
    [EnumMember(Value = "SAMO")]
    [IsoId("_Q_rmoDW1EemdWfjs3tykFQ")]
    [Description(@"Scenario analysis model other than SPAN.")]
    ScenarioAnalysisModel,
}
