// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeType2Choice
{
    /// <summary>
    /// Charge type, in a coded form.
    /// </summary>
    [IsoId("_RvC5xNp-Ed-ak6NoX_4Aeg_-1781938908")]
    [DisplayName("Code")]
    public partial record Code : ChargeType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of service for which a charge is asked or paid.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChargeType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
