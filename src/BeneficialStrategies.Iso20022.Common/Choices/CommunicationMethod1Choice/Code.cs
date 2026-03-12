// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommunicationMethod1Choice
{
    /// <summary>
    /// Communication channel method.
    /// </summary>
    [IsoId("_93Z_xHltEeG7BsjMvd1mEw_543627896")]
    [DisplayName("Code")]
    public partial record Code : CommunicationMethod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalChannel1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
