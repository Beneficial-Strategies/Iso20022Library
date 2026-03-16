// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Automatic extension information.
/// </summary>
[IsoId("_95V5dnltEeG7BsjMvd1mEw_1894661864")]
[DisplayName("Auto Extension")]
public record AutoExtension1
{
    /// <summary>
    /// Indicates that the undertaking is automatically extendable and the period of extension.
    /// </summary>
    [IsoId("_95V5d3ltEeG7BsjMvd1mEw_742198140")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public AutoExtend1Choice_? Period { get; init; }

    /// <summary>
    /// Final expiry date after which the undertaking will no longer be subject to automatic extension.
    /// </summary>
    [IsoId("_95V5eHltEeG7BsjMvd1mEw_-211951579")]
    [DisplayName("Final Expiry Date")]
    [IsoXmlTag("FnlXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalExpiryDate { get; init; }

    /// <summary>
    /// Details related to the notification of the end of the period for notification of non-extension of the expiry date.
    /// </summary>
    [IsoId("_95V5eXltEeG7BsjMvd1mEw_-1641257680")]
    [DisplayName("Non Extension Notification")]
    [IsoXmlTag("NonXtnsnNtfctn")]
    public NonExtension1? NonExtensionNotification { get; init; }
}
