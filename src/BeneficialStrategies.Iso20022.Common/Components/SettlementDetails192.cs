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
[IsoId("_38PG5SAaEeu4a6pNulzZ4Q")]
[DisplayName("Settlement Details")]
public record SettlementDetails192
{
    /// <summary>
    /// Specifies whether the transaction was executed with a high priority.
    /// </summary>
    [IsoId("_38PG6yAaEeu4a6pNulzZ4Q")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric5Choice_? Priority { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_38PG7yAaEeu4a6pNulzZ4Q")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType51Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade was to be settled.
    /// </summary>
    [IsoId("_38PG8yAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition37Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement was allowed.
    /// </summary>
    [IsoId("_38PG9yAaEeu4a6pNulzZ4Q")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there was change of beneficial ownership.
    /// </summary>
    [IsoId("_38PG-yAaEeu4a6pNulzZ4Q")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was a block parent or child.
    /// </summary>
    [IsoId("_38PG_yAaEeu4a6pNulzZ4Q")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade5Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_38PHAyAaEeu4a6pNulzZ4Q")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_38PHByAaEeu4a6pNulzZ4Q")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade having caused the collateral movement.
    /// </summary>
    [IsoId("_38PHCyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType17Choice_? ExposureType { get; init; }

    /// <summary>
    /// Specifies if an instruction was for a market side or a client side transaction.
    /// </summary>
    [IsoId("_38PHDyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide7Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was eligible for netting.
    /// </summary>
    [IsoId("_38PHEyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility5Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether registration was to occur upon receipt.
    /// </summary>
    [IsoId("_38PHFyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration11Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// </summary>
    [IsoId("_38PHGyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType24Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_38PHHyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction6Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction was to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_38PHIyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_38PHJyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity8Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction was to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_38PHKyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_38PHLyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_38PHMyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification47? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_38PHNyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing8Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether physical settlement was executed using a letter of guarantee or if the physical certificates were used.
    /// </summary>
    [IsoId("_38PHOyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Letter Of Guarantee")]
    [IsoXmlTag("LttrOfGrnt")]
    public LetterOfGuarantee5Choice_? LetterOfGuarantee { get; init; }

    /// <summary>
    /// Specifies whether securities were requested to be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_38PHPyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_38PHQyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification47? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Specifies the cash sub balance type indicator, for example, the restriction type for a market infrastructure.
    /// </summary>
    [IsoId("_38PHRSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification47? CashSubBalanceType { get; init; }
}
