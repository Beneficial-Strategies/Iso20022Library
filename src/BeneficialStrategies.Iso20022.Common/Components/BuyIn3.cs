// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies elements related to the response sent by the clearing member to the central counterparty in the context of the buy in process.
/// </summary>
[IsoId("_Uo3mk9p-Ed-ak6NoX_4Aeg_392375521")]
[DisplayName("Buy In")]
public record BuyIn3
{
    /// <summary>
    /// Indicates the reference of the BuyInNotification message.
    /// </summary>
    [IsoId("_Uo3mlNp-Ed-ak6NoX_4Aeg_903405859")]
    [DisplayName("Buy In Notification Identification")]
    [IsoXmlTag("BuyInNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BuyInNotificationIdentification { get; init; }

    /// <summary>
    /// Specific continuous net settlement case where the central counterparty can call for buy-in at a date anterior to &quot;theoretical&quot; buy-in date, the clearing member may request a delay.
    /// </summary>
    [IsoId("_Uo3mldp-Ed-ak6NoX_4Aeg_-1794174189")]
    [DisplayName("Request For Delay Indicator")]
    [IsoXmlTag("ReqForDelyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RequestForDelayIndicator { get; init; }

    /// <summary>
    /// Number of days associated to the request for delay.
    /// </summary>
    [IsoId("_Uo3mltp-Ed-ak6NoX_4Aeg_755179045")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfDays { get; init; }

    /// <summary>
    /// Buy in quantity called initially by the central counterparty.
    /// </summary>
    [IsoId("_Uo3ml9p-Ed-ak6NoX_4Aeg_-1486972163")]
    [DisplayName("Initial Quantity")]
    [IsoXmlTag("InitlQty")]
    public required FinancialInstrumentQuantity1Choice_ InitialQuantity { get; init; }

    /// <summary>
    /// Quantity amount covered by the clearing member after notification.
    /// </summary>
    [IsoId("_Uo3mmNp-Ed-ak6NoX_4Aeg_-1479836456")]
    [DisplayName("Covered Quantity")]
    [IsoXmlTag("CvrdQty")]
    public required FinancialInstrumentQuantity1Choice_ CoveredQuantity { get; init; }

    /// <summary>
    /// Quantity amount non covered by the clearing member after notification (this is, new buy in amount to be executed).
    /// </summary>
    [IsoId("_Uo3mmdp-Ed-ak6NoX_4Aeg_-657470426")]
    [DisplayName("Uncovered Quantity")]
    [IsoXmlTag("UcvrdQty")]
    public required FinancialInstrumentQuantity1Choice_ UncoveredQuantity { get; init; }
}
