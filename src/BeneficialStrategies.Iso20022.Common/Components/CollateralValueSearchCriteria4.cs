// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collateral Value Search Criteria4.
/// </summary>
[IsoId("_x48JtzEyEe6g-ffJsqGiSA")]
[DisplayName("Collateral Value Search Criteria4")]
public record CollateralValueSearchCriteria4
{
    /// <summary>
    /// Cash Account Identification.
    /// </summary>
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Cash Account Owner.
    /// </summary>
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Cash Account Servicer.
    /// </summary>
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? CashAccountServicer { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ValueList<ActiveOrHistoricCurrencyCode> Currency { get; init; } = [];

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification19> FinancialInstrumentIdentification { get; init; } =
        [];

    /// <summary>
    /// Securities Account Owner.
    /// </summary>
    [DisplayName("Securities Account Owner")]
    [IsoXmlTag("SctiesAcctOwnr")]
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; }

    /// <summary>
    /// Securities Account Servicer.
    /// </summary>
    [DisplayName("Securities Account Servicer")]
    [IsoXmlTag("SctiesAcctSvcr")]
    public PartyIdentification136? SecuritiesAccountServicer { get; init; }
}
