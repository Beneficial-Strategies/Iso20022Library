// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosedStatusReason1Choice
{
    /// <summary>
    /// Reason for the closed account status.
    /// </summary>
    [IsoId("_U2WaA0zDEeafiMTDrtSnyw")]
    [DisplayName("Reason")]
    public partial record Reason : ClosedStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the closed account status.
        /// </summary>
        [IsoId("_eUB1YUzDEeafiMTDrtSnyw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ClosedStatusReason2Choice_ Code { get; init; } 
        
        /// <summary>
        /// Additional information about the reason for the closed account status.
        /// </summary>
        [IsoId("_eUB1Y0zDEeafiMTDrtSnyw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
