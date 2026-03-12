// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Counterparty1Choice
{
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_PYQBgNp-Ed-ak6NoX_4Aeg_1721008493")]
    [DisplayName("Seller")]
    public partial record Seller : Counterparty1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_PYGQgNp-Ed-ak6NoX_4Aeg_1106994813")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification10Choice_ Identification { get; init; } 
        
        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_PYGQgdp-Ed-ak6NoX_4Aeg_109922460")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
        
        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_PYGQgtp-Ed-ak6NoX_4Aeg_1285113485")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        public SecuritiesAccount13? SafekeepingAccount { get; init; } 
        
        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_PYGQg9p-Ed-ak6NoX_4Aeg_1755189895")]
        [DisplayName("Processing Date")]
        [IsoXmlTag("PrcgDt")]
        public DateAndDateTimeChoice_? ProcessingDate { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_PYGQhNp-Ed-ak6NoX_4Aeg_758117542")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ProcessingIdentification { get; init; } 
        
        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_PYGQhdp-Ed-ak6NoX_4Aeg_-238954811")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public PartyTextInformation1? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
