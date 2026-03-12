// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementConditionModificationStatus1Choice
{
    /// <summary>
    /// Provides the status of the securities settlement condition modification request.
    /// </summary>
    [IsoId("_UYeaI9p-Ed-ak6NoX_4Aeg_-936948757")]
    [DisplayName("Code")]
    public partial record Code : SettlementConditionModificationStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a securities settlement condition modification request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementConditionModificationStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
