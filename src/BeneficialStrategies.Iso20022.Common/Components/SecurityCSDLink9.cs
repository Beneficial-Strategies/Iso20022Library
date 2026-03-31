// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security CSD Link9.
/// </summary>
[IsoId("_yhSS0Wc-EemvNLufWGIVOQ")]
[DisplayName("Security CSD Link9")]
public record SecurityCSDLink9
{
    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Issuer Investor CSD.
    /// </summary>
    [DisplayName("Issuer Investor CSD")]
    [IsoXmlTag("IssrInvstrCSD")]
    public required IssuerOrInvestor2Choice_ IssuerInvestorCSD { get; init; }

    /// <summary>
    /// Valid From.
    /// </summary>
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public required DateAndDateTime2Choice_ ValidFrom { get; init; }
}
