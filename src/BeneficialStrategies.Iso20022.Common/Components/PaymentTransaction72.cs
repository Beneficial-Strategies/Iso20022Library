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
[IsoId("_6GsLuTbsEead9bDRE_1DAQ")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction72
{
    /// <summary>
    /// Choice between types of payment instrument, for example, cheque, credit transfer or investment account.
    /// </summary>
    [IsoId("_6fPOdTbsEead9bDRE_1DAQ")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument21Choice_ PaymentInstrument { get; init; }
}
