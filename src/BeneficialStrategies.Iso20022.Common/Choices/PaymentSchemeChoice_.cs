// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pre-agreed offering between clearing agents, or the channel through which the payment instruction is to be processed. This payment scheme can point to a specific rulebook governing the rules of clearing and settlement between two parties.
    /// </summary>
    [KnownType(typeof(PaymentSchemeChoice.Code))]
    [KnownType(typeof(PaymentSchemeChoice.ProprietaryInformation))]
    [JsonDerivedType(typeof(PaymentSchemeChoice.Code),nameof(PaymentSchemeChoice.Code))]
    [JsonDerivedType(typeof(PaymentSchemeChoice.ProprietaryInformation),nameof(PaymentSchemeChoice.ProprietaryInformation))]
    [IsoId("_QHyBDtp-Ed-ak6NoX_4Aeg_-1186600108")]
    [DisplayName("Payment Scheme Choice")]
    public abstract partial record PaymentSchemeChoice_
    {
    }
}
