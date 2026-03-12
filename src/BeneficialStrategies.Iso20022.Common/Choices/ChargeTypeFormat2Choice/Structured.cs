// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeFormat2Choice
{
    /// <summary>
    /// Specifies the type of charge in a structured form.
    /// </summary>
    [IsoId("_UyQMGdp-Ed-ak6NoX_4Aeg_2129381722")]
    [DisplayName("Structured")]
    public partial record Structured : ChargeTypeFormat2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of service for which a charge is asked or paid.
        /// </summary>
        [IsoXmlTag("Strd")]
        public required ChargeType4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
