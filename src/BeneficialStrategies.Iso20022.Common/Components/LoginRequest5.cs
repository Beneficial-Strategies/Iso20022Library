// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the login request message.
/// </summary>
[IsoId("_VcsBMXIkEe299ZbWCkdR_w")]
[DisplayName("Login Request")]
public partial record LoginRequest5
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of Login.
    /// </summary>
    [IsoId("_Vj74sXIkEe299ZbWCkdR_w")]
    [DisplayName("Login Date Time")]
    [IsoXmlTag("LgnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LoginDateTime { get; init; } 
    
    /// <summary>
    /// Information related to the software of the Sale System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_Vj74s3IkEe299ZbWCkdR_w")]
    [DisplayName("Sale Software")]
    [IsoXmlTag("SaleSftwr")]
    public ValueList<PointOfInteractionComponent14> SaleSoftware { get; init; } = new ValueList<PointOfInteractionComponent14>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Vj74s3IkEe299ZbWCkdR_w
    
    /// <summary>
    /// Information related to the software and hardware feature of the Sale Terminal.
    /// </summary>
    [IsoId("_Vj74tXIkEe299ZbWCkdR_w")]
    [DisplayName("Sale Terminal Data")]
    [IsoXmlTag("SaleTermnlData")]
    public SaleTerminalData1? SaleTerminalData { get; init; } 
    
    /// <summary>
    /// Training mode.
    /// </summary>
    [IsoId("_Vj74t3IkEe299ZbWCkdR_w")]
    [DisplayName("Training Mode Flag")]
    [IsoXmlTag("TrngMdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; } 
    
    /// <summary>
    /// Identification of the cashier.
    /// </summary>
    [IsoId("_Vj74uXIkEe299ZbWCkdR_w")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; } 
    
    /// <summary>
    /// Language of the cashier.
    /// </summary>
    [IsoId("_Vj8fwXIkEe299ZbWCkdR_w")]
    [DisplayName("Cashier Language")]
    [IsoXmlTag("CshrLang")]
    public required LanguageCode CashierLanguage { get; init; } 
    
    /// <summary>
    /// Shift number of the cashier.
    /// </summary>
    [IsoId("_Vj9G0XIkEe299ZbWCkdR_w")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    
    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment mean of the customer.
    /// </summary>
    [IsoId("_Vj9G03IkEe299ZbWCkdR_w")]
    [DisplayName("Token Requested Type")]
    [IsoXmlTag("TknReqdTp")]
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 
    
    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// </summary>
    [IsoId("_Vj9G1XIkEe299ZbWCkdR_w")]
    [DisplayName("Customer Order Request")]
    [IsoXmlTag("CstmrOrdrReq")]
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 
    
    /// <summary>
    /// POI Terminal identification.
    /// </summary>
    [IsoId("_Vj9G13IkEe299ZbWCkdR_w")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public PointOfInteractionComponentIdentification2? POIIdentification { get; init; } 
    
    /// <summary>
    /// Default group identification for transaction consolidation (Totals).
    /// </summary>
    [IsoId("_Vj9G2XIkEe299ZbWCkdR_w")]
    [DisplayName("Totals Group Identification")]
    [IsoXmlTag("TtlsGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_Vj9G23IkEe299ZbWCkdR_w")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage10? OutputDisplay { get; init; } 
    
    
    #nullable disable
    
}
