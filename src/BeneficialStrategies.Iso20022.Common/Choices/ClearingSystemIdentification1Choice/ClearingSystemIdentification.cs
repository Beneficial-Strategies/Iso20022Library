// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification1Choice
{
    /// <summary>
    /// Infrastructure through which the payment instruction is processed.
    /// </summary>
    [IsoId("_TMVXINp-Ed-ak6NoX_4Aeg_-843594927")]
    [DisplayName("Clearing System Identification")]
    public partial record ClearingSystemIdentification : ClearingSystemIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
        /// </summary>
        [IsoXmlTag("ClrSysId")]
        public required CashClearingSystem3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
