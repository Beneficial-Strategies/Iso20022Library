// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification10Choice
{
    /// <summary>
    /// Unique identification of a counterparty, using a client code or a business identification code.
    /// </summary>
    [IsoId("_IEZpg-9IEemVGdgB8P8uQQ")]
    [DisplayName("Other")]
    public record Other : OrganisationIdentification10Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of the organisation.
        /// </summary>
        [IsoId("_IUQDYe9IEemVGdgB8P8uQQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required GenericIdentification175 Identification { get; init; }

        /// <summary>
        /// Indicates the name of the reporting counterparty.
        /// </summary>
        [IsoId("_IUQDY-9IEemVGdgB8P8uQQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105, MinimumLength = 1)]
        public IsoMax105Text? Name { get; init; }

        /// <summary>
        /// Indicates the domicile of counterparty.
        /// </summary>
        [IsoId("_IUQDZe9IEemVGdgB8P8uQQ")]
        [DisplayName("Domicile")]
        [IsoXmlTag("Dmcl")]
        [IsoSimpleType(IsoSimpleType.Max500Text)]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public IsoMax500Text? Domicile { get; init; }
    }
}
