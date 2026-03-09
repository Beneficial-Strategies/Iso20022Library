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
/// Taxonomy for financial and non financial counterparties.
/// </summary>
[IsoId("_tkArEdGgEeaQk737TH1Fzw")]
[DisplayName("Corporate Sector Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateSectorCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_ttQGodGgEeaQk737TH1Fzw")]
    [DisplayName("Financial Institution Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FISctr")]
    #endif
    [IsoXmlTag("FISctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialPartySectorType1Code? FinancialInstitutionSector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialPartySectorType1Code? FinancialInstitutionSector { get; init; } 
    #else
    public FinancialPartySectorType1Code? FinancialInstitutionSector { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_ttQGo9GgEeaQk737TH1Fzw")]
    [DisplayName("Non Financial Institution Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NFISctr")]
    #endif
    [IsoXmlTag("NFISctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonFinancialPartySector1Code? NonFinancialInstitutionSector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialPartySector1Code? NonFinancialInstitutionSector { get; init; } 
    #else
    public NonFinancialPartySector1Code? NonFinancialInstitutionSector { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that reporting counterparty is another type of counterparty as defined by specific regulations (e.g. a CCP) and the detailed sector is not reported.
    /// </summary>
    [IsoId("_ttQGpdGgEeaQk737TH1Fzw")]
    [DisplayName("Not Reported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotRptd")]
    #endif
    [IsoXmlTag("NotRptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotReported1Code? NotReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotReported1Code? NotReported { get; init; } 
    #else
    public NotReported1Code? NotReported { get; set; } 
    #endif
    
    
    #nullable disable
    
}
