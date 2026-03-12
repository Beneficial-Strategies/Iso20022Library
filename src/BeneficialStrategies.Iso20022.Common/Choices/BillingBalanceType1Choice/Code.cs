// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BillingBalanceType1Choice
{
    /// <summary>
    /// Defines the type of billing balance, as published in an external billing balance type code list.
    /// </summary>
    [IsoId("_6Q_lhZqlEeGSON8vddiWzQ_-1378614668")]
    [DisplayName("Code")]
    public partial record Code : BillingBalanceType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Defines the balance of the billing service, as published in an external billing balance code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalBillingBalanceType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
