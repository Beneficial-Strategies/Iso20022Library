// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on loan and collateral matching criteria.
/// </summary>
[IsoId("_C9D1V__oEemm3skPVSMJQg")]
[DisplayName("Matching Criteria")]
public record MatchingCriteria7
{
    /// <summary>
    /// Compares information related to both sides of a loan.
    /// </summary>
    [IsoId("_DA7osf_oEemm3skPVSMJQg")]
    [DisplayName("Counterparty Matching Criteria")]
    [IsoXmlTag("CtrPtyMtchgCrit")]
    public CounterpartyMatchingCriteria1? CounterpartyMatchingCriteria { get; init; }

    /// <summary>
    /// Compares information related to both sides of a loan.
    /// </summary>
    [IsoId("_DA7os__oEemm3skPVSMJQg")]
    [DisplayName("Loan Matching Criteria")]
    [IsoXmlTag("LnMtchgCrit")]
    public LoanMatchingCriteria6? LoanMatchingCriteria { get; init; }

    /// <summary>
    /// Compares information related to both sides of a collateral.
    /// </summary>
    [IsoId("_DA7otf_oEemm3skPVSMJQg")]
    [DisplayName("Collateral Matching Criteria")]
    [IsoXmlTag("CollMtchgCrit")]
    public CollateralMatchingCriteria3? CollateralMatchingCriteria { get; init; }
}
