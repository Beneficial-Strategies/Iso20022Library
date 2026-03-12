// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Identifier for French securities assigned by the Societe Interprofessionnelle Pour La Compensation des Valeurs Mobilieres in France. The Sicovam is composed of 5-digits.
    /// </summary>
    [IsoId("_Qd1wktp-Ed-ak6NoX_4Aeg_-722284713")]
    [DisplayName("Sicovam")]
    public partial record Sicovam : SecurityIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for French securities assigned by the Societe Interprofessionnelle Pour La Compensation des Valeurs Mobilieres in France. The Sicovam is composed of 5-digits.
        /// </summary>
        [IsoXmlTag("SCVM")]
        [IsoSimpleType(IsoSimpleType.SicovamIdentifier)]
        public required IsoSicovamIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
