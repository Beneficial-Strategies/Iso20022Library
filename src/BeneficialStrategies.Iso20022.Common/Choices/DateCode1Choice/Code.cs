// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateCode1Choice
{
    /// <summary>
    /// Date expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Quh3-Np-Ed-ak6NoX_4Aeg_-1919638167")]
    [DisplayName("Code")]
    public partial record Code : DateCode1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
