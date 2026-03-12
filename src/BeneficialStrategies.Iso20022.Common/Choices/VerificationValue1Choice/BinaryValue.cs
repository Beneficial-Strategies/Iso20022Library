// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.VerificationValue1Choice
{
    /// <summary>
    /// Value of the data expressed in BASE-64 encoded binary form.
    /// </summary>
    [IsoId("_4EhKp5aNEemfCcEf5rVTyg")]
    [DisplayName("Binary Value")]
    public partial record BinaryValue : VerificationValue1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a binary string with a maximum length of 5000 binary bytes.
        /// </summary>
        [IsoXmlTag("BinryVal")]
        [IsoSimpleType(IsoSimpleType.Max5000Binary)]
        public required IsoMax5000Binary Value { get; init; } 
        
        
        #nullable disable
        
    }
}
