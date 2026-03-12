// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity2Choice
{
    /// <summary>
    /// Provides the time to maturity when no period is provide.
    /// </summary>
    [IsoId("__aOTk65OEeuo-IflVgGqiA")]
    [DisplayName("Special")]
    public partial record Special : TimeToMaturity2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies blank or not available codes.
        /// </summary>
        [IsoXmlTag("Spcl")]
        public required SpecialPurpose2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
