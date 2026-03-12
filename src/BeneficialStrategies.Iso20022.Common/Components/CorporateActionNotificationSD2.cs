// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action notification.
/// </summary>
[IsoId("_1ZecFTL3EeKU9IrkkToqcw_-1357737772")]
[DisplayName("Corporate Action Notification SD")]
public partial record CorporateActionNotificationSD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1ZoNEDL3EeKU9IrkkToqcw_-1030441987")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Status of a notice of change.
    /// </summary>
    [IsoId("_1ZoNETL3EeKU9IrkkToqcw_1507237485")]
    [DisplayName("Derivative Workflow Status")]
    [IsoXmlTag("DerivWorkflwSts")]
    public required DerivativeWorkflowStatus1Code DerivativeWorkflowStatus { get; init; } 
    
    /// <summary>
    /// Exchange where the derivative is traded.
    /// </summary>
    [IsoId("_1ZoNEjL3EeKU9IrkkToqcw_278246291")]
    [DisplayName("Derivative Exchange")]
    [IsoXmlTag("DerivXchg")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText DerivativeExchange { get; init; } 
    
    /// <summary>
    /// Date when the notice of change to the derivative is published by the exchange.
    /// </summary>
    [IsoId("_1ZoNEzL3EeKU9IrkkToqcw_1623632001")]
    [DisplayName("Derivative Publication Date")]
    [IsoXmlTag("DerivPblctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DerivativePublicationDate { get; init; } 
    
    /// <summary>
    /// Effective date of the adjustment to the derivative contract.
    /// </summary>
    [IsoId("_1ZoNFDL3EeKU9IrkkToqcw_282377015")]
    [DisplayName("Derivative Adjustment Date")]
    [IsoXmlTag("DerivAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DerivativeAdjustmentDate { get; init; } 
    
    /// <summary>
    /// Method (usually a formula) that will be used to calculate the adjustment factor that will be applied to the derivative to account for the impact of a corporate action event on the underlying equity.
    /// </summary>
    [IsoId("_1ZoNFTL3EeKU9IrkkToqcw_-592539143")]
    [DisplayName("Derivative Calculation Method")]
    [IsoXmlTag("DerivClctnMtd")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? DerivativeCalculationMethod { get; init; } 
    
    /// <summary>
    /// Adjustment factor to be applied to the derivative contract to account for the impact of a corporate action event on the underlying equity. Derived by using the calculation method.
    /// </summary>
    [IsoId("_1ZoNFjL3EeKU9IrkkToqcw_2133733290")]
    [DisplayName("Derivative Factor")]
    [IsoXmlTag("DerivFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? DerivativeFactor { get; init; } 
    
    /// <summary>
    /// Indicates whether the deliverable stock amount on the derivative contract will be changed.
    /// </summary>
    [IsoId("_1Zx-EDL3EeKU9IrkkToqcw_238505614")]
    [DisplayName("Lot Size Change Flag")]
    [IsoXmlTag("LotSzChngFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LotSizeChangeFlag { get; init; } 
    
    /// <summary>
    /// Method that is used to calculate the new stock deliverable on the derivative contract. Usually multiplication or division by a stated figure but may include explanatory text and examples.
    /// </summary>
    [IsoId("_1Zx-ETL3EeKU9IrkkToqcw_-1956386810")]
    [DisplayName("Lot Adjustment Method")]
    [IsoXmlTag("LotAdjstmntMtd")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? LotAdjustmentMethod { get; init; } 
    
    /// <summary>
    /// Indicates whether there is a new strike price for the change of the derivative contract as a result of the corporate action.
    /// </summary>
    [IsoId("_1Zx-EjL3EeKU9IrkkToqcw_915856039")]
    [DisplayName("Strike Price Change Flag")]
    [IsoXmlTag("StrkPricChngFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StrikePriceChangeFlag { get; init; } 
    
    /// <summary>
    /// Method that will be used to adjust the strike price. May include the number of decimal places and rounding rules, example up or down.
    /// </summary>
    [IsoId("_1Zx-EzL3EeKU9IrkkToqcw_-113518360")]
    [DisplayName("Strike Price Rounding Method")]
    [IsoXmlTag("StrkPricRndgMtd")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? StrikePriceRoundingMethod { get; init; } 
    
    /// <summary>
    /// Indicates whether a residual cash is paid on the derivative contract. For example, this may be a cash element that is included in the terms of a takeover that the underlying equity is subject to.
    /// </summary>
    [IsoId("_1Zx-FDL3EeKU9IrkkToqcw_1063112730")]
    [DisplayName("Residual Cash Flag")]
    [IsoXmlTag("RsdlCshFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ResidualCashFlag { get; init; } 
    
    /// <summary>
    /// Price of the security to be used in factor calculations. Usually the closing price of the underlying equity on the effective date of the contract adjustment.
    /// </summary>
    [IsoId("_1Zx-FTL3EeKU9IrkkToqcw_-143242492")]
    [DisplayName("Reference Price")]
    [IsoXmlTag("RefPric")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ReferencePrice { get; init; } 
    
    /// <summary>
    /// Currency associated with the reference price.
    /// </summary>
    [IsoId("_1Zx-FjL3EeKU9IrkkToqcw_1334119961")]
    [DisplayName("Reference Price Currency")]
    [IsoXmlTag("RefPricCcy")]
    public ActiveCurrencyCode? ReferencePriceCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the derivative data has/hasn&apos;t been approved by a validation service.
    /// </summary>
    [IsoId("_1Z7IADL3EeKU9IrkkToqcw_-444572123")]
    [DisplayName("Approved Flag")]
    [IsoXmlTag("ApprvdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ApprovedFlag { get; init; } 
    
    
    #nullable disable
    
}
