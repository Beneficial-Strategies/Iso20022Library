// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    [IsoId("_yJhSp4v-Eei289CGNqs21g")]
    [DisplayName("Technical Address")]
    public record TechnicalAddress : SystemPartyModification2Choice_ { }
}
