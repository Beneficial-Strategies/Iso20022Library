// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification196Choice
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_8gnOcDtnEemIf7eyjCwinw")]
    [DisplayName("Legal Person")]
    [IsoXmlTag("LglPrsn")]
    public record LegalPerson : PartyIdentification196Choice_
    {
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_D79wQDtpEemIf7eyjCwinw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required NameAndAddress17 NameAndAddress { get; init; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_GXuoEDtpEemIf7eyjCwinw")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; }

        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_hJ5qEDtpEemIf7eyjCwinw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification198Choice_ Identification { get; init; }

        /// <summary>
        /// Country in which the company is incorporated or legally registered.
        /// </summary>
        [IsoId("_cDVrcIkyEemZteIrPMIV3g")]
        [DisplayName("Country Of Incorporation")]
        [IsoXmlTag("CtryOfIncorprtn")]
        public CountryCode? CountryOfIncorporation { get; init; }

        /// <summary>
        /// Economical activity of the  investor.
        /// </summary>
        [IsoId("_ePTTEIk6EemZteIrPMIV3g")]
        [DisplayName("Activity Indicator")]
        [IsoXmlTag("ActvtyInd")]
        [IsoSimpleType(IsoSimpleType.ISICIdentifier)]
        public IsoISICIdentifier? ActivityIndicator { get; init; }

        /// <summary>
        /// Type of investor.
        /// </summary>
        [IsoId("_aShGsYk1EemZteIrPMIV3g")]
        [DisplayName("Investor Type")]
        [IsoXmlTag("InvstrTp")]
        public InvestorType1Choice_? InvestorType { get; init; }

        /// <summary>
        /// Provides information about the ownership on an asset.
        /// </summary>
        [IsoId("_uX0X0Iz1EemXJvzC2Wyt1g")]
        [DisplayName("Ownership")]
        [IsoXmlTag("Ownrsh")]
        public Ownership1? Ownership { get; init; }
    }
}
