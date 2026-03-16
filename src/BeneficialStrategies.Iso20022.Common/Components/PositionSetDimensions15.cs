// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables related to derivatives that are used to group derivatives together into positions for position sets.
/// </summary>
[IsoId("_hOjrQcguEeuGrNSsxk3B0A")]
[DisplayName("Position Set Dimensions")]
public record PositionSetDimensions15
{
    /// <summary>
    /// Information describing the reporting counterparty.
    /// </summary>
    [IsoId("_hP-nk8guEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; init; }

    /// <summary>
    /// Data specific to other counterparties and related fields.
    /// </summary>
    [IsoId("_hP-nlcguEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public OrganisationIdentification15Choice_? OtherCounterparty { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_hP-nl8guEeuGrNSsxk3B0A")]
    [DisplayName("Collateral Portfolio Identification")]
    [IsoXmlTag("CollPrtflId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? CollateralPortfolioIdentification { get; init; }

    /// <summary>
    /// Flag to identify whether the reported Securities Financing Transaction position contains abnormal values.
    /// </summary>
    [IsoId("_hP-nmcguEeuGrNSsxk3B0A")]
    [DisplayName("Outliers Included")]
    [IsoXmlTag("OtlrsIncl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OutliersIncluded { get; init; }
}
