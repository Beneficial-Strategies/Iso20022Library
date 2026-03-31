// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the price report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bJkrQBl9EeKxsrht2duUcg")]
[Description(@"Specifies the function of the price report.")]
[Derivations(typeof(PriceReportFunction1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PriceReportFunctionCode>))]
#endif
public enum PriceReportFunctionCode
{
    /// <summary>
    /// The price report is ‘new’, that is the report is not being used as a correction of previously sent prices.
    /// Encoded/decoded by serializers as &quot;NEWP&quot;.
    /// </summary>
    [EnumMember(Value = "NEWP")]
    [IsoId("_gOSiUBl9EeKxsrht2duUcg")]
    [Description(
        @"The price report is ‘new’, that is the report is not being used as a correction of previously sent prices."
    )]
    NewPriceReport,

    /// <summary>
    /// The price report conveys the correction of the complete set of prices previously sent for the same price report identification.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_gXEq4Bl9EeKxsrht2duUcg")]
    [Description(
        @"The price report conveys the correction of the complete set of prices previously sent for the same price report identification."
    )]
    CompleteReplacementPriceReport,

    /// <summary>
    /// The price report conveys the correction of some of the prices previously sent for the same price report identification.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_gfRkoBl9EeKxsrht2duUcg")]
    [Description(
        @"The price report conveys the correction of some of the prices previously sent for the same price report identification."
    )]
    PartialCorrectionPriceReport,
}
