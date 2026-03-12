// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyType1Choice
{
    /// <summary>
    /// System party type, in a coded format.
    /// </summary>
    [IsoId("_DZrOdVhPEeih3fUfzR38Ig")]
    [DisplayName("Code")]
    public partial record Code : SystemPartyType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the system party type, as published in an external system party type code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSystemPartyType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
