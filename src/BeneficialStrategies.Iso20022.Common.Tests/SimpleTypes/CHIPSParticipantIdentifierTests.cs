// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class CHIPSParticipantIdentifierTests : SimpleValueStringContractTests<CHIPSParticipantIdentifier>
{
    protected override string ValidSample   => "CP1234";
    protected override string InvalidSample => "XX1234";
}
