// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionType1CodeChoice
{
    /// <summary>
    /// Transaction type in a structured format.
    /// </summary>
    [IsoId("_U0V2wtp-Ed-ak6NoX_4Aeg_2144803463")]
    [DisplayName("Structured")]
    public partial record Structured : TransactionType1CodeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of transaction.
        /// </summary>
        [IsoXmlTag("Strd")]
        public required TransactionType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
