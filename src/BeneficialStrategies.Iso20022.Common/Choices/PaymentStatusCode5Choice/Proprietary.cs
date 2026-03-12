// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode5Choice
{
    /// <summary>
    /// Qualifies further the proprietary status.
    /// </summary>
    [IsoId("_72FYF6MgEeCJ6YNENx4h-w_110402669")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : PaymentStatusCode5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
