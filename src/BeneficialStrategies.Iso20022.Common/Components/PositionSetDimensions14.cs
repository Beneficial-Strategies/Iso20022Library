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
[IsoId("_F6dn8cguEeuGrNSsxk3B0A")]
[DisplayName("Position Set Dimensions")]
public partial record PositionSetDimensions14
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties.
    /// </summary>
    [IsoId("_F8SM48guEeuGrNSsxk3B0A")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    public CounterpartyData86? CounterpartyData { get; init; } 
    
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_F8SM5cguEeuGrNSsxk3B0A")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public LoanData134? LoanData { get; init; } 
    
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [IsoId("_F8SM58guEeuGrNSsxk3B0A")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public CollateralData33? CollateralData { get; init; } 
    
    /// <summary>
    /// Flag to identify whether the reported Securities Financing Transaction position contains abnormal values.
    /// </summary>
    [IsoId("_F8SM6cguEeuGrNSsxk3B0A")]
    [DisplayName("Outliers Included")]
    [IsoXmlTag("OtlrsIncl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OutliersIncluded { get; init; } 
    
    
    #nullable disable
    
}
