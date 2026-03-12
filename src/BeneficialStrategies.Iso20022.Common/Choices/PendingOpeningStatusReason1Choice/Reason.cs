// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingOpeningStatusReason1Choice
{
    /// <summary>
    /// Reason for the pending account opening status.
    /// </summary>
    [IsoId("_g7Miw2CJEeabZtzjEVWYCQ")]
    [DisplayName("Reason")]
    public partial record Reason : PendingOpeningStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the pending account opening status.
        /// </summary>
        [IsoId("_nyhm8WCJEeabZtzjEVWYCQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingOpeningStatusReason2Choice_ Code { get; init; } 
        
        /// <summary>
        /// Additional information about the reason for the pending account opening status.
        /// </summary>
        [IsoId("_nyhm82CJEeabZtzjEVWYCQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
