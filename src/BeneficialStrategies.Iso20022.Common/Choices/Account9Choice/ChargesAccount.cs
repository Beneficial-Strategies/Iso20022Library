// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Account9Choice
{
    /// <summary>
    /// Account to be used for charges if different from the account for payment.
    /// </summary>
    [IsoId("_XY_k0Np-Ed-ak6NoX_4Aeg_-1562428108")]
    [DisplayName("Charges Account")]
    public record ChargesAccount : Account9Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ChrgsAcct")]
        public required CashAccountIdentification6Choice_ Value { get; init; }
    }
}
