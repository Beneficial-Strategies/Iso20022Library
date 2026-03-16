// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Date99.
/// </summary>
[IsoId("_ynvnoWKOEe6iKbrXdnOlfA")]
[DisplayName("Corporate Action Date99")]
public record CorporateActionDate99
{
    /// <summary>
    /// Earliest Payment Date.
    /// </summary>
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public IsoISODate? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Foreign Exchange Rate Fixing Date.
    /// </summary>
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateAndDateTime2Choice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Payment Date.
    /// </summary>
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public IsoISODate? PaymentDate { get; init; }

    /// <summary>
    /// Posting Date.
    /// </summary>
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTime2Choice_ PostingDate { get; init; }

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public IsoISODate? ValueDate { get; init; }
}
