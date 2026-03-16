// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName2Choice
{
    /// <summary>
    /// Name of the identification scheme, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_WgN0RRBBEeGyZLI6olyk-Q")]
    [DisplayName("Code")]
    public record Code : OrganisationIdentificationSchemeName2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalOrganisationIdentification1Code Value { get; init; }
    }
}
