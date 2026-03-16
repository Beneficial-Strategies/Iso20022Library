// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Option SD14.
/// </summary>
[IsoId("_b5H9YXGyEe6S2Llv74R19w")]
[DisplayName("Cash Option SD14")]
public record CashOptionSD14
{
    /// <summary>
    /// Declared Cash Rate.
    /// </summary>
    [DisplayName("Declared Cash Rate")]
    [IsoXmlTag("DclrdCshRate")]
    public PriceFormatSD3Choice_? DeclaredCashRate { get; init; }

    /// <summary>
    /// Declared Fee Rate.
    /// </summary>
    [DisplayName("Declared Fee Rate")]
    [IsoXmlTag("DclrdFeeRate")]
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; }

    /// <summary>
    /// Declared Gross Rate.
    /// </summary>
    [DisplayName("Declared Gross Rate")]
    [IsoXmlTag("DclrdGrssRate")]
    public PriceFormatSD3Choice_? DeclaredGrossRate { get; init; }

    /// <summary>
    /// Declared Net Rate.
    /// </summary>
    [DisplayName("Declared Net Rate")]
    [IsoXmlTag("DclrdNetRate")]
    public PriceFormatSD3Choice_? DeclaredNetRate { get; init; }

    /// <summary>
    /// DTC Pay Method.
    /// </summary>
    [DisplayName("DTC Pay Method")]
    [IsoXmlTag("DTCPayMtd")]
    public IsoMax3Text? DTCPayMethod { get; init; }

    /// <summary>
    /// DTC Pay Order.
    /// </summary>
    [DisplayName("DTC Pay Order")]
    [IsoXmlTag("DTCPayOrdr")]
    public IsoMax3Text? DTCPayOrder { get; init; }

    /// <summary>
    /// DTCUS Tax Instruction Period.
    /// </summary>
    [DisplayName("DTCUS Tax Instruction Period")]
    [IsoXmlTag("DTCUSTaxInstrPrd")]
    public Period13? DTCUSTaxInstructionPeriod { get; init; }

    /// <summary>
    /// Entitlement Calculation Method.
    /// </summary>
    [DisplayName("Entitlement Calculation Method")]
    [IsoXmlTag("EntitlmntClctnMtd")]
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; }

    /// <summary>
    /// Estimated Rate Flag.
    /// </summary>
    [DisplayName("Estimated Rate Flag")]
    [IsoXmlTag("EstmtdRateFlg")]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; }

    /// <summary>
    /// Interest Accrued Number Of Days.
    /// </summary>
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// NRA Tax Reportable Flag.
    /// </summary>
    [DisplayName("NRA Tax Reportable Flag")]
    [IsoXmlTag("NRATaxRptblFlg")]
    public IsoYesNoIndicator? NRATaxReportableFlag { get; init; }

    /// <summary>
    /// Payout Type.
    /// </summary>
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType5Code PayoutType { get; init; }

    /// <summary>
    /// Place And Name.
    /// </summary>
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Protect Charge Flag.
    /// </summary>
    [DisplayName("Protect Charge Flag")]
    [IsoXmlTag("PrtctChrgFlg")]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; }

    /// <summary>
    /// RDP Reference Number.
    /// </summary>
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }
}
