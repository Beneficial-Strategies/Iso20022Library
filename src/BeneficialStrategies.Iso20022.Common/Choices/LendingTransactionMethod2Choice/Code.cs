// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LendingTransactionMethod2Choice
{
    /// <summary>
    /// Lending transaction method expressed as a ISO20022 code.
    /// </summary>
    [IsoId("_2cgUcZEjEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public partial record Code : LendingTransactionMethod2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Lending method applied to the securities financing contract.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LendingTransactionMethod1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
