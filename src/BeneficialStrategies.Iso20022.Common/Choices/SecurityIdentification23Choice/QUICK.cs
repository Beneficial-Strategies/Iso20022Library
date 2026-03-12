// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
    /// </summary>
    [IsoId("_CSq4QSGQEeW7gKYhAMEFCw")]
    [DisplayName("QUICK")]
    public partial record QUICK : SecurityIdentification23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
        /// </summary>
        [IsoXmlTag("QUICK")]
        [IsoSimpleType(IsoSimpleType.QUICKIdentifier)]
        public required IsoQUICKIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
