// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ShareRanking1FormatChoice
{
    /// <summary>
    /// Standard code to specify the share ranking.
    /// </summary>
    [IsoId("_Ro8RxNp-Ed-ak6NoX_4Aeg_1569147900")]
    [DisplayName("Code")]
    public partial record Code : ShareRanking1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the shares are ranking for dividend or pari passu.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ShareRanking1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
