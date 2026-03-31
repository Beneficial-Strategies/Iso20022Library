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
[IsoId("_lmwAQdXZEeiN28wlpBQScw")]
[DisplayName("Settlement Details")]
public record SettlementDetails170
{
    /// <summary>
    /// Indicates whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_l4mlRdXZEeiN28wlpBQScw")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? HoldIndicator { get; init; }

    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_l4mlSdXZEeiN28wlpBQScw")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition18Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [IsoId("_l4mlTdXZEeiN28wlpBQScw")]
    [DisplayName("Settling Capacity")]
    [IsoXmlTag("SttlgCpcty")]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_l4mlUdXZEeiN28wlpBQScw")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_l4mlVdXZEeiN28wlpBQScw")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_l4mlWdXZEeiN28wlpBQScw")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_l4mlXdXZEeiN28wlpBQScw")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [IsoId("_l4mlYdXZEeiN28wlpBQScw")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_l4mlZdXZEeiN28wlpBQScw")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [IsoId("_l4mladXZEeiN28wlpBQScw")]
    [DisplayName("Block Trade")]
    [IsoXmlTag("BlckTrad")]
    public BlockTrade4Choice_? BlockTrade { get; init; }

    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_l4mlbdXZEeiN28wlpBQScw")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice_? LegalRestrictions { get; init; }

    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [IsoId("_l4mlcdXZEeiN28wlpBQScw")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [IsoId("_l4mlddXZEeiN28wlpBQScw")]
    [DisplayName("Netting Eligibility")]
    [IsoXmlTag("NetgElgblty")]
    public NettingEligibility4Choice_? NettingEligibility { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [IsoId("_l4mledXZEeiN28wlpBQScw")]
    [DisplayName("CCP Eligibility")]
    [IsoXmlTag("CCPElgblty")]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; }

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_l4mlfdXZEeiN28wlpBQScw")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [IsoId("_l4mlgdXZEeiN28wlpBQScw")]
    [DisplayName("Eligible For Collateral")]
    [IsoXmlTag("ElgblForColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; }
}
