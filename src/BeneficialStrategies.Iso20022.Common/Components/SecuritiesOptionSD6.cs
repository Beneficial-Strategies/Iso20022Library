// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement details.
/// </summary>
[IsoId("_UvwowXh5EeOF3uSOaAf1Lg")]
[DisplayName("Securities Option SD")]
public record SecuritiesOptionSD6
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_VJpIYXh5EeOF3uSOaAf1Lg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC(The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_VJpIY3h5EeOF3uSOaAf1Lg")]
    [DisplayName("DTC Pay Method")]
    [IsoXmlTag("DTCPayMtd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? DTCPayMethod { get; init; }

    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_VJpIa3h5EeOF3uSOaAf1Lg")]
    [DisplayName("DTC Pay Order")]
    [IsoXmlTag("DTCPayOrdr")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? DTCPayOrder { get; init; }

    /// <summary>
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    [IsoId("_VJpIc3h5EeOF3uSOaAf1Lg")]
    [DisplayName("Reinvestment Income Classification")]
    [IsoXmlTag("RinvstmtIncmClssfctn")]
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; }

    /// <summary>
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    [IsoId("_VJpIe3h5EeOF3uSOaAf1Lg")]
    [DisplayName("Entitlement Calculation Method")]
    [IsoXmlTag("EntitlmntClctnMtd")]
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; }

    /// <summary>
    /// Price is based on either base or disbursed security.
    /// </summary>
    [IsoId("_VJpIg3h5EeOF3uSOaAf1Lg")]
    [DisplayName("Price Basis")]
    [IsoXmlTag("PricBsis")]
    public DTCBaseDisbursed1Code? PriceBasis { get; init; }

    /// <summary>
    /// Specifies the reason for DTC (The Depository Trust Corporation) to exit the shares.
    /// </summary>
    [IsoId("_VJpIi3h5EeOF3uSOaAf1Lg")]
    [DisplayName("DTC Exit Explanation Indicator")]
    [IsoXmlTag("DTCExitExpltnInd")]
    public SecuritiesExitReason1Code? DTCExitExplanationIndicator { get; init; }

    /// <summary>
    /// Indicates whether a DTC (The Depository Trust Corporation) participant, using one or more payment bonds in connection with a warrant exercise, will be charged (through settlement on exercise date) the value of the upcoming interest payment on the bond(s).
    /// </summary>
    [IsoId("_VJpIk3h5EeOF3uSOaAf1Lg")]
    [DisplayName("Charge Flag")]
    [IsoXmlTag("ChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargeFlag { get; init; }

    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to &quot;no&quot; changes are due when protect is covered.
    /// </summary>
    [IsoId("_VJpIm3h5EeOF3uSOaAf1Lg")]
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; }

    /// <summary>
    /// Indicates whether the price from the offeror is estimated or final.
    /// </summary>
    [IsoId("_VJpIo3h5EeOF3uSOaAf1Lg")]
    [DisplayName("Estimated Price Flag")]
    [IsoXmlTag("EstmtdPricFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EstimatedPriceFlag { get; init; }

    /// <summary>
    /// Time period during which instructions regarding the disposition of fractional entitlements will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_VJpIq3h5EeOF3uSOaAf1Lg")]
    [DisplayName("DTC Fractional Share Instruction Period")]
    [IsoXmlTag("DTCFrctnlShrInstrPrd")]
    public Period3? DTCFractionalShareInstructionPeriod { get; init; }

    /// <summary>
    /// Indicates the period during which the instructions for US Tax service will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_VJpIs3h5EeOF3uSOaAf1Lg")]
    [DisplayName("DTCUS Tax Instruction Period")]
    [IsoXmlTag("DTCUSTaxInstrPrd")]
    public Period3? DTCUSTaxInstructionPeriod { get; init; }

    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy records. The number algorhithm is as follows: Department ID (1:1), Activity Type (2:3), Cusip Country Code (5:2), Cusip (7:9), Record Date (15:8), Payable Date (22:8), Sequence Number (29:3), RDP Issue Type (31:1).
    /// USAGE RULE: this sequence can be populated /extended to event details, option details or a movement, depending on sequence number coordinality to an event.
    /// </summary>
    [IsoId("_bD1O4Xh5EeOF3uSOaAf1Lg")]
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }
}
