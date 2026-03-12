// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EncryptedData1Choice
{
    /// <summary>
    /// BASE-64 encoded encrypted data.
    /// </summary>
    [IsoId("_-on81OkLEemeDPHh-U9b6w")]
    [DisplayName("Binary Data")]
    public partial record BinaryData : EncryptedData1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Binary data of 100K maximum.
        /// </summary>
        [IsoXmlTag("BinryData")]
        [IsoSimpleType(IsoSimpleType.Max100KBinary)]
        public required IsoMax100KBinary Value { get; init; } 
        
        
        #nullable disable
        
    }
}
