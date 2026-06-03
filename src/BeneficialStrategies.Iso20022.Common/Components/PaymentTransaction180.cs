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
[IsoId("6eb2ecfb-507a-42b1-b1a1-e57b49f9b98e")]
[DisplayName("Payment Transaction180")]
public record PaymentTransaction180
{
    /// <summary>
    /// Choice between types of payment instrument, for example, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [IsoId("911f3933-2493-4b33-8371-2b1704006572")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument29Choice PaymentInstrument { get; init; }
}
