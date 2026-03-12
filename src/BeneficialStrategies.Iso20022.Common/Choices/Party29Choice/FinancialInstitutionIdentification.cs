// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party29Choice
{
    /// <summary>
    /// Identification of a financial institution.
    /// </summary>
    [IsoId("_5wjW9EyhEeWw591U1lOHyQ")]
    [DisplayName("Financial Institution Identification")]
    public partial record FinancialInstitutionIdentification : Party29Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
        /// </summary>
        [IsoXmlTag("FinInstnId")]
        public required FinancialInstitutionIdentification8 Value { get; init; } 
        
        /// <summary>
        /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_TFB1Q9p-Ed-ak6NoX_4Aeg_-1458035858")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        public BranchData2? BranchIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
