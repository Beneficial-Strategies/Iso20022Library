// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BorrowingReason2Choice
{
    /// <summary>
    /// Borrowing reason expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_7dQRgZEjEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public partial record Code : BorrowingReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the underlying reason for the borrowing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BorrowingReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
