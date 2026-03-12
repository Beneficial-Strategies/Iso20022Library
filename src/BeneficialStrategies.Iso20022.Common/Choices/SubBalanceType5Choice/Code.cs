// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SubBalanceType5Choice
{
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_QYU-ddp-Ed-ak6NoX_4Aeg_1059087633")]
    [DisplayName("Code")]
    public partial record Code : SubBalanceType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType12Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
