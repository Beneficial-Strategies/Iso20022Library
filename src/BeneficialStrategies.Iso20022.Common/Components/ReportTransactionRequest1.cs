// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Transaction Report Request message.
/// </summary>
[IsoId("_wej3AN6PEeiwsev40qZGEQ")]
[DisplayName("Report Transaction Request")]
public partial record ReportTransactionRequest1
{
    #nullable enable
    
    /// <summary>
    /// Eligibility parameters for a transaction to be part of transaction report.
    /// </summary>
    [IsoId("_4eXmMN6PEeiwsev40qZGEQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<SearchCriteria1> SearchCriteria { get; init; } = new ValueList<SearchCriteria1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _4eXmMN6PEeiwsev40qZGEQ
    
    /// <summary>
    /// Indicates the ordering in which the resulting transaction reports should be returned.
    /// </summary>
    [IsoId("_sN1MMN6QEeiwsev40qZGEQ")]
    [DisplayName("Search Output Order")]
    [IsoXmlTag("SchOutptOrdr")]
    public SearchOutputOrder1? SearchOutputOrder { get; init; } 
    
    /// <summary>
    /// Indicates the order used for the criteria.
    /// </summary>
    [IsoId("_OLrKsN6REeiwsev40qZGEQ")]
    [DisplayName("Descending Order")]
    [IsoXmlTag("DscndgOrdr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DescendingOrder { get; init; } 
    
    /// <summary>
    /// Index of the first transaction matching the search criteria.
    /// </summary>
    [IsoId("_RUyQsN6REeiwsev40qZGEQ")]
    [DisplayName("Block Start")]
    [IsoXmlTag("BlckStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? BlockStart { get; init; } 
    
    /// <summary>
    /// Index of the last transaction matching the search criteria.
    /// </summary>
    [IsoId("_WEN0QN6REeiwsev40qZGEQ")]
    [DisplayName("Block Stop")]
    [IsoXmlTag("BlckStop")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? BlockStop { get; init; } 
    
    
    #nullable disable
    
}
