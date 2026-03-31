// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terms and conditions related to a single invoice to be financed.
/// </summary>
[IsoId("_PyxaV9p-Ed-ak6NoX_4Aeg_-1837581386")]
[DisplayName("Payment Information")]
public record PaymentInformation15
{
    /// <summary>
    /// Payment method that will be used for invoice payment to transfer the funds to the creditor.
    /// </summary>
    [IsoId("_Py7LUNp-Ed-ak6NoX_4Aeg_-1837581384")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod4Code PaymentMethod { get; init; }

    /// <summary>
    /// Unambiguous identification of the account used for payment settlement.
    /// </summary>
    [IsoId("_Py7LUdp-Ed-ak6NoX_4Aeg_-102369781")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public CashAccount7? PaymentAccount { get; init; }
}
