// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice;

/// <summary>Specifies the proprietary value.</summary>
[IsoId("_75HhwHeLEfCdoODv2ypKfw")]
public interface IProprietary : IRegulatoryReportingType1Choice, IIsoChoiceVariant
{
    /// <summary>Contains the main value for the container.</summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
