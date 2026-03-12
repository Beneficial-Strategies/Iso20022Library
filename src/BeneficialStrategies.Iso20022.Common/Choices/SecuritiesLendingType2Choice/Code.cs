// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesLendingType2Choice
{
    /// <summary>
    /// Securities lending type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_KrIw85EkEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public partial record Code : SecuritiesLendingType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of securities lending contract.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesLendingType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
