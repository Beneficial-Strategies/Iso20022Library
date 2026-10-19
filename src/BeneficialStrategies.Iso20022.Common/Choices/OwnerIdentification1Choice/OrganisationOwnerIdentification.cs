// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnerIdentification1Choice
{
    /// <summary>
    /// Identification of an organisation.
    /// </summary>
    [IsoId("_qe1hwwgrEeSqp5OpJ0aMmw")]
    [DisplayName("Organisation Owner Identification")]
    public partial record OrganisationOwnerIdentification : OwnerIdentification1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OrgOwnrId")]
        public required PartyIdentification5Choice_ Value { get; init; }
    }
}
