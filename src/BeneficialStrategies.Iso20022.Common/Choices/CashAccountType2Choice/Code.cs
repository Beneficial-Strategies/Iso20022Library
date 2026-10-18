// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_sb6WgVkyEeGeoaLUQk__nA_-1937269286")]
    [DisplayName("Code")]
    public partial record Code : CashAccountType2Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalCashAccountType1Code Value { get; init; }
    }
}
