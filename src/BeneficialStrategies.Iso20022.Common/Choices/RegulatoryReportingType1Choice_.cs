// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IRegulatoryReportingType1Choice"/>
    [IsoId("_JVOXAHeLEfCdoODv2ypKfw")]
    [DisplayName("Regulatory Reporting Type 1 Choice")]
    [KnownType(typeof(RegulatoryReportingType1Choice.Code))]
    [KnownType(typeof(RegulatoryReportingType1Choice.Proprietary))]
    [JsonDerivedType(typeof(RegulatoryReportingType1Choice.Code))]
    [JsonDerivedType(typeof(RegulatoryReportingType1Choice.Proprietary))]
    public abstract partial record RegulatoryReportingType1Choice_
    {
    }
}
