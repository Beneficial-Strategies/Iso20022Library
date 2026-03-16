// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Search Criteria7.
/// </summary>
[IsoId("_zYNkFzEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Search Criteria7")]
public partial record LimitSearchCriteria7
{
    #nullable enable

    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification8? AccountOwner { get; init; } 

    /// <summary>
    /// Bilateral Limit Counterparty Identification.
    /// </summary>
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public ValueList<BranchAndFinancialInstitutionIdentification8> BilateralLimitCounterpartyIdentification { get; init; } = [];

    /// <summary>
    /// Current Limit Type.
    /// </summary>
    [DisplayName("Current Limit Type")]
    [IsoXmlTag("CurLmtTp")]
    public ValueList<LimitType1Choice_> CurrentLimitType { get; init; } = [];

    /// <summary>
    /// Default Limit Type.
    /// </summary>
    [DisplayName("Default Limit Type")]
    [IsoXmlTag("DfltLmtTp")]
    public ValueList<LimitType1Choice_> DefaultLimitType { get; init; } = [];

    /// <summary>
    /// Limit Amount.
    /// </summary>
    [DisplayName("Limit Amount")]
    [IsoXmlTag("LmtAmt")]
    public ActiveAmountRange3Choice_? LimitAmount { get; init; } 

    /// <summary>
    /// Limit Currency.
    /// </summary>
    [DisplayName("Limit Currency")]
    [IsoXmlTag("LmtCcy")]
    public ActiveCurrencyCode? LimitCurrency { get; init; } 

    /// <summary>
    /// Limit Valid As Of Date.
    /// </summary>
    [DisplayName("Limit Valid As Of Date")]
    [IsoXmlTag("LmtVldAsOfDt")]
    public DateAndPeriod2Choice_? LimitValidAsOfDate { get; init; } 

    /// <summary>
    /// System Identification.
    /// </summary>
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 

    /// <summary>
    /// Used Amount.
    /// </summary>
    [DisplayName("Used Amount")]
    [IsoXmlTag("UsdAmt")]
    public ActiveAmountRange3Choice_? UsedAmount { get; init; } 

    /// <summary>
    /// Used Percentage.
    /// </summary>
    [DisplayName("Used Percentage")]
    [IsoXmlTag("UsdPctg")]
    public PercentageRange1Choice_? UsedPercentage { get; init; } 

    
    #nullable disable
    
}
