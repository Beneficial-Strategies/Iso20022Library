// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to an account.
/// </summary>
[IsoId("_w9aBcO19Eei-V5h0ja04AA")]
[DisplayName("Payment Account")]
public record PaymentAccount2
{
    /// <summary>
    /// Currency of a Payment Account.
    /// </summary>
    [IsoId("_9cCsYO19Eei-V5h0ja04AA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Balance of a Payment Account
    /// </summary>
    [IsoId("_Cmn64O1-Eei-V5h0ja04AA")]
    [DisplayName("Current Balance")]
    [IsoXmlTag("CurBal")]
    public ImpliedCurrencyAndAmount? CurrentBalance { get; init; }

    /// <summary>
    /// Detail of Acquirer.
    /// </summary>
    [IsoId("_HMWv4O1-Eei-V5h0ja04AA")]
    [DisplayName("Payment Acquirer Data")]
    [IsoXmlTag("PmtAcqrrData")]
    public Acquirer9? PaymentAcquirerData { get; init; }
}
