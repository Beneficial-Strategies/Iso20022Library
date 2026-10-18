// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDate32Choice
{
    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_vE8fbc32Eee5nJBZsW8MFQ")]
    [DisplayName("Date")]
    public partial record Date : SettlementDate32Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dt")]
        public required DateAndDateTime2Choice_ Value { get; init; }
    }
}
