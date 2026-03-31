// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
[IsoId("_SgEuHNp-Ed-ak6NoX_4Aeg_-963851586")]
[DisplayName("Receive Information")]
public record ReceiveInformation4
{
    /// <summary>
    /// Date and time at which the securities were exchange at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_SgOfENp-Ed-ak6NoX_4Aeg_1398578212")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SgOfEdp-Ed-ak6NoX_4Aeg_-116834487")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_SgOfEtp-Ed-ak6NoX_4Aeg_-116834417")]
    [DisplayName("Stamp Duty Indicator")]
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator StampDutyIndicator { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_SgOfE9p-Ed-ak6NoX_4Aeg_-116834357")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_SgOfFNp-Ed-ak6NoX_4Aeg_1625458120")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge20> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_SgOfFdp-Ed-ak6NoX_4Aeg_-1823046690")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission12> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_SgOfFtp-Ed-ak6NoX_4Aeg_-963851290")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax15> TaxDetails { get; init; } = [];

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_SgOfF9p-Ed-ak6NoX_4Aeg_-962931206")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public required ReceivingPartiesAndAccount4 SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_SgOfGNp-Ed-ak6NoX_4Aeg_-963851351")]
    [DisplayName("Physical Transfer Indicator")]
    [IsoXmlTag("PhysTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalTransferIndicator { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_SgOfGdp-Ed-ak6NoX_4Aeg_-963851255")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }
}
