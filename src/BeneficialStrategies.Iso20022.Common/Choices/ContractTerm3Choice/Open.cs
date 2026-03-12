// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ContractTerm3Choice
{
    /// <summary>
    /// Transaction is open term, that is, has no fixed maturity date.
    /// </summary>
    [IsoId("_tKrKca9_EemF0ZVFnxVu4g")]
    [DisplayName("Open")]
    public partial record Open : ContractTerm3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the termination option for a repurchase agreement.
        /// </summary>
        [IsoXmlTag("Opn")]
        public required RepoTerminationOption2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
