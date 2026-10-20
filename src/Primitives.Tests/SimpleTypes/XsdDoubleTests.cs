// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdDoubleTests : SimpleValueXsdFloatingPointContractTests<XsdDouble, double>
{
    protected override double FiniteSample => 42.5;
    protected override string FiniteSampleWireText => "42.5";
    protected override double PositiveInfinitySample => double.PositiveInfinity;
    protected override double NegativeInfinitySample => double.NegativeInfinity;
    protected override double NaNSample => double.NaN;
}
