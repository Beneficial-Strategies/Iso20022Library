// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType10FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of securities balance.
    /// </summary>
    [IsoId("_RoygxNp-Ed-ak6NoX_4Aeg_-1171470357")]
    [DisplayName("Code")]
    public partial record Code : SecuritiesBalanceType10FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of securities balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType10Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
