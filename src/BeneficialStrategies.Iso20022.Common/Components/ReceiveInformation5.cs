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
[IsoId("_1LZwYfpiEeCG_oUHBFcYXA")]
[DisplayName("Receive Information")]
public record ReceiveInformation5
{
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_1LjhcfpiEeCG_oUHBFcYXA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_1LjhdfpiEeCG_oUHBFcYXA")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_1LjhefpiEeCG_oUHBFcYXA")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_1LjhffpiEeCG_oUHBFcYXA")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public required ReceivingPartiesAndAccount8 SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_1LjhgfpiEeCG_oUHBFcYXA")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge20> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_1LjhhfpiEeCG_oUHBFcYXA")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission12> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_1LjhifpiEeCG_oUHBFcYXA")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax15> TaxDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_1LjhjfpiEeCG_oUHBFcYXA")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_1LjhkfpiEeCG_oUHBFcYXA")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }
}
