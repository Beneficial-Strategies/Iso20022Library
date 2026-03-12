// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus90Choice
{
    /// <summary>
    /// Modification request from your counterparty for this transaction is pending waiting for your cancellation request or your consent.
    /// </summary>
    [IsoId("_ddARfDi8Eeydid5dcNPKvg")]
    [DisplayName("Modification Requested")]
    public partial record ModificationRequested : ProcessingStatus90Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the reason related to a status.
        /// </summary>
        [IsoId("_ceme3ZKQEeWHWpTQn1FFVg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public GenericIdentification47? Reason { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_ceme5ZKQEeWHWpTQn1FFVg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
