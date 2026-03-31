// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties32Choice
{
    /// <summary>
    /// Legal entity identifier of the central securities depository participant involved in the transaction.
    /// </summary>
    [IsoId("_Az7-8bQ0EemI67HK7aviyg")]
    [DisplayName("Central Securities Depository Participant")]
    public record CentralSecuritiesDepositoryParticipant : SettlementParties32Choice_ { }
}
