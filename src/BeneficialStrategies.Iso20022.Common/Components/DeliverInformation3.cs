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
[IsoId("_QWiOu9p-Ed-ak6NoX_4Aeg_-1840056710")]
[DisplayName("Deliver Information")]
public record DeliverInformation3
{
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_QWiOvNp-Ed-ak6NoX_4Aeg_-1151114418")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_QWiOvdp-Ed-ak6NoX_4Aeg_-1151114375")]
    [DisplayName("Stamp Duty Indicator")]
    [IsoXmlTag("StmpDtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator StampDutyIndicator { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_QWiOvtp-Ed-ak6NoX_4Aeg_-1151114314")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_QWiOv9p-Ed-ak6NoX_4Aeg_-1840056648")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public required DeliveringPartiesAndAccount4 SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_QWr_sNp-Ed-ak6NoX_4Aeg_-49884403")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge20? ChargeDetails { get; init; }

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_QWr_sdp-Ed-ak6NoX_4Aeg_1381572526")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission12? CommissionDetails { get; init; }

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_QWr_stp-Ed-ak6NoX_4Aeg_-238551714")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax15? TaxDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_QWr_s9p-Ed-ak6NoX_4Aeg_-1840056692")]
    [DisplayName("Physical Transfer Indicator")]
    [IsoXmlTag("PhysTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalTransferIndicator { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_QWr_tNp-Ed-ak6NoX_4Aeg_-1839136642")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }
}
