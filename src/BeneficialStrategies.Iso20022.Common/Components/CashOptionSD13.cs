// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
[IsoId("_zq5mMTDmEey2N-DB7H7A5A")]
[DisplayName("Cash Option SD")]
public partial record CashOptionSD13
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_0B2GkTDmEey2N-DB7H7A5A")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_0B2GkzDmEey2N-DB7H7A5A")]
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType5Code PayoutType { get; init; } 
    
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_0B2GlTDmEey2N-DB7H7A5A")]
    [DisplayName("DTC Pay Method")]
    [IsoXmlTag("DTCPayMtd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    public IsoMax3Text? DTCPayMethod { get; init; } 
    
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_0B2GnTDmEey2N-DB7H7A5A")]
    [DisplayName("DTC Pay Order")]
    [IsoXmlTag("DTCPayOrdr")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    public IsoMax3Text? DTCPayOrder { get; init; } 
    
    /// <summary>
    /// Indicates how the entitlements were calculated for optional dividends.
    /// </summary>
    [IsoId("_0B2GpTDmEey2N-DB7H7A5A")]
    [DisplayName("Entitlement Calculation Method")]
    [IsoXmlTag("EntitlmntClctnMtd")]
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    
    /// <summary>
    /// Indicates whether the rate is approximate.
    /// </summary>
    [IsoId("_0B2GrTDmEey2N-DB7H7A5A")]
    [DisplayName("Estimated Rate Flag")]
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the income event is subject to withholding tax if paid to a non-U.S. resident alien (NRA).
    /// </summary>
    [IsoId("_0B2GtTDmEey2N-DB7H7A5A")]
    [DisplayName("NRA Tax Reportable Flag")]
    [IsoXmlTag("NRATaxRptblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NRATaxReportableFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to &quot;no&quot; changes are due when protect is covered.
    /// </summary>
    [IsoId("_0B2GvTDmEey2N-DB7H7A5A")]
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    
    /// <summary>
    /// Cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_0B2GxTDmEey2N-DB7H7A5A")]
    [DisplayName("Declared Cash Rate")]
    [IsoXmlTag("DclrdCshRate")]
    public PriceFormatSD3Choice_? DeclaredCashRate { get; init; } 
    
    /// <summary>
    /// Gross cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_0B2GzTDmEey2N-DB7H7A5A")]
    [DisplayName("Declared Gross Rate")]
    [IsoXmlTag("DclrdGrssRate")]
    public PriceFormatSD3Choice_? DeclaredGrossRate { get; init; } 
    
    /// <summary>
    /// Net cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_0B2G1TDmEey2N-DB7H7A5A")]
    [DisplayName("Declared Net Rate")]
    [IsoXmlTag("DclrdNetRate")]
    public PriceFormatSD3Choice_? DeclaredNetRate { get; init; } 
    
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_0B2G3TDmEey2N-DB7H7A5A")]
    [DisplayName("Declared Fee Rate")]
    [IsoXmlTag("DclrdFeeRate")]
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; } 
    
    /// <summary>
    /// Indicates the period during which the instructions for DTC (The Depository Trust Corporation) US Tax service will be accepted.
    /// </summary>
    [IsoId("_0B2G6zDmEey2N-DB7H7A5A")]
    [DisplayName("DTCUS Tax Instruction Period")]
    [IsoXmlTag("DTCUSTaxInstrPrd")]
    public Period13? DTCUSTaxInstructionPeriod { get; init; } 
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: an event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number element in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganisation, distribution, or redemption).
    /// </summary>
    [IsoId("_0B2G-TDmEey2N-DB7H7A5A")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    
    #nullable disable
    
}
