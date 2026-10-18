// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party35Choice
{
    /// <inheritdoc cref="IParty"/>
    [IsoId("_mm7Z07TREeeyuKckOGlwuA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public partial record Party : Party35Choice_
    {
        /// <inheritdoc cref="IParty.Name"/>
        [IsoId("_jzRC069UEeeJJK1oRb-jTw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? Name { get; init; }

        /// <inheritdoc cref="IParty.PostalAddress"/>
        [IsoId("_jzRp4a9UEeeJJK1oRb-jTw")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public PostalAddress6? PostalAddress { get; init; }

        /// <inheritdoc cref="IParty.Identification"/>
        [IsoId("_jzRp469UEeeJJK1oRb-jTw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public Party34Choice_? Identification { get; init; }

        /// <inheritdoc cref="IParty.CountryOfResidence"/>
        [IsoId("_jzRp5a9UEeeJJK1oRb-jTw")]
        [DisplayName("Country Of Residence")]
        [IsoXmlTag("CtryOfRes")]
        public CountryCode? CountryOfResidence { get; init; }

        /// <inheritdoc cref="IParty.ContactDetails"/>
        [IsoId("_jzRp569UEeeJJK1oRb-jTw")]
        [DisplayName("Contact Details")]
        [IsoXmlTag("CtctDtls")]
        public ContactDetails2? ContactDetails { get; init; }
    }
}
