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
/// Provides additional information regarding corporate action notification.
/// </summary>
[IsoId("_1ZecFTL3EeKU9IrkkToqcw_-1357737772")]
[DisplayName("Corporate Action Notification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotificationSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNotificationSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotificationSD2( System.String reqPlaceAndName,DerivativeWorkflowStatus1Code reqDerivativeWorkflowStatus,System.String reqDerivativeExchange,System.DateOnly reqDerivativeAdjustmentDate )
    {
        PlaceAndName = reqPlaceAndName;
        DerivativeWorkflowStatus = reqDerivativeWorkflowStatus;
        DerivativeExchange = reqDerivativeExchange;
        DerivativeAdjustmentDate = reqDerivativeAdjustmentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1ZoNEDL3EeKU9IrkkToqcw_-1030441987")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a notice of change.
    /// </summary>
    [IsoId("_1ZoNETL3EeKU9IrkkToqcw_1507237485")]
    [DisplayName("Derivative Workflow Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivWorkflwSts")]
    #endif
    [IsoXmlTag("DerivWorkflwSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativeWorkflowStatus1Code DerivativeWorkflowStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DerivativeWorkflowStatus1Code DerivativeWorkflowStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeWorkflowStatus1Code DerivativeWorkflowStatus { get; init; } 
    #else
    public DerivativeWorkflowStatus1Code DerivativeWorkflowStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange where the derivative is traded.
    /// </summary>
    [IsoId("_1ZoNEjL3EeKU9IrkkToqcw_278246291")]
    [DisplayName("Derivative Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivXchg")]
    #endif
    [IsoXmlTag("DerivXchg")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText DerivativeExchange { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DerivativeExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DerivativeExchange { get; init; } 
    #else
    public System.String DerivativeExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the notice of change to the derivative is published by the exchange.
    /// </summary>
    [IsoId("_1ZoNEzL3EeKU9IrkkToqcw_1623632001")]
    [DisplayName("Derivative Publication Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivPblctnDt")]
    #endif
    [IsoXmlTag("DerivPblctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DerivativePublicationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DerivativePublicationDate { get; init; } 
    #else
    public System.DateOnly? DerivativePublicationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Effective date of the adjustment to the derivative contract.
    /// </summary>
    [IsoId("_1ZoNFDL3EeKU9IrkkToqcw_282377015")]
    [DisplayName("Derivative Adjustment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivAdjstmntDt")]
    #endif
    [IsoXmlTag("DerivAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DerivativeAdjustmentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DerivativeAdjustmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DerivativeAdjustmentDate { get; init; } 
    #else
    public System.DateOnly DerivativeAdjustmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Method (usually a formula) that will be used to calculate the adjustment factor that will be applied to the derivative to account for the impact of a corporate action event on the underlying equity.
    /// </summary>
    [IsoId("_1ZoNFTL3EeKU9IrkkToqcw_-592539143")]
    [DisplayName("Derivative Calculation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivClctnMtd")]
    #endif
    [IsoXmlTag("DerivClctnMtd")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? DerivativeCalculationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DerivativeCalculationMethod { get; init; } 
    #else
    public System.String? DerivativeCalculationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Adjustment factor to be applied to the derivative contract to account for the impact of a corporate action event on the underlying equity. Derived by using the calculation method.
    /// </summary>
    [IsoId("_1ZoNFjL3EeKU9IrkkToqcw_2133733290")]
    [DisplayName("Derivative Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivFctr")]
    #endif
    [IsoXmlTag("DerivFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? DerivativeFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DerivativeFactor { get; init; } 
    #else
    public System.UInt64? DerivativeFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the deliverable stock amount on the derivative contract will be changed.
    /// </summary>
    [IsoId("_1Zx-EDL3EeKU9IrkkToqcw_238505614")]
    [DisplayName("Lot Size Change Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotSzChngFlg")]
    #endif
    [IsoXmlTag("LotSzChngFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LotSizeChangeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LotSizeChangeFlag { get; init; } 
    #else
    public System.String? LotSizeChangeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Method that is used to calculate the new stock deliverable on the derivative contract. Usually multiplication or division by a stated figure but may include explanatory text and examples.
    /// </summary>
    [IsoId("_1Zx-ETL3EeKU9IrkkToqcw_-1956386810")]
    [DisplayName("Lot Adjustment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotAdjstmntMtd")]
    #endif
    [IsoXmlTag("LotAdjstmntMtd")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? LotAdjustmentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LotAdjustmentMethod { get; init; } 
    #else
    public System.String? LotAdjustmentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is a new strike price for the change of the derivative contract as a result of the corporate action.
    /// </summary>
    [IsoId("_1Zx-EjL3EeKU9IrkkToqcw_915856039")]
    [DisplayName("Strike Price Change Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPricChngFlg")]
    #endif
    [IsoXmlTag("StrkPricChngFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StrikePriceChangeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StrikePriceChangeFlag { get; init; } 
    #else
    public System.String? StrikePriceChangeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Method that will be used to adjust the strike price. May include the number of decimal places and rounding rules, example up or down.
    /// </summary>
    [IsoId("_1Zx-EzL3EeKU9IrkkToqcw_-113518360")]
    [DisplayName("Strike Price Rounding Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPricRndgMtd")]
    #endif
    [IsoXmlTag("StrkPricRndgMtd")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? StrikePriceRoundingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StrikePriceRoundingMethod { get; init; } 
    #else
    public System.String? StrikePriceRoundingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a residual cash is paid on the derivative contract. For example, this may be a cash element that is included in the terms of a takeover that the underlying equity is subject to.
    /// </summary>
    [IsoId("_1Zx-FDL3EeKU9IrkkToqcw_1063112730")]
    [DisplayName("Residual Cash Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsdlCshFlg")]
    #endif
    [IsoXmlTag("RsdlCshFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ResidualCashFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResidualCashFlag { get; init; } 
    #else
    public System.String? ResidualCashFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Price of the security to be used in factor calculations. Usually the closing price of the underlying equity on the effective date of the contract adjustment.
    /// </summary>
    [IsoId("_1Zx-FTL3EeKU9IrkkToqcw_-143242492")]
    [DisplayName("Reference Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPric")]
    #endif
    [IsoXmlTag("RefPric")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ReferencePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ReferencePrice { get; init; } 
    #else
    public System.UInt64? ReferencePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Currency associated with the reference price.
    /// </summary>
    [IsoId("_1Zx-FjL3EeKU9IrkkToqcw_1334119961")]
    [DisplayName("Reference Price Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPricCcy")]
    #endif
    [IsoXmlTag("RefPricCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? ReferencePriceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ReferencePriceCurrency { get; init; } 
    #else
    public string? ReferencePriceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative data has/hasn&apos;t been approved by a validation service.
    /// </summary>
    [IsoId("_1Z7IADL3EeKU9IrkkToqcw_-444572123")]
    [DisplayName("Approved Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvdFlg")]
    #endif
    [IsoXmlTag("ApprvdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ApprovedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApprovedFlag { get; init; } 
    #else
    public System.String? ApprovedFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
