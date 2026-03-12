// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party7Choice
{
    /// <summary>
    /// Identification of a financial institution.
    /// </summary>
    [IsoId("_PbFTENp-Ed-ak6NoX_4Aeg_2127848193")]
    [DisplayName("Agent")]
    public partial record Agent : Party7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
        /// </summary>
        [IsoId("_TFB1Rdp-Ed-ak6NoX_4Aeg_-736059286")]
        [DisplayName("Financial Institution Identification")]
        [IsoXmlTag("FinInstnId")]
        public required FinancialInstitutionIdentification7 FinancialInstitutionIdentification { get; init; } 
        
        /// <summary>
        /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_TFB1Rtp-Ed-ak6NoX_4Aeg_-1911467512")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        public BranchData2? BranchIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
