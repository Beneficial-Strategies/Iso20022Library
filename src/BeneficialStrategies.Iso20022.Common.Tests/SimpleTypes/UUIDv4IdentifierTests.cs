// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class UUIDv4IdentifierTests : SimpleValueStringContractTests<UUIDv4Identifier>
{
    protected override string ValidSample => "550e8400-e29b-41d4-a716-446655440000";
    protected override string InvalidSample => "not-a-uuid";
}
