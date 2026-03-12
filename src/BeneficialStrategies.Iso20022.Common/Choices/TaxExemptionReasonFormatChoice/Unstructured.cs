// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReasonFormatChoice
{
    /// <summary>
    /// Free text form.
    /// </summary>
    [IsoId("_UzJj89p-Ed-ak6NoX_4Aeg_-1748201269")]
    [DisplayName("Unstructured")]
    public partial record Unstructured : TaxExemptionReasonFormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 140 characters.
        /// </summary>
        [IsoXmlTag("Ustrd")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public required IsoMax140Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
