// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TrackerParty2Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_5THNEWOTEeq5Ar_w98FvsA")]
    [DisplayName("Financial Institution Identification")]
    public partial record FinancialInstitutionIdentification : TrackerParty2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoId("_R1aeMWOUEeq5Ar_w98FvsA")]
        [DisplayName("BICFI")]
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
        public IsoBICFIDec2014Identifier? BICFI { get; init; } 
        
        /// <summary>
        /// Information used to identify a member within a clearing system.
        /// </summary>
        [IsoId("_R1aeM2OUEeq5Ar_w98FvsA")]
        [DisplayName("Clearing System Member Identification")]
        [IsoXmlTag("ClrSysMmbId")]
        public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
        
        /// <summary>
        /// Legal entity identifier of the financial institution.
        /// </summary>
        [IsoId("_R1aeNWOUEeq5Ar_w98FvsA")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; } 
        
        /// <summary>
        /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_R1aeO2OUEeq5Ar_w98FvsA")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericFinancialIdentification1? Other { get; init; } 
        
        
        #nullable disable
        
    }
}
