// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice
{
    /// <summary>
    /// Indicates if the goods have passed the phytosanitary check.
    /// </summary>
    [IsoId("_TnTb4dp-Ed-ak6NoX_4Aeg_-2016555095")]
    [DisplayName("Phytosanitary Indication")]
    public partial record PhytosanitaryIndication : CertifiedCharacteristics1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("PhytosntryIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
