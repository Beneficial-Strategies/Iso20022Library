// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentOrigin1Choice
{
    /// <summary>
    /// Specifies the type of payment when not included in a SWIFT or proprietary format.
    /// </summary>
    [IsoId("_RIwV2Np-Ed-ak6NoX_4Aeg_-1983565483")]
    [DisplayName("Instrument")]
    public partial record Instrument : PaymentOrigin1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the payment instrument used or the underlying financial transaction that resulted in a payment transaction.
        /// </summary>
        [IsoXmlTag("Instrm")]
        public required PaymentInstrument1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
