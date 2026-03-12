// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode4Choice
{
    /// <summary>
    /// Qualifies further the proprietary status.
    /// </summary>
    [IsoId("_RZlnItp-Ed-ak6NoX_4Aeg_1532717459")]
    [DisplayName("Proprietary Status")]
    public partial record ProprietaryStatus : PaymentStatusCode4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("PrtrySts")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
