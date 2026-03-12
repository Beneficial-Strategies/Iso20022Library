// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingReason1Choice
{
    /// <summary>
    /// Specifies the reason of the UnmatchStatus.
    /// </summary>
    [IsoId("_Az7z1NokEeC60axPepSq7g_-166563219")]
    [DisplayName("Reason")]
    public partial record Reason : MatchingReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_A4s_E9okEeC60axPepSq7g_2038515075")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnmatchedReason7Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_A4s_FNokEeC60axPepSq7g_-2004360679")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
