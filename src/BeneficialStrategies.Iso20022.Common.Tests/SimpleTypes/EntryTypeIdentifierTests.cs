// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class EntryTypeIdentifierTests : SimpleValueStringContractTests<EntryTypeIdentifier>
{
    protected override string ValidSample => "B01";
    protected override string InvalidSample => "A01";
}
