// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the price report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ABtQoBl-EeKxsrht2duUcg")]
[Description(@"Specifies the function of the price report.")]
[DerivedFrom(typeof(PriceReportFunctionCode))]
public enum PriceReportFunction1Code
{
    /// <summary>
    /// The price report conveys the correction of the complete set of prices previously sent for the same price report identification.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_mYciARl-EeKxsrht2duUcg")]
    [Description(@"The price report conveys the correction of the complete set of prices previously sent for the same price report identification.")]
    CompleteReplacementPriceReport = PriceReportFunctionCode.CompleteReplacementPriceReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The price report is ‘new’, that is the report is not being used as a correction of previously sent prices.
    /// Encoded/decoded by serializers as &quot;NEWP&quot;.
    /// </summary>
    [EnumMember(Value = "NEWP")]
    [IsoId("_mibkcRl-EeKxsrht2duUcg")]
    [Description(@"The price report is ‘new’, that is the report is not being used as a correction of previously sent prices.")]
    NewPriceReport = PriceReportFunctionCode.NewPriceReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The price report conveys the correction of some of the prices previously sent for the same price report identification.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_mrhPARl-EeKxsrht2duUcg")]
    [Description(@"The price report conveys the correction of some of the prices previously sent for the same price report identification.")]
    PartialCorrectionPriceReport = PriceReportFunctionCode.PartialCorrectionPriceReport, // same ordinal as derivation source for type conversions
    
}
