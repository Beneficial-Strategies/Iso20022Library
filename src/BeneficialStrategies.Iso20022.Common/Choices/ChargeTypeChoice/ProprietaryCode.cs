// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeChoice
{
    /// <summary>
    /// Type of charge is a bilaterally agreed code.
    /// </summary>
    [IsoId("_RIcz1tp-Ed-ak6NoX_4Aeg_-1267403815")]
    [DisplayName("Proprietary Code")]
    public partial record ProprietaryCode : ChargeTypeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("PrtryCd")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
