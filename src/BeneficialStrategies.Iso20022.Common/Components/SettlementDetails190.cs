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
[IsoId("_Uqum_QllEeuQ1MenzX1l-g")]
[DisplayName("Settlement Details")]
public record SettlementDetails190
{
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_U3q2dQllEeuQ1MenzX1l-g")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition34Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_U3q2eQllEeuQ1MenzX1l-g")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_U3q2fQllEeuQ1MenzX1l-g")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_U3q2gQllEeuQ1MenzX1l-g")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_U3q2hQllEeuQ1MenzX1l-g")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_U3q2iQllEeuQ1MenzX1l-g")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_U3q2jQllEeuQ1MenzX1l-g")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_U3q2kQllEeuQ1MenzX1l-g")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_U3q2lQllEeuQ1MenzX1l-g")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType22Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_U3q2mQllEeuQ1MenzX1l-g")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_U3q2nQllEeuQ1MenzX1l-g")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_U3q2oQllEeuQ1MenzX1l-g")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_U3q2pQllEeuQ1MenzX1l-g")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_U3q2qQllEeuQ1MenzX1l-g")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_U3q2rQllEeuQ1MenzX1l-g")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [IsoId("_U3q2sQllEeuQ1MenzX1l-g")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_U3q2tQllEeuQ1MenzX1l-g")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }
}
