// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ElectionTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_Q3K2k9p-Ed-ak6NoX_4Aeg_1718215960")]
    [DisplayName("Code")]
    public partial record Code : ElectionTypeFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the effect on the holdings of electing a Corporate Action option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ElectionMovementType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
