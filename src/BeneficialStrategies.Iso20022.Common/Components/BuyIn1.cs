// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies elements related to the notification (or warn) sent by the central counterparty to the clearing member in the context of the buy in process.
/// </summary>
[IsoId("_UpAwgNp-Ed-ak6NoX_4Aeg_-2773741")]
[DisplayName("Buy In1")]
[Obsolete("Obsolete per ISO 20022 specification.")]
public record BuyIn1
{
    /// <summary>
    /// Indicates whether the message is a warning only or a notification.
    /// </summary>
    [IsoId("_UpAwgdp-Ed-ak6NoX_4Aeg_-821727422")]
    [DisplayName("Warning Indicator")]
    [IsoXmlTag("WrngInd")]
    public IsoYesNoIndicator? WarningIndicator { get; init; }

    /// <summary>
    /// Provides the date at which the buy will occur.
    /// </summary>
    [IsoId("_UpAwgtp-Ed-ak6NoX_4Aeg_1187137430")]
    [DisplayName("Expected Buy In Date")]
    [IsoXmlTag("XpctdBuyInDt")]
    public required DateFormat15Choice ExpectedBuyInDate { get; init; }
}
