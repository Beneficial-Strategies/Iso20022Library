// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MovementRecord2 : IMovementRecord2
{
    IAmountAndDirection5 IMovementRecord2.Amount => Amount;
    IPartyIdentification272? IMovementRecord2.Participant => Participant;
    ICashAccount40? IMovementRecord2.ParticipantAccount => ParticipantAccount;
    IPartyIdentification272? IMovementRecord2.SettlementAgent => SettlementAgent;
    ICashAccount40? IMovementRecord2.SettlementAgentAccount => SettlementAgentAccount;
}
