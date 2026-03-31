// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification237Choice
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_fs1bYRuUEeyhRdHRjakS2w")]
    [DisplayName("Legal Person")]
    [IsoXmlTag("LglPrsn")]
    public record LegalPerson : PartyIdentification237Choice_
    {
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_gCI9ARuUEeyhRdHRjakS2w")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName2 NameAndAddress { get; init; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_gCI9AxuUEeyhRdHRjakS2w")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; }

        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_gCI9BRuUEeyhRdHRjakS2w")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification198Choice_? Identification { get; init; }

        /// <summary>
        /// Identification of the shareholder in the company share register.
        /// </summary>
        [IsoId("_xLUrgBuUEeyhRdHRjakS2w")]
        [DisplayName("Company Register Shareholder Identification")]
        [IsoXmlTag("CpnyRegrShrhldrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CompanyRegisterShareholderIdentification { get; init; }
    }
}
