// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxType3FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of taxes.
    /// </summary>
    [IsoId("_RpFbstp-Ed-ak6NoX_4Aeg_1866583881")]
    [DisplayName("Code")]
    public partial record Code : TaxType3FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of tax.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
