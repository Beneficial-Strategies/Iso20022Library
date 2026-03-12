// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType2Choice
{
    /// <summary>
    /// Sub-balance expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QtL0I9p-Ed-ak6NoX_4Aeg_-1926533181")]
    [DisplayName("Code")]
    public partial record Code : SecuritiesBalanceType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType13Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
