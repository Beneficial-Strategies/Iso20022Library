// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash premium made available if the securities holder consents or participates to an event.
/// </summary>
[IsoId("_uOfjUfNBEeqRfth943bvEA")]
[DisplayName("Incentive Premium")]
public record IncentivePremium5
{
    /// <summary>
    /// Description of the premium.
    /// </summary>
    [IsoId("_ui4e8_NBEeqRfth943bvEA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; }

    /// <summary>
    /// Cash premium paid per security, per vote or per attendee.
    /// </summary>
    [IsoId("_ui4e9fNBEeqRfth943bvEA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required PriceRateOrAmount3Choice_ Amount { get; init; }

    /// <summary>
    /// Specifies which voting related criteria gives rights to an incentive premium.
    /// </summary>
    [IsoId("_ui4e9_NBEeqRfth943bvEA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IncentivePremiumType2Choice_ Type { get; init; }

    /// <summary>
    /// Date/time for the payment of the premium.
    /// </summary>
    [IsoId("_ui4e-fNBEeqRfth943bvEA")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat3Choice_? PaymentDate { get; init; }
}
