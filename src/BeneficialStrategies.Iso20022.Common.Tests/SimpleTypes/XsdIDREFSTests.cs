// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdIDREFSTests : SimpleValueStringContractTests<XsdIDREFS>
{
    protected override string ValidSample => "id-1 id-2 id-3";
    protected override string InvalidSample => "1-id id-2"; // first token starts with a digit

    [Fact]
    public void SingleToken_Accepted()
    {
        Assert.True(XsdIDREFS.TryCreate("id-1", out _));
    }
}
