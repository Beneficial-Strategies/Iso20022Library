// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for a transaction and to report on the transaction. A name may be given to the new query.
/// </summary>
[IsoId("_U5qyV5lQEee-Zps0fZQaFQ")]
[DisplayName("Transaction Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionCriteria7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_VCTJ5ZlQEee-Zps0fZQaFQ")]
    [DisplayName("New Query Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewQryNm")]
    #endif
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NewQueryName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewQueryName { get; init; } 
    #else
    public System.String? NewQueryName { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria on which the information is extracted.
    /// </summary>
    [IsoId("_VCTJ55lQEee-Zps0fZQaFQ")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionSearchCriteria7? SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionSearchCriteria7? SearchCriteria { get; init; } 
    #else
    public TransactionSearchCriteria7? SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the format of the requested report.
    /// </summary>
    [IsoId("_VCTJ6ZlQEee-Zps0fZQaFQ")]
    [DisplayName("Statement Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtRpt")]
    #endif
    [IsoXmlTag("StmtRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportIndicator1Code? StatementReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportIndicator1Code? StatementReport { get; init; } 
    #else
    public ReportIndicator1Code? StatementReport { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the expected payment transaction report.
    /// </summary>
    [IsoId("_VCTJ65lQEee-Zps0fZQaFQ")]
    [DisplayName("Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrCrit")]
    #endif
    [IsoXmlTag("RtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionReturnCriteria5? ReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReturnCriteria5? ReturnCriteria { get; init; } 
    #else
    public TransactionReturnCriteria5? ReturnCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
