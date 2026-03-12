// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ContractTerm6Choice
{
    /// <summary>
    /// Transaction is open term, that is, has no fixed maturity date.
    /// </summary>
    [IsoId("__L6x0a5OEeuo-IflVgGqiA")]
    [DisplayName("Open")]
    public partial record Open : ContractTerm6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A flag indicating a True or False value.
        /// </summary>
        [IsoXmlTag("Opn")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
