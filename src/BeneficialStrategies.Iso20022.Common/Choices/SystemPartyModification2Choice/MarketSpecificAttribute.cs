// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_yJhSrYv-Eei289CGNqs21g")]
    [DisplayName("Market Specific Attribute")]
    public partial record MarketSpecificAttribute : SystemPartyModification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the name of the market-specific attribute.
        /// </summary>
        [IsoId("_klTTQ-5NEeCisYr99QEiWA_1518015458")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Name { get; init; } 
        
        /// <summary>
        /// Specifies the value of the market-specific attribute.
        /// </summary>
        [IsoId("_kldEQO5NEeCisYr99QEiWA_1961003950")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
