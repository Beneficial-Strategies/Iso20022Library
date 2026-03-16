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
[IsoId("_PyBzd9p-Ed-ak6NoX_4Aeg_194999115")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction22
{
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer or investment account.
    /// </summary>
    [IsoId("_PyLkcNp-Ed-ak6NoX_4Aeg_194999578")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public PaymentInstrument11Choice_? PaymentInstrument { get; init; }
}
