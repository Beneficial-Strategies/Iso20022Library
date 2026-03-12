// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementParties32Choice
{
    /// <summary>
    /// Legal entity identifier of the indirect participant of the reporting counterparty involved in the transaction.
    /// </summary>
    [IsoId("_Az7-87Q0EemI67HK7aviyg")]
    [DisplayName("Indirect Participant")]
    public partial record IndirectParticipant : SettlementParties32Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
