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
[IsoId("_0j084N6HEeiwsev40qZGEQ")]
[DisplayName("Login Request")]
public partial record LoginRequest1
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of Login.
    /// </summary>
    [IsoId("_-tvzMN6HEeiwsev40qZGEQ")]
    [DisplayName("Login Date Time")]
    [IsoXmlTag("LgnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LoginDateTime { get; init; } 
    
    /// <summary>
    /// Information related to the software of the Sale System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_I-ylMN6IEeiwsev40qZGEQ")]
    [DisplayName("Sale Software")]
    [IsoXmlTag("SaleSftwr")]
    public ValueList<PointOfInteractionComponent9> SaleSoftware { get; init; } = new ValueList<PointOfInteractionComponent9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _I-ylMN6IEeiwsev40qZGEQ
    
    /// <summary>
    /// Information related to the software and hardware feature of the Sale Terminal.
    /// </summary>
    [IsoId("_LrNvMN6IEeiwsev40qZGEQ")]
    [DisplayName("Sale Terminal Data")]
    [IsoXmlTag("SaleTermnlData")]
    public SaleTerminalData1? SaleTerminalData { get; init; } 
    
    /// <summary>
    /// Training mode.
    /// </summary>
    [IsoId("_jD8wMN6IEeiwsev40qZGEQ")]
    [DisplayName("Training Mode Flag")]
    [IsoXmlTag("TrngMdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; } 
    
    /// <summary>
    /// Identification of the cashier.
    /// </summary>
    [IsoId("_mX07wN6IEeiwsev40qZGEQ")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; } 
    
    /// <summary>
    /// Language of the cashier.
    /// </summary>
    [IsoId("_olK9EN6IEeiwsev40qZGEQ")]
    [DisplayName("Cashier Language")]
    [IsoXmlTag("CshrLang")]
    public required LanguageCode CashierLanguage { get; init; } 
    
    /// <summary>
    /// Shift number of the cashier.
    /// </summary>
    [IsoId("_r0RWUN6IEeiwsev40qZGEQ")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    
    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment mean of the customer.
    /// </summary>
    [IsoId("_uR85sN6IEeiwsev40qZGEQ")]
    [DisplayName("Token Requested Type")]
    [IsoXmlTag("TknReqdTp")]
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 
    
    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// </summary>
    [IsoId("_B_s2sN6JEeiwsev40qZGEQ")]
    [DisplayName("Customer Order Request")]
    [IsoXmlTag("CstmrOrdrReq")]
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 
    
    /// <summary>
    /// POI Terminal identification.
    /// </summary>
    [IsoId("_cGnVMN6JEeiwsev40qZGEQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public PointOfInteractionComponentIdentification1? POIIdentification { get; init; } 
    
    /// <summary>
    /// Default group identification for transaction consolidation (Totals).
    /// </summary>
    [IsoId("_fMrHMN6JEeiwsev40qZGEQ")]
    [DisplayName("Totals Group Identification")]
    [IsoXmlTag("TtlsGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 
    
    
    #nullable disable
    
}
