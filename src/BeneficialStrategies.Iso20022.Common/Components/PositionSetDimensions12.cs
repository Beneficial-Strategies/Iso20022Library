// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables related to derivatives that are used to group derivatives together into positions for position sets.
/// </summary>
[IsoId("_woVqNcKzEeuFNp8LZAnorg")]
[DisplayName("Position Set Dimensions")]
public partial record PositionSetDimensions12
{
    #nullable enable
    
    /// <summary>
    /// Information describing the reporting counterparty.
    /// </summary>
    [IsoId("_wpybs8KzEeuFNp8LZAnorg")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [IsoId("_wpybtcKzEeuFNp8LZAnorg")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public CollateralData33? CollateralData { get; init; } 
    
    /// <summary>
    /// Flag to identify whether the reported Securities Financing Transaction position contains abnormal values.
    /// </summary>
    [IsoId("_wpybt8KzEeuFNp8LZAnorg")]
    [DisplayName("Outliers Included")]
    [IsoXmlTag("OtlrsIncl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OutliersIncluded { get; init; } 
    
    
    #nullable disable
    
}
