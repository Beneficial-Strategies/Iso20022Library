// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification3Choice
{
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_QE8vdNp-Ed-ak6NoX_4Aeg_2090381870")]
    [DisplayName("Proprietary Identification")]
    public partial record ProprietaryIdentification : FinancialInstitutionIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
        /// </summary>
        [IsoId("_P-sWcNp-Ed-ak6NoX_4Aeg_836935724")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
