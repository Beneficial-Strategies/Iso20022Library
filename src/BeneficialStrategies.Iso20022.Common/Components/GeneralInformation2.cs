// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the negotiation process leading to a treasury trade.
/// </summary>
[IsoId("_S8KT9gEcEeCQm6a_G2yO_w_1137960838")]
[DisplayName("General Information")]
public record GeneralInformation2
{
    /// <summary>
    /// Indicates whether the trade is a block or single trade.
    /// </summary>
    [IsoId("_S8KT9wEcEeCQm6a_G2yO_w_1024121772")]
    [DisplayName("Block Indicator")]
    [IsoXmlTag("BlckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BlockIndicator { get; init; }

    /// <summary>
    /// Reference to a preceeding transaction, for example, an option or swap.
    /// </summary>
    [IsoId("_S8KT-AEcEeCQm6a_G2yO_w_27049419")]
    [DisplayName("Related Trade Reference")]
    [IsoXmlTag("RltdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RelatedTradeReference { get; init; }

    /// <summary>
    /// Method used by the trading parties to negotiate and/or execute a deal.
    /// </summary>
    [IsoId("_S8KT-QEcEeCQm6a_G2yO_w_-970022934")]
    [DisplayName("Dealing Method")]
    [IsoXmlTag("DealgMtd")]
    public Trading1MethodCode? DealingMethod { get; init; }

    /// <summary>
    /// Broker that arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    [IsoId("_S8KT-gEcEeCQm6a_G2yO_w_-1967095287")]
    [DisplayName("Broker Identification")]
    [IsoXmlTag("BrkrId")]
    public PartyIdentification19Choice_? BrokerIdentification { get; init; }

    /// <summary>
    /// Counterparty&apos;s reference for the trade.
    /// </summary>
    [IsoId("_S8KT-wEcEeCQm6a_G2yO_w_1330799656")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CounterpartyReference { get; init; }

    /// <summary>
    /// Brokerage fee for a broker confirmation.
    /// </summary>
    [IsoId("_S8KT_AEcEeCQm6a_G2yO_w_333727303")]
    [DisplayName("Brokers Commission")]
    [IsoXmlTag("BrkrsComssn")]
    public ActiveCurrencyAndAmount? BrokersCommission { get; init; }

    /// <summary>
    /// Specifies additional information for the receiver.
    /// </summary>
    [IsoId("_S8KT_QEcEeCQm6a_G2yO_w_-586306349")]
    [DisplayName("Sender To Receiver Information")]
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SenderToReceiverInformation { get; init; }

    /// <summary>
    /// Branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_S8KT_gEcEeCQm6a_G2yO_w_1099683553")]
    [DisplayName("Dealing Branch Trading Side")]
    [IsoXmlTag("DealgBrnchTradgSd")]
    public PartyIdentification19Choice_? DealingBranchTradingSide { get; init; }

    /// <summary>
    /// Branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_S8KT_wEcEeCQm6a_G2yO_w_102611200")]
    [DisplayName("Dealing Branch Counterparty Side")]
    [IsoXmlTag("DealgBrnchCtrPtySd")]
    public PartyIdentification19Choice_? DealingBranchCounterpartySide { get; init; }

    /// <summary>
    /// Specifies the name and/or electronic address of the the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    [IsoId("_S8KUAAEcEeCQm6a_G2yO_w_-894461153")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactInformation1? ContactInformation { get; init; }
}
