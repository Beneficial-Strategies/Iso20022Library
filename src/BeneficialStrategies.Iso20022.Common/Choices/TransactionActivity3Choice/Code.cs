// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionActivity3Choice
{
    /// <summary>
    /// Transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_ilsVYTqDEeWVrPy0StzzSg")]
    [DisplayName("Code")]
    public partial record Code : TransactionActivity3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of activity to which this transaction relates.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionActivity1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
