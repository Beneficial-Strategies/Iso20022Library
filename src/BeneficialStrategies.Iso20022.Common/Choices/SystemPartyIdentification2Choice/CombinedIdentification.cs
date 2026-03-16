// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyIdentification2Choice
{
    /// <summary>
    /// Identifies the party with the combined identification of both the responsible entity and the party itself.
    /// </summary>
    [IsoId("_w8OZg2c-EemvNLufWGIVOQ")]
    [DisplayName("Combined Identification")]
    public record CombinedIdentification : SystemPartyIdentification2Choice_
    {
        /// <summary>
        /// Unique identification to unambiguously identify the party within the system.
        /// </summary>
        [IsoId("_7VYvQVhLEeih3fUfzR38Ig")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification136 Identification { get; init; }

        /// <summary>
        /// Unique identification of the party responsible for the maintenance of the party reference data.
        /// </summary>
        [IsoId("_7VYvQ1hLEeih3fUfzR38Ig")]
        [DisplayName("Responsible Party Identification")]
        [IsoXmlTag("RspnsblPtyId")]
        public PartyIdentification136? ResponsiblePartyIdentification { get; init; }
    }
}
