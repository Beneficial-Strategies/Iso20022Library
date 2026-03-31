// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a limit.
/// </summary>
[IsoId("_PwPj_ZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Limit Search Criteria")]
public record LimitSearchCriteria5
{
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_P4oq95lcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_P4oq-ZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public ValueList<BranchAndFinancialInstitutionIdentification5> BilateralLimitCounterpartyIdentification { get; init; } =
        [];

    /// <summary>
    /// Type of limit as set by default in the system. The default limit is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_P4oq-5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Default Limit Type")]
    [IsoXmlTag("DfltLmtTp")]
    public ValueList<LimitType1Choice_> DefaultLimitType { get; init; } = [];

    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    [IsoId("_P4oq_ZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Current Limit Type")]
    [IsoXmlTag("CurLmtTp")]
    public ValueList<LimitType1Choice_> CurrentLimitType { get; init; } = [];

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_P4oq_5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_P4orAZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Actual usage of the limit expressed as an amount.
    /// </summary>
    [IsoId("_P4orA5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Used Amount")]
    [IsoXmlTag("UsdAmt")]
    public ActiveAmountRange3Choice_? UsedAmount { get; init; }

    /// <summary>
    /// Actual usage of the limit expressed as a percentage.
    /// </summary>
    [IsoId("_P4orBZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Used Percentage")]
    [IsoXmlTag("UsdPctg")]
    public PercentageRange1Choice_? UsedPercentage { get; init; }

    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    [IsoId("_P4orB5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Currency")]
    [IsoXmlTag("LmtCcy")]
    public ActiveCurrencyCode? LimitCurrency { get; init; }

    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_P4orCZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Amount")]
    [IsoXmlTag("LmtAmt")]
    public ActiveAmountRange3Choice_? LimitAmount { get; init; }

    /// <summary>
    /// Range of dates when the limit becomes valid.
    /// </summary>
    [IsoId("_P4orC5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Valid As Of Date")]
    [IsoXmlTag("LmtVldAsOfDt")]
    public DateAndPeriod2Choice_? LimitValidAsOfDate { get; init; }
}
