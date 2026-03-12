// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BillingRateIdentification1Choice
{
    /// <summary>
    /// Specifies the billing rate identification code, as defined in an external code list.
    /// </summary>
    [IsoId("_6Q10h5qlEeGSON8vddiWzQ_1326961211")]
    [DisplayName("Code")]
    public partial record Code : BillingRateIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of billing rate or factor, as published in an external billing rate identification code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalBillingRateIdentification1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
