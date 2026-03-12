// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceType10Choice
{
    /// <summary>
    /// Balance type, in a coded format.
    /// </summary>
    [IsoId("_DOF0dYakEeeUws0ZryHQ2w")]
    [DisplayName("Code")]
    public partial record Code : BalanceType10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the balance type, as published in an external balance type code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalBalanceType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
