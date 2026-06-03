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
    [IsoId("_IHAnyZaVEfC2_67yGLymgA")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public IsoYesNoIndicator? HoldIndicator { get; init; }

    [IsoId("_IHAn1ZaVEfC2_67yGLymgA")]
    [DisplayName("Securities Transaction Type")]
    [IsoXmlTag("SctiesTxTp")]
    public required SecuritiesTransactionType45Choice SecuritiesTransactionType { get; init; }

    [IsoId("_IHAn4ZaVEfC2_67yGLymgA")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition46Choice> SettlementTransactionCondition { get; init; } = [];

    [IsoId("_IHAn7ZaVEfC2_67yGLymgA")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    [IsoId("_IHAn-ZaVEfC2_67yGLymgA")]
    [DisplayName("Beneficial Ownership")]
    [IsoXmlTag("BnfclOwnrsh")]
    public BeneficialOwnership4Choice? BeneficialOwnership { get; init; }

    [IsoId("_IHAoBZaVEfC2_67yGLymgA")]
    [DisplayName("Cash Clearing System")]
    [IsoXmlTag("CshClrSys")]
    public CashSettlementSystem6Choice? CashClearingSystem { get; init; }

    [IsoId("_IHAoEZaVEfC2_67yGLymgA")]
    [DisplayName("Market Client Side")]
    [IsoXmlTag("MktClntSd")]
    public MarketClientSide6Choice? MarketClientSide { get; init; }

    [IsoId("_IHAoHZaVEfC2_67yGLymgA")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice? Registration { get; init; }

    [IsoId("_IHAoKZaVEfC2_67yGLymgA")]
    [DisplayName("Repurchase Type")]
    [IsoXmlTag("RpTp")]
    public RepurchaseType13Choice? RepurchaseType { get; init; }

    [IsoId("_IHAoNZaVEfC2_67yGLymgA")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice? SecuritiesRTGS { get; init; }

    [IsoId("_IHAoQZaVEfC2_67yGLymgA")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }
}
