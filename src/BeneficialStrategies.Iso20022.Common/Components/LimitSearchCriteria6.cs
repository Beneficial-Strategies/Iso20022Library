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
[IsoId("_FZ5lXW4-EeiU9cctagi5ow")]
[DisplayName("Limit Search Criteria")]
public record LimitSearchCriteria6
{
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_Fkedp24-EeiU9cctagi5ow")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_FkedqW4-EeiU9cctagi5ow")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public ValueList<BranchAndFinancialInstitutionIdentification6> BilateralLimitCounterpartyIdentification { get; init; } =
        [];

    /// <summary>
    /// Type of limit as set by default in the system. The default limit is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_Fkedq24-EeiU9cctagi5ow")]
    [DisplayName("Default Limit Type")]
    [IsoXmlTag("DfltLmtTp")]
    public ValueList<LimitType1Choice_> DefaultLimitType { get; init; } = [];

    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    [IsoId("_FkedrW4-EeiU9cctagi5ow")]
    [DisplayName("Current Limit Type")]
    [IsoXmlTag("CurLmtTp")]
    public ValueList<LimitType1Choice_> CurrentLimitType { get; init; } = [];

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_Fkedr24-EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_FkedsW4-EeiU9cctagi5ow")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Actual usage of the limit expressed as an amount.
    /// </summary>
    [IsoId("_Fkeds24-EeiU9cctagi5ow")]
    [DisplayName("Used Amount")]
    [IsoXmlTag("UsdAmt")]
    public ActiveAmountRange3Choice_? UsedAmount { get; init; }

    /// <summary>
    /// Actual usage of the limit expressed as a percentage.
    /// </summary>
    [IsoId("_FkedtW4-EeiU9cctagi5ow")]
    [DisplayName("Used Percentage")]
    [IsoXmlTag("UsdPctg")]
    public PercentageRange1Choice_? UsedPercentage { get; init; }

    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    [IsoId("_Fkedt24-EeiU9cctagi5ow")]
    [DisplayName("Limit Currency")]
    [IsoXmlTag("LmtCcy")]
    public ActiveCurrencyCode? LimitCurrency { get; init; }

    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_FkeduW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Amount")]
    [IsoXmlTag("LmtAmt")]
    public ActiveAmountRange3Choice_? LimitAmount { get; init; }

    /// <summary>
    /// Range of dates when the limit becomes valid.
    /// </summary>
    [IsoId("_Fkedu24-EeiU9cctagi5ow")]
    [DisplayName("Limit Valid As Of Date")]
    [IsoXmlTag("LmtVldAsOfDt")]
    public DateAndPeriod2Choice_? LimitValidAsOfDate { get; init; }
}
