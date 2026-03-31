// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action SD25.
/// </summary>
[IsoId("_N9RHMYbrEe--EK81FcmyRA")]
[DisplayName("Corporate Action SD25")]
public record CorporateActionSD25
{
    /// <summary>
    /// Certificate Details.
    /// </summary>
    [DisplayName("Certificate Details")]
    [IsoXmlTag("CertDtls")]
    public ValueList<CorporateActionSD26> CertificateDetails { get; init; } = [];

    /// <summary>
    /// Conditional Payment Applicable Flag.
    /// </summary>
    [DisplayName("Conditional Payment Applicable Flag")]
    [IsoXmlTag("CondlPmtAplblFlg")]
    public IsoYesNoIndicator? ConditionalPaymentApplicableFlag { get; init; }

    /// <summary>
    /// Cut Off Days.
    /// </summary>
    [DisplayName("Cut Off Days")]
    [IsoXmlTag("CutOffDays")]
    public IsoMax3Number? CutOffDays { get; init; }

    /// <summary>
    /// Dissenter Rights Applicable Flag.
    /// </summary>
    [DisplayName("Dissenter Rights Applicable Flag")]
    [IsoXmlTag("DsstrRghtsAplblFlg")]
    public IsoYesNoIndicator? DissenterRightsApplicableFlag { get; init; }

    /// <summary>
    /// DTC Automated Offer Program.
    /// </summary>
    [DisplayName("DTC Automated Offer Program")]
    [IsoXmlTag("DTCAutomtdOfferPrgm")]
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; }

    /// <summary>
    /// DTC Custody Eligible Flag.
    /// </summary>
    [DisplayName("DTC Custody Eligible Flag")]
    [IsoXmlTag("DTCCtdyElgblFlg")]
    public IsoYesNoIndicator? DTCCustodyEligibleFlag { get; init; }

    /// <summary>
    /// DTC Foreign Tax Election Flag.
    /// </summary>
    [DisplayName("DTC Foreign Tax Election Flag")]
    [IsoXmlTag("DTCFrgnTaxElctnFlg")]
    public IsoYesNoIndicator? DTCForeignTaxElectionFlag { get; init; }

    /// <summary>
    /// DTC Instruction Lockout Indicator.
    /// </summary>
    [DisplayName("DTC Instruction Lockout Indicator")]
    [IsoXmlTag("DTCInstrLckoutInd")]
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; init; }

    /// <summary>
    /// DTC Recycle Cut Off Indicator.
    /// </summary>
    [DisplayName("DTC Recycle Cut Off Indicator")]
    [IsoXmlTag("DTCRcyclCutOffInd")]
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; }

    /// <summary>
    /// DTC Reorganisation Custody Eligible Flag.
    /// </summary>
    [DisplayName("DTC Reorganisation Custody Eligible Flag")]
    [IsoXmlTag("DTCReorgCtdyElgblFlg")]
    public IsoYesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; }

    /// <summary>
    /// DTC Reorganisation Deposit Eligible Flag.
    /// </summary>
    [DisplayName("DTC Reorganisation Deposit Eligible Flag")]
    [IsoXmlTag("DTCReorgDpstElgblFlg")]
    public IsoYesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; }

    /// <summary>
    /// EDS Messaging Country Code.
    /// </summary>
    [DisplayName("EDS Messaging Country Code")]
    [IsoXmlTag("EDSMsggCtryCd")]
    public CountryCode? EDSMessagingCountryCode { get; init; }

    /// <summary>
    /// Event Cash Value.
    /// </summary>
    [DisplayName("Event Cash Value")]
    [IsoXmlTag("EvtCshVal")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; }

    /// <summary>
    /// Long Short Payment Indicator.
    /// </summary>
    [DisplayName("Long Short Payment Indicator")]
    [IsoXmlTag("LngShrtPmtInd")]
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; }

    /// <summary>
    /// Non Exempt Allowed Indicator.
    /// </summary>
    [DisplayName("Non Exempt Allowed Indicator")]
    [IsoXmlTag("NonXmptAllwdInd")]
    public IsoYesNoIndicator? NonExemptAllowedIndicator { get; init; }

    /// <summary>
    /// Notice Type.
    /// </summary>
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public NoticeType1Code? NoticeType { get; init; }

    /// <summary>
    /// Number Of Shares To Be Issued.
    /// </summary>
    [DisplayName("Number Of Shares To Be Issued")]
    [IsoXmlTag("NbOfShrsToBeIssd")]
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; }

    /// <summary>
    /// Oversubscription Type.
    /// </summary>
    [DisplayName("Oversubscription Type")]
    [IsoXmlTag("OvrsbcptTp")]
    public OversubscriptionType1Code? OversubscriptionType { get; init; }

    /// <summary>
    /// Place And Name.
    /// </summary>
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// RDP Reference Number.
    /// </summary>
    [DisplayName("RDP Reference Number")]
    [IsoXmlTag("RDPRefNb")]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; }

    /// <summary>
    /// Rights Oversubscription Flag.
    /// </summary>
    [DisplayName("Rights Oversubscription Flag")]
    [IsoXmlTag("RghtsOvrsbcptFlg")]
    public IsoYesNoIndicator? RightsOversubscriptionFlag { get; init; }

    /// <summary>
    /// Rights Round Up Privilege Flag.
    /// </summary>
    [DisplayName("Rights Round Up Privilege Flag")]
    [IsoXmlTag("RghtsRndUpPrvlgFlg")]
    public IsoYesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; }

    /// <summary>
    /// Rights Transferable Flag.
    /// </summary>
    [DisplayName("Rights Transferable Flag")]
    [IsoXmlTag("RghtsTrfblFlg")]
    public IsoYesNoIndicator? RightsTransferableFlag { get; init; }

    /// <summary>
    /// Solicitation Dealer Fee Flag.
    /// </summary>
    [DisplayName("Solicitation Dealer Fee Flag")]
    [IsoXmlTag("SlctnDealrFeeFlg")]
    public IsoYesNoIndicator? SolicitationDealerFeeFlag { get; init; }

    /// <summary>
    /// Step Up Privilege Flag.
    /// </summary>
    [DisplayName("Step Up Privilege Flag")]
    [IsoXmlTag("StepUpPrvlgFlg")]
    public IsoYesNoIndicator? StepUpPrivilegeFlag { get; init; }

    /// <summary>
    /// Surrender Shares To Agent Flag.
    /// </summary>
    [DisplayName("Surrender Shares To Agent Flag")]
    [IsoXmlTag("SrrndrShrsToAgtFlg")]
    public IsoYesNoIndicator? SurrenderSharesToAgentFlag { get; init; }

    /// <summary>
    /// Total Number Of Shares Offered.
    /// </summary>
    [DisplayName("Total Number Of Shares Offered")]
    [IsoXmlTag("TtlNbOfShrsOfferd")]
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; }
}
