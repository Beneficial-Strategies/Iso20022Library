// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Identifier for Belgian securities.
    /// </summary>
    [IsoId("_Qd1wk9p-Ed-ak6NoX_4Aeg_-722284454")]
    [DisplayName("Belgian")]
    public partial record Belgian : SecurityIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for Belgian securities.
        /// </summary>
        [IsoXmlTag("Belgn")]
        [IsoSimpleType(IsoSimpleType.BelgianIdentifier)]
        public required IsoBelgianIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
