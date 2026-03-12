// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentOrigin1Choice
{
    /// <summary>
    /// Specifies that the payment was included in a SWIFT FIN format message, for example, MT 103.
    /// </summary>
    [IsoId("_RIwV1dp-Ed-ak6NoX_4Aeg_1910593546")]
    [DisplayName("FIN Message Type")]
    public partial record FINMessageType : PaymentOrigin1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a maximum length of 3 digits.
        /// </summary>
        [IsoXmlTag("FINMT")]
        [IsoSimpleType(IsoSimpleType.Max3NumericText)]
        public required IsoMax3NumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
