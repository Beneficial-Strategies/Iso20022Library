// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for an account.
/// </summary>
[IsoId("_Aj9XsTpuEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Search Criteria")]
public record CollateralValueSearchCriteria3
{
    /// <summary>
    /// Unique and unambiguous identification for the cash account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Au-78zpuEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_Au-79TpuEemk2e6qGBk8IQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> Currency { get; init; } = [];

    /// <summary>
    /// Party that legally owns the account being queried.
    /// </summary>
    [IsoId("_Au-79zpuEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, which is being queried.
    /// </summary>
    [IsoId("_Au-7-TpuEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }

    /// <summary>
    /// ISIN identification of the related financial instrument into which this security can be converted.
    /// </summary>
    [IsoId("_Au-7-zpuEemk2e6qGBk8IQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification19> FinancialInstrumentIdentification { get; init; } =
        [];

    /// <summary>
    /// Unique and unambiguous identification of the securities account owner.
    /// </summary>
    [IsoId("_Au-7_TpuEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Owner")]
    [IsoXmlTag("SctiesAcctOwnr")]
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; }

    /// <summary>
    /// Party that manages the securities account on behalf of the account owner.
    /// </summary>
    [IsoId("_Au-7_zpuEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Servicer")]
    [IsoXmlTag("SctiesAcctSvcr")]
    public PartyIdentification136? SecuritiesAccountServicer { get; init; }
}
