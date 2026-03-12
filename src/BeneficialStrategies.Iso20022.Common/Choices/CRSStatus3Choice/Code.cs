// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CRSStatus3Choice
{
    /// <summary>
    /// Common Reporting Standard (CRS) status expressed as a code.
    /// </summary>
    [IsoId("__Xcm0UNeEeamLdeYEZm56w")]
    [DisplayName("Code")]
    public partial record Code : CRSStatus3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the Common Reporting Status (CRS) status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CRSStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
