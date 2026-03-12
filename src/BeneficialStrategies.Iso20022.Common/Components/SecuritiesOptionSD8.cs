// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement details.
/// </summary>
[IsoId("_qlkEwZ2FEeW-bsa36JFb9A")]
[DisplayName("Securities Option SD")]
public partial record SecuritiesOptionSD8
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_q_53YZ2FEeW-bsa36JFb9A")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_q_53Y52FEeW-bsa36JFb9A")]
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType4Code PayoutType { get; init; } 
    
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC(The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_q_53ZZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Pay Method")]
    [IsoXmlTag("DTCPayMtd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    public IsoMax3Text? DTCPayMethod { get; init; } 
    
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_q_53bZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Pay Order")]
    [IsoXmlTag("DTCPayOrdr")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    public IsoMax3Text? DTCPayOrder { get; init; } 
    
    /// <summary>
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    [IsoId("_q_53dZ2FEeW-bsa36JFb9A")]
    [DisplayName("Reinvestment Income Classification")]
    [IsoXmlTag("RinvstmtIncmClssfctn")]
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; } 
    
    /// <summary>
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    [IsoId("_q_53fZ2FEeW-bsa36JFb9A")]
    [DisplayName("Entitlement Calculation Method")]
    [IsoXmlTag("EntitlmntClctnMtd")]
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    
    /// <summary>
    /// Price is based on either base or disbursed security.
    /// </summary>
    [IsoId("_q_53hZ2FEeW-bsa36JFb9A")]
    [DisplayName("Price Basis")]
    [IsoXmlTag("PricBsis")]
    public DTCBaseDisbursed1Code? PriceBasis { get; init; } 
    
    /// <summary>
    /// Specifies the reason for DTC (The Depository Trust Corporation) to exit the shares.
    /// </summary>
    [IsoId("_q_53jZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Exit Explanation Indicator")]
    [IsoXmlTag("DTCExitExpltnInd")]
    public SecuritiesExitReason1Code? DTCExitExplanationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether a DTC (The Depository Trust Corporation) participant, using one or more payment bonds in connection with a warrant exercise, will be charged (through settlement on exercise date) the value of the upcoming interest payment on the bond(s).
    /// </summary>
    [IsoId("_q_53lZ2FEeW-bsa36JFb9A")]
    [DisplayName("Charge Flag")]
    [IsoXmlTag("ChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to &quot;no&quot; changes are due when protect is covered.
    /// </summary>
    [IsoId("_q_53nZ2FEeW-bsa36JFb9A")]
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the price from the offeror is estimated or final.
    /// </summary>
    [IsoId("_q_53pZ2FEeW-bsa36JFb9A")]
    [DisplayName("Estimated Price Flag")]
    [IsoXmlTag("EstmtdPricFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EstimatedPriceFlag { get; init; } 
    
    /// <summary>
    /// Time period during which instructions regarding the disposition of fractional entitlements will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_q_53rZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Fractional Share Instruction Period")]
    [IsoXmlTag("DTCFrctnlShrInstrPrd")]
    public Period3? DTCFractionalShareInstructionPeriod { get; init; } 
    
    /// <summary>
    /// Indicates the period during which the instructions for US Tax service will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_q_53tZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTCUS Tax Instruction Period")]
    [IsoXmlTag("DTCUSTaxInstrPrd")]
    public Period3? DTCUSTaxInstructionPeriod { get; init; } 
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (Event Details, Options, Movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related Activity Types 74, and 54. If event details and cash option are sourced from the Activity Type 74, then Activity Type 74 will be in RDP Reference Number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP Reference Number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_q_53vZ2FEeW-bsa36JFb9A")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    
    #nullable disable
    
}
