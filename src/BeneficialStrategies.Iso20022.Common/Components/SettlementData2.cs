// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the settlement of a treasury trade.
/// </summary>
[IsoId("_TJMjldp-Ed-ak6NoX_4Aeg_1219011122")]
[DisplayName("Settlement Data")]
public record SettlementData2
{
    /// <summary>
    /// Unique reference supplied by the trade processing system.
    /// </summary>
    [IsoId("_TJMjltp-Ed-ak6NoX_4Aeg_1219011217")]
    [DisplayName("Cash Flow Unique Reference")]
    [IsoXmlTag("CshFlowUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CashFlowUniqueReference { get; init; }

    /// <summary>
    /// Unique reference assigned by a settlement system.
    /// </summary>
    [IsoId("_TJMjl9p-Ed-ak6NoX_4Aeg_1219011546")]
    [DisplayName("Settlement System Unique Reference")]
    [IsoXmlTag("SttlmSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SettlementSystemUniqueReference { get; init; }

    /// <summary>
    /// Original amount which should be settled. This information should be provided when the trade is partially settled or when the settlement is rejected.
    /// </summary>
    [IsoId("_TJMjmNp-Ed-ak6NoX_4Aeg_1219011529")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveOrHistoricCurrencyAndAmount SettlementAmount { get; init; }

    /// <summary>
    /// Funds which the trading side is expected to receive.
    /// </summary>
    [IsoId("_TJWUkNp-Ed-ak6NoX_4Aeg_1219011494")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SettledAmount { get; init; }

    /// <summary>
    /// Amount that cannot be settled by a settlement system.
    /// </summary>
    [IsoId("_TJWUkdp-Ed-ak6NoX_4Aeg_1219011606")]
    [DisplayName("Rejected Amount")]
    [IsoXmlTag("RjctdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RejectedAmount { get; init; }

    /// <summary>
    /// Specifies the party that pays the settlement amount.
    /// </summary>
    [IsoId("_TJWUktp-Ed-ak6NoX_4Aeg_1219011900")]
    [DisplayName("Paying Party")]
    [IsoXmlTag("PngPty")]
    public required PartyIdentification8Choice_ PayingParty { get; init; }

    /// <summary>
    /// Specifies the party that receives the settlement amount.
    /// </summary>
    [IsoId("_TJWUk9p-Ed-ak6NoX_4Aeg_1219011959")]
    [DisplayName("Receiving Party")]
    [IsoXmlTag("RcvgPty")]
    public required PartyIdentification8Choice_ ReceivingParty { get; init; }

    /// <summary>
    /// Date on which the settlement is due to settle.
    /// </summary>
    [IsoId("_TJWUlNp-Ed-ak6NoX_4Aeg_1219011139")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; }

    /// <summary>
    /// Specifies the status of a settlement eg rejected, settled or awaiting authorisation.
    /// </summary>
    [IsoId("_TJWUldp-Ed-ak6NoX_4Aeg_1219011157")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public required SettlementStatus1Code SettlementStatus { get; init; }

    /// <summary>
    /// Description of the status of the settlement of a trade when no coded form is available.
    /// </summary>
    [IsoId("_TJWUltp-Ed-ak6NoX_4Aeg_1219011564")]
    [DisplayName("Extended Settlement Status")]
    [IsoXmlTag("XtndedSttlmSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedSettlementStatus { get; init; }

    /// <summary>
    /// Additional information about the cause of the rejection of a settlement.
    /// </summary>
    [IsoId("_TJWUl9p-Ed-ak6NoX_4Aeg_1219011174")]
    [DisplayName("Settlement Status Sub Type")]
    [IsoXmlTag("SttlmStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SettlementStatusSubType { get; init; }

    /// <summary>
    /// Cash settlement is suspended.
    /// </summary>
    [IsoId("_TJWUmNp-Ed-ak6NoX_4Aeg_1219011234")]
    [DisplayName("Suspended")]
    [IsoXmlTag("Sspd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Suspended { get; init; }

    /// <summary>
    /// Cash settlement is pending.
    /// </summary>
    [IsoId("_TJWUmdp-Ed-ak6NoX_4Aeg_1219011469")]
    [DisplayName("Pending")]
    [IsoXmlTag("Pdg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Pending { get; init; }
}
