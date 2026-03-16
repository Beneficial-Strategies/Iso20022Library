// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties34Choice
{
    /// <summary>
    /// Identification of the central securities depository participant involved in the transaction.
    /// </summary>
    [IsoId("_viBlUcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Central Securities Depository Participant")]
    public record CentralSecuritiesDepositoryParticipant : SettlementParties34Choice_ { }
}
