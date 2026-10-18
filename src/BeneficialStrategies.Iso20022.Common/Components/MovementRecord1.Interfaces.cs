// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MovementRecord1 : IMovementRecord1
{
    IAmountAndDirection5 IMovementRecord1.Amount => Amount;
    IPartyIdentification135? IMovementRecord1.SettlementAgent => SettlementAgent;
    ICashAccount40? IMovementRecord1.SettlementAgentAccount => SettlementAgentAccount;
    IPartyIdentification135? IMovementRecord1.Participant => Participant;
    ICashAccount40? IMovementRecord1.ParticipantAccount => ParticipantAccount;
}
