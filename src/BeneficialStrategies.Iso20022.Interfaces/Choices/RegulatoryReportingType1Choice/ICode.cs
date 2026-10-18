// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice;

/// <summary>Specifies the code.</summary>
[IsoId("_rJAakHeLEfCdoODv2ypKfw")]
public interface ICode : IRegulatoryReportingType1Choice, IIsoChoiceVariant
{
    /// <summary>Contains the main value for the container.</summary>
    [IsoXmlTag("Cd")]
    ExternalRegulatoryReportingType1Code Value { get; }
}
