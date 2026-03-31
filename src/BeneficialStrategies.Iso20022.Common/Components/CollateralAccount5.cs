// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
/// </summary>
[IsoId("_hcja4XYAEee_qcLXasnA4g")]
[DisplayName("Collateral Account")]
public record CollateralAccount5
{
    /// <summary>
    /// Unique identifer for the collateral account.
    /// </summary>
    [IsoId("_hlIvIXYAEee_qcLXasnA4g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification118Choice_ Identification { get; init; }

    /// <summary>
    /// Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis.
    /// </summary>
    [IsoId("_EPbHcHYCEee_qcLXasnA4g")]
    [DisplayName("Related Margin Account")]
    [IsoXmlTag("RltdMrgnAcct")]
    public ValueList<MarginAccount1> RelatedMarginAccount { get; init; } = [];

    // ID for the above is _EPbHcHYCEee_qcLXasnA4g

    /// <summary>
    /// Indicates whether the account can be used for clients of UK FCA authorised firms subject to Title Transfer Collateral Arrangements (TTCA).
    /// </summary>
    [IsoId("_GuWoAHYCEee_qcLXasnA4g")]
    [DisplayName("Title Transfer Collateral Arrangement")]
    [IsoXmlTag("TitlTrfCollArrgmnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TitleTransferCollateralArrangement { get; init; }

    /// <summary>
    /// Indicates whether the client collateral is segregated by value in accordance with local regulations. Usage: In the context of clearing members with US clients, in accordance with Section 4d(a)(2) of the Commodity Exchange Act.
    /// </summary>
    [IsoId("_JNSIkHYCEee_qcLXasnA4g")]
    [DisplayName("Collateral Segregation By Value")]
    [IsoXmlTag("CollSgrtnByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CollateralSegregationByValue { get; init; }
}
