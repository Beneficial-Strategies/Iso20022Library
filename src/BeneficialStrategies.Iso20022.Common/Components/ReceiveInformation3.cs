// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_QWYdsdp-Ed-ak6NoX_4Aeg_271578271")]
[DisplayName("Receive Information")]
public record ReceiveInformation3
{
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_QWYdstp-Ed-ak6NoX_4Aeg_-1171433164")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_QWYds9p-Ed-ak6NoX_4Aeg_-1171433122")]
    [DisplayName("Stamp Duty Indicator")]
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator StampDutyIndicator { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_QWYdtNp-Ed-ak6NoX_4Aeg_-1171432862")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_QWYdtdp-Ed-ak6NoX_4Aeg_271578333")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public required ReceivingPartiesAndAccount4 SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_QWYdttp-Ed-ak6NoX_4Aeg_-60967180")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge20> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_QWYdt9p-Ed-ak6NoX_4Aeg_1366796826")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission12> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_QWYduNp-Ed-ak6NoX_4Aeg_1371413516")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax15> TaxDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_QWiOsNp-Ed-ak6NoX_4Aeg_271578296")]
    [DisplayName("Physical Transfer Indicator")]
    [IsoXmlTag("PhysTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalTransferIndicator { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_QWiOsdp-Ed-ak6NoX_4Aeg_271578374")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }
}
