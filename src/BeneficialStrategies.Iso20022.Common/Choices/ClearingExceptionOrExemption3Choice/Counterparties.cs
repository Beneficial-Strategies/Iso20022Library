// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingExceptionOrExemption3Choice
{
    /// <summary>
    /// Set of information specific to counterparties.
    /// </summary>
    [IsoId("_AjSxc5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Counterparties")]
    public partial record Counterparties : ClearingExceptionOrExemption3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the type of clearing exemption or exception that the reporting counterparty has elected.
        /// </summary>
        [IsoId("_Ak0bcZPuEey0rJ3Gl6WZVA")]
        [DisplayName("Reporting Counterparty")]
        [IsoXmlTag("RptgCtrPty")]
        public required NonClearingReason2 ReportingCounterparty { get; init; } 
        
        /// <summary>
        /// Identifies the type of clearing exemption or exception that the other counterparty has elected.
        /// </summary>
        [IsoId("_Ak0bc5PuEey0rJ3Gl6WZVA")]
        [DisplayName("Other Counterparty")]
        [IsoXmlTag("OthrCtrPty")]
        public NonClearingReason2? OtherCounterparty { get; init; } 
        
        
        #nullable disable
        
    }
}
