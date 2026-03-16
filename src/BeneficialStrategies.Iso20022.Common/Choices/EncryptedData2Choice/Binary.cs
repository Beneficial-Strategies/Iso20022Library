// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EncryptedData2Choice
{
    /// <summary>
    /// Binary.
    /// </summary>
    [DisplayName("Binary")]
    public partial record Binary : EncryptedData2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Binry")]
        public required IsoMax100KBinary Value { get; init; } 
        
        
        #nullable disable
        
    }
}
