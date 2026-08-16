// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class QUICKIdentifierTests : SimpleValueStringContractTests<QUICKIdentifier>
{
    protected override string ValidSample => "1301";
    protected override string InvalidSample => "";
}
