// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Counterparty12Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_5ToeQc3yEee5nJBZsW8MFQ")]
    [DisplayName("Buyer")]
    public partial record Buyer : Counterparty12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_qIo4_83yEee5nJBZsW8MFQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification104Choice_ Identification { get; init; } 
        
        /// <summary>
        /// Legal Entity Identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_qIo5B83yEee5nJBZsW8MFQ")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; } 
        
        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_qIo5Cc3yEee5nJBZsW8MFQ")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
        
        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_qIo5Ec3yEee5nJBZsW8MFQ")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        public SecuritiesAccount30? SafekeepingAccount { get; init; } 
        
        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_qIo5Gc3yEee5nJBZsW8MFQ")]
        [DisplayName("Processing Date")]
        [IsoXmlTag("PrcgDt")]
        public DateAndDateTime2Choice_? ProcessingDate { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_qIo5Ic3yEee5nJBZsW8MFQ")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
        
        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_qIo5Kc3yEee5nJBZsW8MFQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public PartyTextInformation3? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
