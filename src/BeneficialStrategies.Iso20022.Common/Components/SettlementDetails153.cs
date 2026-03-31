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
[IsoId("_VKl-M83zEee5nJBZsW8MFQ")]
[DisplayName("Settlement Details")]
public record SettlementDetails153
{
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_VKl-O83zEee5nJBZsW8MFQ")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? HoldIndicator { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_VKl-Q83zEee5nJBZsW8MFQ")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType39Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_VKl-S83zEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition26Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_VKl-U83zEee5nJBZsW8MFQ")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_VKmjRc3zEee5nJBZsW8MFQ")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_VKmjTc3zEee5nJBZsW8MFQ")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_VKmjVc3zEee5nJBZsW8MFQ")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide7Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_VKmjXc3zEee5nJBZsW8MFQ")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration11Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_VKmjZc3zEee5nJBZsW8MFQ")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType17Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_VKmjbc3zEee5nJBZsW8MFQ")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_VKmjdc3zEee5nJBZsW8MFQ")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification47? StampDutyTaxBasis { get; init; }
}
