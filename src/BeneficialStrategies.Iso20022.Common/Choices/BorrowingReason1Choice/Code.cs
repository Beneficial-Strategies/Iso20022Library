// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BorrowingReason1Choice
{
    /// <summary>
    /// Borrowing reason expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AYq0ItokEeC60axPepSq7g_1044047179")]
    [DisplayName("Code")]
    public partial record Code : BorrowingReason1Choice_
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
