// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification1Choice
{
    /// <summary>
    /// Identifier of a security assigned by the Bloomberg organisation.
    /// </summary>
    [IsoId("_VcIPg9p-Ed-ak6NoX_4Aeg_-371877998")]
    [DisplayName("Bloomberg")]
    public partial record Bloomberg : SecurityIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// An identifier of a security assigned by the Bloomberg organisation.
        /// </summary>
        [IsoXmlTag("Blmbrg")]
        [IsoSimpleType(IsoSimpleType.BloombergIdentifier)]
        public required IsoBloombergIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
