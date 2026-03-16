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
[IsoId("_PyBzc9p-Ed-ak6NoX_4Aeg_1543276374")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction24
{
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [IsoId("_PyBzdNp-Ed-ak6NoX_4Aeg_1543277116")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public PaymentInstrument12Choice_? PaymentInstrument { get; init; }
}
