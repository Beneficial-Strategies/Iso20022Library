// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Account8Choice
{
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_Q4z1VNp-Ed-ak6NoX_4Aeg_-1651274766")]
    [DisplayName("Tax Account")]
    public partial record TaxAccount : Account8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TaxAcct")]
        public required CashAccountIdentification5Choice_ Value { get; init; }
    }
}
