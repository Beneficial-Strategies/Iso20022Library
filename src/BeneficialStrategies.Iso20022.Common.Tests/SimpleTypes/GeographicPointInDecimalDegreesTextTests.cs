// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class GeographicPointInDecimalDegreesTextTests : SimpleValueStringContractTests<GeographicPointInDecimalDegreesText>
{
    protected override string ValidSample => "51.5074/0.1278";
    protected override string InvalidSample => "NOTCOORDS";
}
