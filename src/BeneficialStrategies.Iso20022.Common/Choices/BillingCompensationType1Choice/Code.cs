// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BillingCompensationType1Choice
{
    /// <summary>
    /// Defines the type of billing compensation, as published in an external billing compensation type code list.
    /// </summary>
    [IsoId("_6Q_lgpqlEeGSON8vddiWzQ_-1941802913")]
    [DisplayName("Code")]
    public partial record Code : BillingCompensationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Defines the type of billing compensation to be applied, as published in an external billing compensation type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalBillingCompensationType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
