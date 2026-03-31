// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessing1Choice
{
    /// <summary>
    /// Specifies the reason of the Pending Processing Status.
    /// </summary>
    [IsoId("_Azyp4tokEeC60axPepSq7g_1743305222")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : PendingProcessing1Choice_
    {
        /// <summary>
        /// Specifies the reason why the trade is wainting the affirmation.
        /// </summary>
        [IsoId("_A6MM1NokEeC60axPepSq7g_-1723887712")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AwaitingAffirmationReason1Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_A6MM1dokEeC60axPepSq7g_1687846297")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
