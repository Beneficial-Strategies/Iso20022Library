// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BankContactPerson1Choice
{
    /// <summary>
    /// Person to be contacted in the buyer&apos;s bank.
    /// </summary>
    [IsoId("_nYAXYDAZEeOKib24wnHaFg")]
    [DisplayName("Buyer Bank Contact Person")]
    public partial record BuyerBankContactPerson : BankContactPerson1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_QBOtFNp-Ed-ak6NoX_4Aeg_-1134631327")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Name { get; init; } 
        
        /// <summary>
        /// Specifies the terms used to formally address a person.
        /// </summary>
        [IsoId("_QBOtFdp-Ed-ak6NoX_4Aeg_-1825403256")]
        [DisplayName("Name Prefix")]
        [IsoXmlTag("NmPrfx")]
        public NamePrefix1Code? NamePrefix { get; init; } 
        
        /// <summary>
        /// First name of a person.
        /// </summary>
        [IsoId("_QBOtFtp-Ed-ak6NoX_4Aeg_-1028894727")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? GivenName { get; init; } 
        
        /// <summary>
        /// Role of the party in the activity.
        /// </summary>
        [IsoId("_QBOtF9p-Ed-ak6NoX_4Aeg_2125093183")]
        [DisplayName("Role")]
        [IsoXmlTag("Role")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Role { get; init; } 
        
        /// <summary>
        /// Collection of information that identifies a phone number, as defined by telecom services.
        /// </summary>
        [IsoId("_QBOtGNp-Ed-ak6NoX_4Aeg_-505408090")]
        [DisplayName("Phone Number")]
        [IsoXmlTag("PhneNb")]
        [IsoSimpleType(IsoSimpleType.PhoneNumber)]
        public IsoPhoneNumber? PhoneNumber { get; init; } 
        
        /// <summary>
        /// Collection of information that identifies a FAX number, as defined by telecom services.
        /// </summary>
        [IsoId("_QBOtGdp-Ed-ak6NoX_4Aeg_-505408635")]
        [DisplayName("Fax Number")]
        [IsoXmlTag("FaxNb")]
        [IsoSimpleType(IsoSimpleType.PhoneNumber)]
        public IsoPhoneNumber? FaxNumber { get; init; } 
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_QBX3ANp-Ed-ak6NoX_4Aeg_-505409021")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; } 
        
        
        #nullable disable
        
    }
}
