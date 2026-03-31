// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentRole1Choice
{
    /// <summary>
    /// Payment party role, in a coded form.
    /// </summary>
    [IsoId("_b_Ox1XhiEeidzqjNEfehPg")]
    [DisplayName("Code")]
    public record Code : PaymentRole1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPaymentRole1Code Value { get; init; }
    }
}
