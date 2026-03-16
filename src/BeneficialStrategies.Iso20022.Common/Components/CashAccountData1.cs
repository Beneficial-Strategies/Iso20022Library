// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Account Data1.
/// </summary>
[IsoId("_3340ZTEyEe6g-ffJsqGiSA")]
[DisplayName("Cash Account Data1")]
public record CashAccountData1
{
    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Current Bilateral Limit.
    /// </summary>
    [DisplayName("Current Bilateral Limit")]
    [IsoXmlTag("CurBilLmt")]
    public ValueList<BilateralLimit4> CurrentBilateralLimit { get; init; } = [];

    /// <summary>
    /// Current Multilateral Limit.
    /// </summary>
    [DisplayName("Current Multilateral Limit")]
    [IsoXmlTag("CurMulLmt")]
    public Limit5? CurrentMultilateralLimit { get; init; }

    /// <summary>
    /// Multilateral Balance.
    /// </summary>
    [DisplayName("Multilateral Balance")]
    [IsoXmlTag("MulBal")]
    public ValueList<CashBalance13> MultilateralBalance { get; init; } = [];

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Owner.
    /// </summary>
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PartyIdentification272? Owner { get; init; }

    /// <summary>
    /// Proxy.
    /// </summary>
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAccountIdentification1? Proxy { get; init; }

    /// <summary>
    /// Servicer.
    /// </summary>
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification8? Servicer { get; init; }

    /// <summary>
    /// Standing Order.
    /// </summary>
    [DisplayName("Standing Order")]
    [IsoXmlTag("StgOrdr")]
    public ValueList<StandingOrder11> StandingOrder { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }
}
