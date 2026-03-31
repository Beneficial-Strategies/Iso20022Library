// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
[IsoId("_pAgQA5wxEeazcsnODTksnQ")]
[DisplayName("Settlement Details")]
public record SettlementDetails139
{
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_pAgQCZwxEeazcsnODTksnQ")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition28Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_pAgQDZwxEeazcsnODTksnQ")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity8Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_pAgQEZwxEeazcsnODTksnQ")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification47? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_pAgQFZwxEeazcsnODTksnQ")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_pAgQGZwxEeazcsnODTksnQ")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration11Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_pAgQHZwxEeazcsnODTksnQ")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_pAgQIZwxEeazcsnODTksnQ")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_pAgQJZwxEeazcsnODTksnQ")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_pAgQKZwxEeazcsnODTksnQ")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType24Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_pAgQLZwxEeazcsnODTksnQ")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide5Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_pAgQMZwxEeazcsnODTksnQ")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade5Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_pAgQNZwxEeazcsnODTksnQ")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction6Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_pAgQOZwxEeazcsnODTksnQ")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_pAgQPZwxEeazcsnODTksnQ")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility5Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_pAgQQZwxEeazcsnODTksnQ")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_pAgQRZwxEeazcsnODTksnQ")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee5Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_pAgQSZwxEeazcsnODTksnQ")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }
}
