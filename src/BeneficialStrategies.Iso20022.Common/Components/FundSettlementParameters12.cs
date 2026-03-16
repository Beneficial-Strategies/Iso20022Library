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
[IsoId("_48wIJTbsEead9bDRE_1DAQ")]
[DisplayName("Fund Settlement Parameters")]
public record FundSettlementParameters12
{
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_5VTK4TbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Place where the settlement of the transaction will take place. In the context of investment funds, the place of settlement is the transfer agent, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_5VTK4zbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public required PartyIdentification113 SettlementPlace { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository or an International Central Securities Depository.
    /// </summary>
    [IsoId("_5VTK5TbsEead9bDRE_1DAQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_5VTK5zbsEead9bDRE_1DAQ")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_Q7ZZ41-nEeaUzKc-faDzVQ")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Condition under which the order/trade is to be settled. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_Q7ZZ5V-nEeaUzKc-faDzVQ")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_5VcU0TbsEead9bDRE_1DAQ")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public ReceivingPartiesAndAccount16? ReceivingSideDetails { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_5VcU0zbsEead9bDRE_1DAQ")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public required DeliveringPartiesAndAccount16 DeliveringSideDetails { get; init; }
}
