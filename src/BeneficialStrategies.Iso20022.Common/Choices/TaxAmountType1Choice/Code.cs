// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxAmountType1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_tsra01kyEeGeoaLUQk__nA_1392476130")]
    [DisplayName("Code")]
    public partial record Code : TaxAmountType1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalTaxAmountType1Code Value { get; init; }
    }
}
