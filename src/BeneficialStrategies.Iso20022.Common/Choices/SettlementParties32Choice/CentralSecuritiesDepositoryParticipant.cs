// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementParties32Choice
{
    /// <summary>
    /// Legal entity identifier of the central securities depository participant involved in the transaction.
    /// </summary>
    [IsoId("_Az7-8bQ0EemI67HK7aviyg")]
    [DisplayName("Central Securities Depository Participant")]
    public partial record CentralSecuritiesDepositoryParticipant : SettlementParties32Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
