// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("7d70bb2f-cf3b-4e54-bc4d-81e9855e74c2")]
[DisplayName("Payment Transaction167")]
public record PaymentTransaction167
{
    /// <summary>
    /// Choice between types of payment instrument, for example, cheque, credit transfer or investment account.
    /// </summary>
    [IsoId("ba4697d6-4517-452b-9caf-40406bf916c9")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument28Choice PaymentInstrument { get; init; }
}
