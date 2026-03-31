// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentificationChoice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_RE37YNp-Ed-ak6NoX_4Aeg_1465032202")]
    [DisplayName("Person Name")]
    [IsoXmlTag("PrsnNm")]
    public record PersonName : IndividualPersonIdentificationChoice_
    {
        /// <summary>
        /// First name of a person.
        /// </summary>
        [IsoId("_QBrZBdp-Ed-ak6NoX_4Aeg_995882490")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text GivenName { get; init; }

        /// <summary>
        /// Second name of a person.
        /// </summary>
        [IsoId("_QBrZBtp-Ed-ak6NoX_4Aeg_867841803")]
        [DisplayName("Middle Name")]
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MiddleName { get; init; }

        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_QBrZB9p-Ed-ak6NoX_4Aeg_995884938")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Specifies the gender of the person.
        /// </summary>
        [IsoId("_QBrZCNp-Ed-ak6NoX_4Aeg_995885732")]
        [DisplayName("Gender")]
        [IsoXmlTag("Gndr")]
        public GenderCode? Gender { get; init; }

        /// <summary>
        /// Date on which a person is born.
        /// </summary>
        [IsoId("_QB0i8Np-Ed-ak6NoX_4Aeg_996806013")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? BirthDate { get; init; }
    }
}
