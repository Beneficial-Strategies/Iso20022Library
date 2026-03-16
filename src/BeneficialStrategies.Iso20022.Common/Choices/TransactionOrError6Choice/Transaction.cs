// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionOrError6Choice
{
    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    public partial record Transaction : TransactionOrError6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Tx")]
        public required Transaction159 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
