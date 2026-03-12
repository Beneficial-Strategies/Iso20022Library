// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party7Choice
{
    /// <summary>
    /// Identification of a person or an organisation.
    /// </summary>
    [IsoId("_Pa7iGNp-Ed-ak6NoX_4Aeg_2099219104")]
    [DisplayName("Party")]
    public partial record Party : Party7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PaxxFtp-Ed-ak6NoX_4Aeg_-1092208075")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? Name { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_PaxxF9p-Ed-ak6NoX_4Aeg_-1092207954")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public PostalAddress6? PostalAddress { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identification of a party.
        /// </summary>
        [IsoId("_PaxxGNp-Ed-ak6NoX_4Aeg_-1092207900")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public Party6Choice_? Identification { get; init; } 
        
        /// <summary>
        /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
        /// </summary>
        [IsoId("_PaxxGdp-Ed-ak6NoX_4Aeg_-1092208016")]
        [DisplayName("Country Of Residence")]
        [IsoXmlTag("CtryOfRes")]
        public CountryCode? CountryOfResidence { get; init; } 
        
        /// <summary>
        /// Set of elements used to indicate how to contact the party.
        /// </summary>
        [IsoId("_Pa7iENp-Ed-ak6NoX_4Aeg_935029789")]
        [DisplayName("Contact Details")]
        [IsoXmlTag("CtctDtls")]
        public ContactDetails2? ContactDetails { get; init; } 
        
        
        #nullable disable
        
    }
}
