// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification237Choice
{
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_fs1bYxuUEeyhRdHRjakS2w")]
    [DisplayName("Natural Person")]
    public partial record NaturalPerson : PartyIdentification237Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_I3hbERuVEeyhRdHRjakS2w")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName3 NameAndAddress { get; init; } 
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_I3hbExuVEeyhRdHRjakS2w")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; } 
        
        /// <summary>
        /// Natural person local identification and type.
        /// </summary>
        [IsoId("_I3hbFRuVEeyhRdHRjakS2w")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public NaturalPersonIdentification1? Identification { get; init; } 
        
        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [IsoId("_I3hbFxuVEeyhRdHRjakS2w")]
        [DisplayName("Nationality")]
        [IsoXmlTag("Ntlty")]
        public CountryCode? Nationality { get; init; } 
        
        /// <summary>
        /// Date on which and place at which a born person is born.
        /// </summary>
        [IsoId("_I3hbGRuVEeyhRdHRjakS2w")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
        
        /// <summary>
        /// Identification of the shareholder in the company share register.
        /// </summary>
        [IsoId("_L0UjYRuVEeyhRdHRjakS2w")]
        [DisplayName("Company Register Shareholder Identification")]
        [IsoXmlTag("CpnyRegrShrhldrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CompanyRegisterShareholderIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
