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
[IsoId("_0Hah0RgdEeK-_89we2b-bA")]
[DisplayName("Receive Information")]
public record ReceiveInformation9
{
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_upOH6RgqEeK-_89we2b-bA")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_0cbIkRgdEeK-_89we2b-bA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_0cbIlRgdEeK-_89we2b-bA")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_0cbImRgdEeK-_89we2b-bA")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_0cbInRgdEeK-_89we2b-bA")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public ReceivingPartiesAndAccount8? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_0cbIoRgdEeK-_89we2b-bA")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge20> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_0cbIpRgdEeK-_89we2b-bA")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission12> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_0cbIqRgdEeK-_89we2b-bA")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax15> TaxDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_0cbIrRgdEeK-_89we2b-bA")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_0cbIsRgdEeK-_89we2b-bA")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }
}
