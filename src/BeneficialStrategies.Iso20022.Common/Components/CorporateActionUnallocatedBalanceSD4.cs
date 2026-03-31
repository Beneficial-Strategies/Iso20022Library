// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance types related to an unallocated redemption payment.
/// </summary>
[IsoId("_npjhEcnxEee6kIhZjMqQ2Q")]
[DisplayName("Corporate Action Unallocated Balance SD")]
public record CorporateActionUnallocatedBalanceSD4
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_n69aIcnxEee6kIhZjMqQ2Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_n69aI8nxEee6kIhZjMqQ2Q")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public SignedQuantityFormat9? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Position held in DTC Segregated account. This position is ineligible for payment until released from pledgee.
    /// </summary>
    [IsoId("_n69aMcnxEee6kIhZjMqQ2Q")]
    [DisplayName("Pledged Balance")]
    [IsoXmlTag("PldgdBal")]
    public SignedQuantityFormat9? PledgedBalance { get; init; }

    /// <summary>
    /// Position held in DTC Segregated account also called account 18. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_n69aM8nxEee6kIhZjMqQ2Q")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; }

    /// <summary>
    /// Position held in DTC Segregated account also called account 22. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_n69aNcnxEee6kIhZjMqQ2Q")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; }

    /// <summary>
    /// Position held in DTC Segregated account. This position is eligible for payment.
    /// </summary>
    [IsoId("_n69aN8nxEee6kIhZjMqQ2Q")]
    [DisplayName("Memo Segregation Balance")]
    [IsoXmlTag("MemoSgrtnBal")]
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; }
}
