// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature15Choice
{
    /// <summary>
    /// Indicates that counterparty is a financial institution.
    /// </summary>
    [IsoId("_1z1A8Qz1Ee2YoLD-1vFj0g")]
    [DisplayName("Financial Institution")]
    public partial record FinancialInstitution : CounterpartyTradeNature15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the nature of the counterparty business activities. 
        /// </summary>
        [IsoId("_UgEEwAz2Ee2YoLD-1vFj0g")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        public ValueList<FinancialPartyClassification2Choice_> Sector { get; init; } = new ValueList<FinancialPartyClassification2Choice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _UgEEwAz2Ee2YoLD-1vFj0g
        
        /// <summary>
        /// Information whether the counterparty is above the clearing threshold.
        /// Usage: If the element is not present, the ClearingThreshold is False.
        /// </summary>
        [IsoId("_W7SxEAz2Ee2YoLD-1vFj0g")]
        [DisplayName("Clearing Threshold")]
        [IsoXmlTag("ClrThrshld")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? ClearingThreshold { get; init; } 
        
        
        #nullable disable
        
    }
}
