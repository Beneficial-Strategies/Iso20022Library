// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Login Request message.
/// </summary>
[IsoId("_ze71QVE8EeyApZmLzm74zA")]
[DisplayName("Login Request")]
public partial record LoginRequest4
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of Login.
    /// </summary>
    [IsoId("_zlGHoVE8EeyApZmLzm74zA")]
    [DisplayName("Login Date Time")]
    [IsoXmlTag("LgnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LoginDateTime { get; init; } 
    
    /// <summary>
    /// Information related to the software of the Sale System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_zlGHo1E8EeyApZmLzm74zA")]
    [DisplayName("Sale Software")]
    [IsoXmlTag("SaleSftwr")]
    public ValueList<PointOfInteractionComponent12> SaleSoftware { get; init; } = [];
    // ID for the above is _zlGHo1E8EeyApZmLzm74zA
    
    /// <summary>
    /// Information related to the software and hardware feature of the Sale Terminal.
    /// </summary>
    [IsoId("_zlGHpVE8EeyApZmLzm74zA")]
    [DisplayName("Sale Terminal Data")]
    [IsoXmlTag("SaleTermnlData")]
    public SaleTerminalData1? SaleTerminalData { get; init; } 
    
    /// <summary>
    /// Training mode.
    /// </summary>
    [IsoId("_zlGHp1E8EeyApZmLzm74zA")]
    [DisplayName("Training Mode Flag")]
    [IsoXmlTag("TrngMdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; } 
    
    /// <summary>
    /// Identification of the cashier.
    /// </summary>
    [IsoId("_zlGHqVE8EeyApZmLzm74zA")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; } 
    
    /// <summary>
    /// Language of the cashier.
    /// </summary>
    [IsoId("_zlGHq1E8EeyApZmLzm74zA")]
    [DisplayName("Cashier Language")]
    [IsoXmlTag("CshrLang")]
    public required LanguageCode CashierLanguage { get; init; } 
    
    /// <summary>
    /// Shift number of the cashier.
    /// </summary>
    [IsoId("_zlGHrVE8EeyApZmLzm74zA")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    
    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment mean of the customer.
    /// </summary>
    [IsoId("_zlGHr1E8EeyApZmLzm74zA")]
    [DisplayName("Token Requested Type")]
    [IsoXmlTag("TknReqdTp")]
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 
    
    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// </summary>
    [IsoId("_zlGHsVE8EeyApZmLzm74zA")]
    [DisplayName("Customer Order Request")]
    [IsoXmlTag("CstmrOrdrReq")]
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 
    
    /// <summary>
    /// POI Terminal identification.
    /// </summary>
    [IsoId("_zlGHs1E8EeyApZmLzm74zA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public PointOfInteractionComponentIdentification2? POIIdentification { get; init; } 
    
    /// <summary>
    /// Default group identification for transaction consolidation (Totals).
    /// </summary>
    [IsoId("_zlGHtVE8EeyApZmLzm74zA")]
    [DisplayName("Totals Group Identification")]
    [IsoXmlTag("TtlsGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_zlGHt1E8EeyApZmLzm74zA")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage9? OutputDisplay { get; init; } 
    
    
    #nullable disable
    
}
