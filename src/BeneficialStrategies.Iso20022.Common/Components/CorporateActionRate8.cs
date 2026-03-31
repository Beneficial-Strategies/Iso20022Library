// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_TXznW9p-Ed-ak6NoX_4Aeg_-1470635815")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate8
{
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_TXznXNp-Ed-ak6NoX_4Aeg_-1111386502")]
    [DisplayName("Proposed Rate")]
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProposedRate { get; init; }

    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    [IsoId("_TX8xQNp-Ed-ak6NoX_4Aeg_-856494647")]
    [DisplayName("Oversubscription Rate")]
    [IsoXmlTag("OvrsbcptRate")]
    public RateAndAmountFormat12Choice_? OversubscriptionRate { get; init; }

    /// <summary>
    /// Requested tax rate in case of breakdown of tax rate, for example, used for adjustment of tax rate. This is the new requested applicable rate.
    /// </summary>
    [IsoId("_TX8xQdp-Ed-ak6NoX_4Aeg_-802008412")]
    [DisplayName("Requested Taxation Rate")]
    [IsoXmlTag("ReqdTaxtnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? RequestedTaxationRate { get; init; }
}
