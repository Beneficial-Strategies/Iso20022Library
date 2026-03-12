// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RemittanceInformation3Choice
{
    /// <summary>
    /// Information, in free text form, to enable the matching, ie reconciliation, (reconciliation) of a payment with the items that the payment is intended to settle, such as commercial invoices in an accounts receivable system.
    /// </summary>
    [IsoId("_Rb1C19p-Ed-ak6NoX_4Aeg_975277681")]
    [DisplayName("Unstructured")]
    public partial record Unstructured : RemittanceInformation3Choice_
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
