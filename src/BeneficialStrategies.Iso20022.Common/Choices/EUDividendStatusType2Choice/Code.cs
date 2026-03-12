// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EUDividendStatusType2Choice
{
    /// <summary>
    /// EU dividend status expressed as a code.
    /// </summary>
    [IsoId("_P4AegTh8EeaH-93K5JKmzw")]
    [DisplayName("Code")]
    public partial record Code : EUDividendStatusType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EUDividendStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
