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
[IsoId("_ZLkTgySBEeWWV-wpfEW00A")]
[DisplayName("Receive Information")]
public record ReceiveInformation16
{
    /// <summary>
    /// Party that receives (transferee) securities from the delivering agent (transferor).
    /// </summary>
    [IsoId("_WCybYSS_EeWEdM0tuoNJdg")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public PartyIdentification70Choice_? Transferee { get; init; }

    /// <summary>
    /// Account into which the securities are to be received.
    /// </summary>
    [IsoId("_2OAlsSS_EeWEdM0tuoNJdg")]
    [DisplayName("Transferee Registered Account")]
    [IsoXmlTag("TrfeeRegdAcct")]
    public Account19? TransfereeRegisteredAccount { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_WeviISTAEeWEdM0tuoNJdg")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary34? IntermediaryInformation { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_ZoITmSSBEeWWV-wpfEW00A")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_ZoITmySBEeWWV-wpfEW00A")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_ZoITnSSBEeWWV-wpfEW00A")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_ZoITnySBEeWWV-wpfEW00A")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_ZoIToSSBEeWWV-wpfEW00A")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public ReceivingPartiesAndAccount13? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_ZoIToySBEeWWV-wpfEW00A")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge29? ChargeDetails { get; init; }

    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_ZoITpSSBEeWWV-wpfEW00A")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission23? CommissionDetails { get; init; }

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_ZoITpySBEeWWV-wpfEW00A")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax28? TaxDetails { get; init; }

    /// <summary>
    /// Specifies foreign exchange details applied to the payment of charges, taxes and commissions as a result of the transfer.
    /// </summary>
    [IsoId("_ZoITqSSBEeWWV-wpfEW00A")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms26? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_ZoITqySBEeWWV-wpfEW00A")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_ZoITrSSBEeWWV-wpfEW00A")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_ZoITrySBEeWWV-wpfEW00A")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference7? ClientReference { get; init; }
}
