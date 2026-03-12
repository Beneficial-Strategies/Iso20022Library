// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosurePendingStatusReason1Choice
{
    /// <summary>
    /// Reason for the closure pending status.
    /// </summary>
    [IsoId("_UwXSs2CLEeabZtzjEVWYCQ")]
    [DisplayName("Reason")]
    public partial record Reason : ClosurePendingStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the closure pending status.
        /// </summary>
        [IsoId("_1EL_YWCLEeabZtzjEVWYCQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ClosurePendingStatusReason2Choice_ Code { get; init; } 
        
        /// <summary>
        /// Additional information about the reason for the closure pending status.
        /// </summary>
        [IsoId("_1EL_Y2CLEeabZtzjEVWYCQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
