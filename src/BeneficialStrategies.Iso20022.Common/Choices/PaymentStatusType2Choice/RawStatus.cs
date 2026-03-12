// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusType2Choice
{
    /// <summary>
    /// Contains the status of the payment taken from field 79 of the MT 199.
    /// </summary>
    [IsoId("_C2TSYSYMEei7VPGVFTQkxA")]
    [DisplayName("Raw Status")]
    public partial record RawStatus : PaymentStatusType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 1850 characters.
        /// </summary>
        [IsoXmlTag("RawSts")]
        [IsoSimpleType(IsoSimpleType.Max1850Text)]
        [StringLength(maximumLength: 1850 ,MinimumLength = 1)]
        public required IsoMax1850Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
