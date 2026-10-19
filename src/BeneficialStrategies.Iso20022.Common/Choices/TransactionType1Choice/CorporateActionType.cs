// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionType1Choice
{
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_RF4ZcAf_EeSaceXTzyiZRg")]
    [DisplayName("Corporate Action Type")]
    public partial record CorporateActionType : TransactionType1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CorpActnTp")]
        public required CorporateAction1Choice_ Value { get; init; }
    }
}
