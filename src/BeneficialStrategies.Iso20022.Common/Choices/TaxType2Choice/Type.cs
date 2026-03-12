// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxType2Choice
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_ilKssBrfEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    public partial record Type : TaxType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required TaxType9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
