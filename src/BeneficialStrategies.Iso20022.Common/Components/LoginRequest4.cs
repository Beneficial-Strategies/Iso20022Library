// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Login Request message.
/// </summary>
[IsoId("_ze71QVE8EeyApZmLzm74zA")]
[DisplayName("Login Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoginRequest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoginRequest4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoginRequest4( System.DateTime reqLoginDateTime,string reqCashierLanguage )
    {
        LoginDateTime = reqLoginDateTime;
        CashierLanguage = reqCashierLanguage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and Time of Login.
    /// </summary>
    [IsoId("_zlGHoVE8EeyApZmLzm74zA")]
    [DisplayName("Login Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LgnDtTm")]
    #endif
    [IsoXmlTag("LgnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime LoginDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime LoginDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime LoginDateTime { get; init; } 
    #else
    public System.DateTime LoginDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the software of the Sale System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_zlGHo1E8EeyApZmLzm74zA")]
    [DisplayName("Sale Software")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleSftwr")]
    #endif
    [IsoXmlTag("SaleSftwr")]
    public ValueList<PointOfInteractionComponent12> SaleSoftware { get; init; } = new ValueList<PointOfInteractionComponent12>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _zlGHo1E8EeyApZmLzm74zA
    
    /// <summary>
    /// Information related to the software and hardware feature of the Sale Terminal.
    /// </summary>
    [IsoId("_zlGHpVE8EeyApZmLzm74zA")]
    [DisplayName("Sale Terminal Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleTermnlData")]
    #endif
    [IsoXmlTag("SaleTermnlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleTerminalData1? SaleTerminalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleTerminalData1? SaleTerminalData { get; init; } 
    #else
    public SaleTerminalData1? SaleTerminalData { get; set; } 
    #endif
    
    /// <summary>
    /// Training mode.
    /// </summary>
    [IsoId("_zlGHp1E8EeyApZmLzm74zA")]
    [DisplayName("Training Mode Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrngMdFlg")]
    #endif
    [IsoXmlTag("TrngMdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TrainingModeFlag { get; init; } 
    #else
    public System.String? TrainingModeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cashier.
    /// </summary>
    [IsoId("_zlGHqVE8EeyApZmLzm74zA")]
    [DisplayName("Cashier Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshrId")]
    #endif
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CashierIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashierIdentification { get; init; } 
    #else
    public System.String? CashierIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Language of the cashier.
    /// </summary>
    [IsoId("_zlGHq1E8EeyApZmLzm74zA")]
    [DisplayName("Cashier Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshrLang")]
    #endif
    [IsoXmlTag("CshrLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LanguageCode CashierLanguage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CashierLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CashierLanguage { get; init; } 
    #else
    public string CashierLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// Shift number of the cashier.
    /// </summary>
    [IsoId("_zlGHrVE8EeyApZmLzm74zA")]
    [DisplayName("Shift Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShftNb")]
    #endif
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShiftNumber { get; init; } 
    #else
    public System.String? ShiftNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment mean of the customer.
    /// </summary>
    [IsoId("_zlGHr1E8EeyApZmLzm74zA")]
    [DisplayName("Token Requested Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknReqdTp")]
    #endif
    [IsoXmlTag("TknReqdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 
    #else
    public SaleTokenScope1Code? TokenRequestedType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// </summary>
    [IsoId("_zlGHsVE8EeyApZmLzm74zA")]
    [DisplayName("Customer Order Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdrReq")]
    #endif
    [IsoXmlTag("CstmrOrdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 
    #else
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// POI Terminal identification.
    /// </summary>
    [IsoId("_zlGHs1E8EeyApZmLzm74zA")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentIdentification2? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification2? POIIdentification { get; init; } 
    #else
    public PointOfInteractionComponentIdentification2? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Default group identification for transaction consolidation (Totals).
    /// </summary>
    [IsoId("_zlGHtVE8EeyApZmLzm74zA")]
    [DisplayName("Totals Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlsGrpId")]
    #endif
    [IsoXmlTag("TtlsGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalsGroupIdentification { get; init; } 
    #else
    public System.String? TotalsGroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_zlGHt1E8EeyApZmLzm74zA")]
    [DisplayName("Output Display")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptDisp")]
    #endif
    [IsoXmlTag("OutptDisp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage9? OutputDisplay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage9? OutputDisplay { get; init; } 
    #else
    public ActionMessage9? OutputDisplay { get; set; } 
    #endif
    
    
    #nullable disable
    
}
