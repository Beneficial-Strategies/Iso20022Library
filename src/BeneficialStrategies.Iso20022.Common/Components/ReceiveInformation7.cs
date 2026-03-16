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
[IsoId("_Yqs6gfsnEeCFH_HrG1Cfjg")]
[DisplayName("Receive Information")]
public record ReceiveInformation7
{
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_Yqs6k_snEeCFH_HrG1Cfjg")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_Yqs6l_snEeCFH_HrG1Cfjg")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_Yqs6m_snEeCFH_HrG1Cfjg")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_Yqs6n_snEeCFH_HrG1Cfjg")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public required ReceivingPartiesAndAccount8 SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_Yqs6o_snEeCFH_HrG1Cfjg")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge20? ChargeDetails { get; init; }

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_Yqs6p_snEeCFH_HrG1Cfjg")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission12? CommissionDetails { get; init; }

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_Yqs6q_snEeCFH_HrG1Cfjg")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax15? TaxDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_Yqs6r_snEeCFH_HrG1Cfjg")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_Yqs6s_snEeCFH_HrG1Cfjg")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }
}
