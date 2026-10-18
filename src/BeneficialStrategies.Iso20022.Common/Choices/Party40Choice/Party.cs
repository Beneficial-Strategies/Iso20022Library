// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party40Choice
{
    /// <inheritdoc cref="IParty"/>
    [IsoId("_8U6MM248EeiU9cctagi5ow")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public partial record Party : Party40Choice_
    {
        /// <inheritdoc cref="IParty.Name"/>
        [IsoId("_6L-Jw248EeiU9cctagi5ow")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? Name { get; init; }

        /// <inheritdoc cref="IParty.PostalAddress"/>
        [IsoId("_6L-JxW48EeiU9cctagi5ow")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public PostalAddress24? PostalAddress { get; init; }

        /// <inheritdoc cref="IParty.Identification"/>
        [IsoId("_6L-Jx248EeiU9cctagi5ow")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public Party38Choice_? Identification { get; init; }

        /// <inheritdoc cref="IParty.CountryOfResidence"/>
        [IsoId("_6L-JyW48EeiU9cctagi5ow")]
        [DisplayName("Country Of Residence")]
        [IsoXmlTag("CtryOfRes")]
        public CountryCode? CountryOfResidence { get; init; }

        /// <inheritdoc cref="IParty.ContactDetails"/>
        [IsoId("_6L-Jy248EeiU9cctagi5ow")]
        [DisplayName("Contact Details")]
        [IsoXmlTag("CtctDtls")]
        public Contact4? ContactDetails { get; init; }
    }
}
