// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashBalanceType3Choice
{
    /// <summary>
    /// Cash balance expressed in a coded form.
    /// </summary>
    [IsoId("_NW5nQTqFEemJ3KLLPeYl6g")]
    [DisplayName("Code")]
    public partial record Code : CashBalanceType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the balance type, as published in an external balance type code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalBalanceType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
