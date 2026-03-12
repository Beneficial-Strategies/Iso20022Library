// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceType5Choice
{
    /// <summary>
    /// Balance type, in a coded form.
    /// </summary>
    [IsoId("_SYxMMdp-Ed-ak6NoX_4Aeg_1163104804")]
    [DisplayName("Code")]
    public partial record Code : BalanceType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the balance type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType12Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
