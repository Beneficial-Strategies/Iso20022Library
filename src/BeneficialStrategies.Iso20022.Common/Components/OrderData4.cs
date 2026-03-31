// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order Data4.
/// </summary>
[IsoId("_AaVMgRA3Ee6N57R8Wekj-w")]
[DisplayName("Order Data4")]
public record OrderData4
{
    /// <summary>
    /// Client Identification.
    /// </summary>
    [DisplayName("Client Identification")]
    [IsoXmlTag("ClntId")]
    public PersonOrOrganisation4Choice_? ClientIdentification { get; init; }

    /// <summary>
    /// Direct Electronic Access.
    /// </summary>
    [DisplayName("Direct Electronic Access")]
    [IsoXmlTag("DrctElctrncAccs")]
    public IsoTrueFalseIndicator? DirectElectronicAccess { get; init; }

    /// <summary>
    /// Executing Person.
    /// </summary>
    [DisplayName("Executing Person")]
    [IsoXmlTag("ExctgPrsn")]
    public ExecutingParty2Choice_? ExecutingPerson { get; init; }

    /// <summary>
    /// Instruction Data.
    /// </summary>
    [DisplayName("Instruction Data")]
    [IsoXmlTag("InstrData")]
    public OrderInstructionData2? InstructionData { get; init; }

    /// <summary>
    /// Investment Decision Person.
    /// </summary>
    [DisplayName("Investment Decision Person")]
    [IsoXmlTag("InvstmtDcsnPrsn")]
    public ExecutingParty2Choice_? InvestmentDecisionPerson { get; init; }

    /// <summary>
    /// Liquidity Provision Activity.
    /// </summary>
    [DisplayName("Liquidity Provision Activity")]
    [IsoXmlTag("LqdtyPrvsnActvty")]
    public IsoTrueFalseIndicator? LiquidityProvisionActivity { get; init; }

    /// <summary>
    /// Non Executing Broker.
    /// </summary>
    [DisplayName("Non Executing Broker")]
    [IsoXmlTag("NonExctgBrkr")]
    public IsoLEIIdentifier? NonExecutingBroker { get; init; }

    /// <summary>
    /// Order Classification.
    /// </summary>
    [DisplayName("Order Classification")]
    [IsoXmlTag("OrdrClssfctn")]
    public OrderClassification2? OrderClassification { get; init; }

    /// <summary>
    /// Order Prices.
    /// </summary>
    [DisplayName("Order Prices")]
    [IsoXmlTag("OrdrPrics")]
    public OrderPriceData2? OrderPrices { get; init; }

    /// <summary>
    /// Submitting Entity.
    /// </summary>
    [DisplayName("Submitting Entity")]
    [IsoXmlTag("SubmitgNtty")]
    public IsoLEIIdentifier? SubmittingEntity { get; init; }

    /// <summary>
    /// Trading Capacity.
    /// </summary>
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public RegulatoryTradingCapacity1Code? TradingCapacity { get; init; }

    /// <summary>
    /// Transaction Data.
    /// </summary>
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public TransactionData3? TransactionData { get; init; }
}
