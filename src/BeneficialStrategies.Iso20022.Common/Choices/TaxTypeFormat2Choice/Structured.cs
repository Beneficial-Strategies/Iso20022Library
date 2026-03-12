// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxTypeFormat2Choice
{
    /// <summary>
    /// Specifies the type of tax in structured form.
    /// </summary>
    [IsoId("_Uy2pB9p-Ed-ak6NoX_4Aeg_-1825008729")]
    [DisplayName("Structured")]
    public partial record Structured : TaxTypeFormat2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Strd")]
        public required TaxType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
