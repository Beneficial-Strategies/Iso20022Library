// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeType3Choice
{
    /// <summary>
    /// Charge type, in a coded form.
    /// </summary>
    [IsoId("_tjJEUlkyEeGeoaLUQk__nA_-734620698")]
    [DisplayName("Code")]
    public partial record Code : ChargeType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalChargeType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
