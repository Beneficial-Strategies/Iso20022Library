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
[IsoId("_KAWoEZUVEea7vKctaoIyEQ")]
[DisplayName("General Information")]
public record GeneralInformation5
{
    /// <summary>
    /// Indicates whether the trade is a block or single trade.
    /// </summary>
    [IsoId("_KNwx8ZUVEea7vKctaoIyEQ")]
    [DisplayName("Block Indicator")]
    [IsoXmlTag("BlckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BlockIndicator { get; init; }

    /// <summary>
    /// Reference to a preceding transaction, for example, an option or swap.
    /// </summary>
    [IsoId("_KNwx85UVEea7vKctaoIyEQ")]
    [DisplayName("Related Trade Reference")]
    [IsoXmlTag("RltdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RelatedTradeReference { get; init; }

    /// <summary>
    /// Method used by the trading parties to negotiate and/or execute a deal.
    /// </summary>
    [IsoId("_KNwx9ZUVEea7vKctaoIyEQ")]
    [DisplayName("Dealing Method")]
    [IsoXmlTag("DealgMtd")]
    public Trading1MethodCode? DealingMethod { get; init; }

    /// <summary>
    /// Specifies the broker which arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    [IsoId("_KNwx95UVEea7vKctaoIyEQ")]
    [DisplayName("Broker Identification")]
    [IsoXmlTag("BrkrId")]
    public PartyIdentification73Choice_? BrokerIdentification { get; init; }

    /// <summary>
    /// Counterparty&apos;s reference for the trade.
    /// </summary>
    [IsoId("_KNwx-ZUVEea7vKctaoIyEQ")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CounterpartyReference { get; init; }

    /// <summary>
    /// Brokerage fee for a broker confirmation.
    /// </summary>
    [IsoId("_KNwx-5UVEea7vKctaoIyEQ")]
    [DisplayName("Brokers Commission")]
    [IsoXmlTag("BrkrsComssn")]
    public ActiveCurrencyAndAmount? BrokersCommission { get; init; }

    /// <summary>
    /// Specifies additional information for the receiver and applies to the whole message.
    /// </summary>
    [IsoId("_KNwx_ZUVEea7vKctaoIyEQ")]
    [DisplayName("Sender To Receiver Information")]
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? SenderToReceiverInformation { get; init; }

    /// <summary>
    /// Specifies the branch at the trading side with which the deal was done.
    /// </summary>
    [IsoId("_KNwx_5UVEea7vKctaoIyEQ")]
    [DisplayName("Dealing Branch Trading Side")]
    [IsoXmlTag("DealgBrnchTradgSd")]
    public PartyIdentification73Choice_? DealingBranchTradingSide { get; init; }

    /// <summary>
    /// Specifies the branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_KNwyAZUVEea7vKctaoIyEQ")]
    [DisplayName("Dealing Branch Counterparty Side")]
    [IsoXmlTag("DealgBrnchCtrPtySd")]
    public PartyIdentification73Choice_? DealingBranchCounterpartySide { get; init; }

    /// <summary>
    /// Specifies the name and/or electronic address of the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    [IsoId("_KNwyA5UVEea7vKctaoIyEQ")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactInformation1? ContactInformation { get; init; }

    /// <summary>
    /// Specifies the type, date and version of the agreement used in a trade.
    /// </summary>
    [IsoId("_VTM1UJUVEea7vKctaoIyEQ")]
    [DisplayName("Agreement Details")]
    [IsoXmlTag("AgrmtDtls")]
    public AgreementConditions1? AgreementDetails { get; init; }

    /// <summary>
    /// Specifies the year of definitions of the agreement.
    /// </summary>
    [IsoId("_k1X30JUXEea7vKctaoIyEQ")]
    [DisplayName("Definitions Year")]
    [IsoXmlTag("DefsYr")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    public IsoISOYear? DefinitionsYear { get; init; }

    /// <summary>
    /// Specifies a reference applied to the trade instruction by a broker.
    /// </summary>
    [IsoId("_ntBk8JUYEea7vKctaoIyEQ")]
    [DisplayName("Brokers Reference")]
    [IsoXmlTag("BrkrsRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BrokersReference { get; init; }
}
