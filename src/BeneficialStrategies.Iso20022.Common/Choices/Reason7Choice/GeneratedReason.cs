// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason7Choice
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_E2DtTf4hEeCH9dkaY_DhYw")]
    [DisplayName("Generated Reason")]
    public partial record GeneratedReason : Reason7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GnrtdRsn")]
        public required GeneratedReasons1Choice_ Value { get; init; }
    }
}
