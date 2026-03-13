// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party40Choice
{
    /// <summary>
    /// Identification of a financial institution.
    /// </summary>
    [IsoId("_8U6MNW48EeiU9cctagi5ow")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public partial record Agent : Party40Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
        /// </summary>
        [IsoId("_8xXCMW49EeiU9cctagi5ow")]
        [DisplayName("Financial Institution Identification")]
        [IsoXmlTag("FinInstnId")]
        public required FinancialInstitutionIdentification18 FinancialInstitutionIdentification { get; init; } 
        
        /// <summary>
        /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_8xXCM249EeiU9cctagi5ow")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        public BranchData3? BranchIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
