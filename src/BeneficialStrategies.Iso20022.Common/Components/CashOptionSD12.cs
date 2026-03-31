// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
[IsoId("_KNIpERRrEeuMTf7NxFqaqA")]
[DisplayName("Cash Option SD")]
public record CashOptionSD12
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_KkfZIRRrEeuMTf7NxFqaqA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_KkfZIxRrEeuMTf7NxFqaqA")]
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType5Code PayoutType { get; init; }

    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_KkfZJRRrEeuMTf7NxFqaqA")]
    [DisplayName("DTC Pay Method")]
    [IsoXmlTag("DTCPayMtd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? DTCPayMethod { get; init; }

    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_KkfZLRRrEeuMTf7NxFqaqA")]
    [DisplayName("DTC Pay Order")]
    [IsoXmlTag("DTCPayOrdr")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? DTCPayOrder { get; init; }

    /// <summary>
    /// Indicates how the entitlements were calculated for optional dividends.
    /// </summary>
    [IsoId("_KkfZNRRrEeuMTf7NxFqaqA")]
    [DisplayName("Entitlement Calculation Method")]
    [IsoXmlTag("EntitlmntClctnMtd")]
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; }

    /// <summary>
    /// Indicates whether the rate is approximate.
    /// </summary>
    [IsoId("_KkfZPRRrEeuMTf7NxFqaqA")]
    [DisplayName("Estimated Rate Flag")]
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; }

    /// <summary>
    /// Indicates whether the income event is subject to withholding tax if paid to a non-U.S. resident alien (NRA).
    /// </summary>
    [IsoId("_KkfZRRRrEeuMTf7NxFqaqA")]
    [DisplayName("NRA Tax Reportable Flag")]
    [IsoXmlTag("NRATaxRptblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NRATaxReportableFlag { get; init; }

    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to &quot;no&quot; changes are due when protect is covered.
    /// </summary>
    [IsoId("_KkfZTRRrEeuMTf7NxFqaqA")]
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; }

    /// <summary>
    /// Cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_KkfZVRRrEeuMTf7NxFqaqA")]
    [DisplayName("Declared Cash Rate")]
    [IsoXmlTag("DclrdCshRate")]
    public PriceFormatSD3Choice_? DeclaredCashRate { get; init; }

    /// <summary>
    /// Gross cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_KkfZXRRrEeuMTf7NxFqaqA")]
    [DisplayName("Declared Gross Rate")]
    [IsoXmlTag("DclrdGrssRate")]
    public PriceFormatSD3Choice_? DeclaredGrossRate { get; init; }

    /// <summary>
    /// Net cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_KkfZZRRrEeuMTf7NxFqaqA")]
    [DisplayName("Declared Net Rate")]
    [IsoXmlTag("DclrdNetRate")]
    public PriceFormatSD3Choice_? DeclaredNetRate { get; init; }

    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_KkfZbRRrEeuMTf7NxFqaqA")]
    [DisplayName("Declared Fee Rate")]
    [IsoXmlTag("DclrdFeeRate")]
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; }

    /// <summary>
    /// Indicates the period during which the instructions for DTC (The Depository Trust Corporation) US Tax service will be accepted.
    /// </summary>
    [IsoId("_KkfZexRrEeuMTf7NxFqaqA")]
    [DisplayName("DTCUS Tax Instruction Period")]
    [IsoXmlTag("DTCUSTaxInstrPrd")]
    public Period13? DTCUSTaxInstructionPeriod { get; init; }

    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: an event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number element in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganisation, distribution, or redemption).
    /// </summary>
    [IsoId("_KkfZiRRrEeuMTf7NxFqaqA")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }

    /// <summary>
    /// Specifies the type of income.
    /// Usage: When a cash movement has both US and Canadian tax implications, the US (IRSX) issuer code will be in the base message and the Canadian (CDSL) issuer code will be in the extension.
    /// </summary>
    [IsoId("_QXiV1BRrEeuMTf7NxFqaqA")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification47? IncomeType { get; init; }
}
