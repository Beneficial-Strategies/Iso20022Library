// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateStatus1Choice
{
    /// <summary>
    /// Standard code to specify the status of the rate.
    /// </summary>
    [IsoId("_Q2kZptp-Ed-ak6NoX_4Aeg_-52068019")]
    [DisplayName("Code")]
    public partial record Code : RateStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
