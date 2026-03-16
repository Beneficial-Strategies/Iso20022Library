// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentification1Choice
{
    /// <summary>
    /// Name of the person that owns the account.
    /// </summary>
    [IsoId("_g3i8IyFWEeWgV9SQSyaAog")]
    [DisplayName("Person Name")]
    [IsoXmlTag("PrsnNm")]
    public record PersonName : IndividualPersonIdentification1Choice_
    {
        /// <summary>
        /// First name of the person.
        /// </summary>
        [IsoId("_1X2C0V0fEeWFBqZ9f7Sd_g")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? GivenName { get; init; }

        /// <summary>
        /// Second name of the person.
        /// </summary>
        [IsoId("_1X2C010fEeWFBqZ9f7Sd_g")]
        [DisplayName("Middle Name")]
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MiddleName { get; init; }

        /// <summary>
        /// Name by which the party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_1X2C1V0fEeWFBqZ9f7Sd_g")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Gender of the person.
        /// </summary>
        [IsoId("_1X2C110fEeWFBqZ9f7Sd_g")]
        [DisplayName("Gender")]
        [IsoXmlTag("Gndr")]
        public GenderCode? Gender { get; init; }

        /// <summary>
        /// Date on which the person is born.
        /// </summary>
        [IsoId("_1X2C2V0fEeWFBqZ9f7Sd_g")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? BirthDate { get; init; }
    }
}
