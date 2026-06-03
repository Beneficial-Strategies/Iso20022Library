// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the login request message.
/// </summary>
[IsoId("_5706cbZcEfCUZfsQO4rYeA")]
[DisplayName("Login Request8")]
public record LoginRequest8
{
    /// <summary>
    /// Date and time of login.
    /// </summary>
    [IsoId("_58wHhbZcEfCUZfsQO4rYeA")]
    [DisplayName("Login Date Time")]
    [IsoXmlTag("LgnDtTm")]
    public required IsoISODateTime LoginDateTime { get; init; }

    /// <summary>
    /// Information related to the software of the Sale System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_58wHi7ZcEfCUZfsQO4rYeA")]
    [DisplayName("Sale Software")]
    [IsoXmlTag("SaleSftwr")]
    [MinLength(1)]
    public ValueList<PointOfInteractionComponent18> SaleSoftware { get; init; } = [];

    /// <summary>
    /// Information related to the software and hardware feature of the Sale Terminal.
    /// </summary>
    [IsoId("_58wHkbZcEfCUZfsQO4rYeA")]
    [DisplayName("Sale Terminal Data")]
    [IsoXmlTag("SaleTermnlData")]
    public SaleTerminalData1? SaleTerminalData { get; init; }

    /// <summary>
    /// Training mode.
    /// </summary>
    [IsoId("_58wHl7ZcEfCUZfsQO4rYeA")]
    [DisplayName("Training Mode Flag")]
    [IsoXmlTag("TrngMdFlg")]
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; }

    /// <summary>
    /// Identification of the cashier.
    /// </summary>
    [IsoId("_58wHnbZcEfCUZfsQO4rYeA")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    public IsoMax35Text? CashierIdentification { get; init; }

    /// <summary>
    /// Language of the cashier.
    /// </summary>
    [IsoId("_58wHo7ZcEfCUZfsQO4rYeA")]
    [DisplayName("Cashier Language")]
    [IsoXmlTag("CshrLang")]
    public required LanguageCode CashierLanguage { get; init; }

    /// <summary>
    /// Shift number of the cashier.
    /// </summary>
    [IsoId("_58wHqbZcEfCUZfsQO4rYeA")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    public IsoMax2NumericText? ShiftNumber { get; init; }

    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment mean of the customer.
    /// </summary>
    [IsoId("_58wHr7ZcEfCUZfsQO4rYeA")]
    [DisplayName("Token Requested Type")]
    [IsoXmlTag("TknReqdTp")]
    public SaleTokenScope1Code? TokenRequestedType { get; init; }

    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// </summary>
    [IsoId("_58wHtbZcEfCUZfsQO4rYeA")]
    [DisplayName("Customer Order Request")]
    [IsoXmlTag("CstmrOrdrReq")]
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; }

    /// <summary>
    /// POI terminal identification.
    /// </summary>
    [IsoId("_58wHu7ZcEfCUZfsQO4rYeA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public PointOfInteractionComponentIdentification2? POIIdentification { get; init; }

    /// <summary>
    /// Default group identification for transaction consolidation (Totals).
    /// </summary>
    [IsoId("_58wHwbZcEfCUZfsQO4rYeA")]
    [DisplayName("Totals Group Identification")]
    [IsoXmlTag("TtlsGrpId")]
    public IsoMax35Text? TotalsGroupIdentification { get; init; }

    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_58wHx7ZcEfCUZfsQO4rYeA")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage12? OutputDisplay { get; init; }
}
