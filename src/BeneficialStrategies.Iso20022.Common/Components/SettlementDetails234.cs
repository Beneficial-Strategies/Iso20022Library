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
[IsoId("_IE4g0ZaVEfC2_67yGLymgA")]
[DisplayName("Settlement Details234")]
public record SettlementDetails234
{
    /// <summary>
    /// Indicates whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_IHAnyZaVEfC2_67yGLymgA")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public IsoYesNoIndicator? HoldIndicator { get; init; }

    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_IHAn1ZaVEfC2_67yGLymgA")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType45Choice_ SecuritiesTransactionType { get; init; }

    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [IsoId("_IHAn4ZaVEfC2_67yGLymgA")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition46Choice_> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_IHAn7ZaVEfC2_67yGLymgA")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [IsoId("_IHAn-ZaVEfC2_67yGLymgA")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; }

    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [IsoId("_IHAoBZaVEfC2_67yGLymgA")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem6Choice_? CashClearingSystem { get; init; }

    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [IsoId("_IHAoEZaVEfC2_67yGLymgA")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice_? MarketClientSide { get; init; }

    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [IsoId("_IHAoHZaVEfC2_67yGLymgA")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice_? Registration { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [IsoId("_IHAoKZaVEfC2_67yGLymgA")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType13Choice_? RepurchaseType { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_IHAoNZaVEfC2_67yGLymgA")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [IsoId("_IHAoQZaVEfC2_67yGLymgA")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }
}
