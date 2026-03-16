// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Login Request6.
/// </summary>
[IsoId("_BYh2kZFOEe6reqfAp4CunQ")]
[DisplayName("Login Request6")]
public partial record LoginRequest6
{
    #nullable enable

    /// <summary>
    /// Cashier Identification.
    /// </summary>
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    public IsoMax35Text? CashierIdentification { get; init; } 

    /// <summary>
    /// Cashier Language.
    /// </summary>
    [DisplayName("Cashier Language")]
    [IsoXmlTag("CshrLang")]
    public required LanguageCode CashierLanguage { get; init; } 

    /// <summary>
    /// Customer Order Request.
    /// </summary>
    [DisplayName("Customer Order Request")]
    [IsoXmlTag("CstmrOrdrReq")]
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 

    /// <summary>
    /// Login Date Time.
    /// </summary>
    [DisplayName("Login Date Time")]
    [IsoXmlTag("LgnDtTm")]
    public required IsoISODateTime LoginDateTime { get; init; } 

    /// <summary>
    /// Output Display.
    /// </summary>
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage11? OutputDisplay { get; init; } 

    /// <summary>
    /// POI Identification.
    /// </summary>
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public PointOfInteractionComponentIdentification2? POIIdentification { get; init; } 

    /// <summary>
    /// Sale Software.
    /// </summary>
    [DisplayName("Sale Software")]
    [IsoXmlTag("SaleSftwr")]
    public ValueList<PointOfInteractionComponent15> SaleSoftware { get; init; } = [];

    /// <summary>
    /// Sale Terminal Data.
    /// </summary>
    [DisplayName("Sale Terminal Data")]
    [IsoXmlTag("SaleTermnlData")]
    public SaleTerminalData1? SaleTerminalData { get; init; } 

    /// <summary>
    /// Shift Number.
    /// </summary>
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    public IsoMax2NumericText? ShiftNumber { get; init; } 

    /// <summary>
    /// Token Requested Type.
    /// </summary>
    [DisplayName("Token Requested Type")]
    [IsoXmlTag("TknReqdTp")]
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 

    /// <summary>
    /// Totals Group Identification.
    /// </summary>
    [DisplayName("Totals Group Identification")]
    [IsoXmlTag("TtlsGrpId")]
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 

    /// <summary>
    /// Training Mode Flag.
    /// </summary>
    [DisplayName("Training Mode Flag")]
    [IsoXmlTag("TrngMdFlg")]
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; } 

    
    #nullable disable
    
}
