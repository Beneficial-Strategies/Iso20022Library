// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation1Choice
{
    /// <summary>
    /// Identification of a person.
    /// </summary>
    [IsoId("_z1JLgPPYEeS_qLctCs2aRQ")]
    [DisplayName("Person")]
    [IsoXmlTag("Prsn")]
    public record Person : PersonOrOrganisation1Choice_
    {
        /// <summary>
        /// First name of a person (also known as given name).
        /// </summary>
        [IsoId("_AifA0vPZEeS_qLctCs2aRQ")]
        [DisplayName("First Name")]
        [IsoXmlTag("FrstNm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text FirstName { get; init; }

        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_AifA0_PZEeS_qLctCs2aRQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text Name { get; init; }

        /// <summary>
        /// Date on which a person is born.
        /// </summary>
        [IsoId("_BzRTQfPZEeS_qLctCs2aRQ")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate BirthDate { get; init; }

        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_98J3xfPYEeS_qLctCs2aRQ")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public required GenericPersonIdentification1 Other { get; init; }
    }
}
