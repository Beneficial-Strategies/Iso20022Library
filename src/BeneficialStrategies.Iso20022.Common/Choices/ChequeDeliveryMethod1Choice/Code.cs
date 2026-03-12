// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChequeDeliveryMethod1Choice
{
    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_QbwF59p-Ed-ak6NoX_4Aeg_1044150030")]
    [DisplayName("Code")]
    public partial record Code : ChequeDeliveryMethod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the method to be used in delivering a cheque to a party.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChequeDelivery1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
