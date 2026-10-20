// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdFloatTests : SimpleValueXsdFloatingPointContractTests<XsdFloat, float>
{
    protected override float FiniteSample => 42.5f;
    protected override string FiniteSampleWireText => "42.5";
    protected override float PositiveInfinitySample => float.PositiveInfinity;
    protected override float NegativeInfinitySample => float.NegativeInfinity;
    protected override float NaNSample => float.NaN;
}
