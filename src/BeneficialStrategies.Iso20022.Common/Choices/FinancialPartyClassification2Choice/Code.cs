// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialPartyClassification2Choice
{
    /// <summary>
    /// Classification of the business activities of the counterparty via a pre-determined code list.
    /// </summary>
    [IsoId("_IJIRcSI4Ee2zWP9pqvmqdw")]
    [DisplayName("Code")]
    public partial record Code : FinancialPartyClassification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the reporting counterparty business activities. 
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FinancialPartySectorType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
