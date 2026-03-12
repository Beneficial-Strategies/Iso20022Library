// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party13Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a financial institution.
    /// </summary>
    [IsoId("_6Q10hZqlEeGSON8vddiWzQ_1922530449")]
    [DisplayName("Financial Institution Identification")]
    public partial record FinancialInstitutionIdentification : Party13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoId("_6T-oF5qlEeGSON8vddiWzQ_-1460045446")]
        [DisplayName("BICFI")]
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public IsoBICFIIdentifier? BICFI { get; init; } 
        
        /// <summary>
        /// Information used to identify a member within a clearing system.
        /// </summary>
        [IsoId("_6T-oGJqlEeGSON8vddiWzQ_700420690")]
        [DisplayName("Clearing System Member Identification")]
        [IsoXmlTag("ClrSysMmbId")]
        public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
        
        /// <summary>
        /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_6T-oGZqlEeGSON8vddiWzQ_1934580671")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericFinancialIdentification1? Other { get; init; } 
        
        
        #nullable disable
        
    }
}
