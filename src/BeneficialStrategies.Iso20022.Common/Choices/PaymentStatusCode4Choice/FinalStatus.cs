// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode4Choice
{
    /// <summary>
    /// Qualifies further the final status.
    /// </summary>
    [IsoId("_RZlnIdp-Ed-ak6NoX_4Aeg_1463454885")]
    [DisplayName("Final Status")]
    public partial record FinalStatus : PaymentStatusCode4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the final status of a transaction.
        /// </summary>
        [IsoXmlTag("FnlSts")]
        public required FinalStatusCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
