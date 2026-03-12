// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BPOApplicableRules1Choice
{
    /// <summary>
    /// URBPO are rules that apply to a BPO when the Payment Obligation Segment within an Established Baseline expressly states that it is subject to these rules or when each Involved Bank agrees in a separate agreement that a BPO is subject to these rules. If an Established Baseline or separate agreement does not indicate the applicable version of URBPO, the BPO will be subject to the latest version in effect when the Baseline is established in accordance with sub-article 9 (d).
    /// </summary>
    [IsoId("_8mcMkNNqEeKdOs2hjJ_3WQ")]
    [DisplayName("URBPO Version")]
    public partial record URBPOVersion : BPOApplicableRules1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("URBPOVrsn")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
