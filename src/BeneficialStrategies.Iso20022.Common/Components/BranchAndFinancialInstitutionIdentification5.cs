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
/// Set of elements used to uniquely and unambiguously identify a financial institution or a branch of a financial institution.
/// </summary>
[IsoId("_TFB1Qdp-Ed-ak6NoX_4Aeg_1367253312")]
[DisplayName("Branch And Financial Institution Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BranchAndFinancialInstitutionIdentification5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BranchAndFinancialInstitutionIdentification5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5( FinancialInstitutionIdentification8 reqFinancialInstitutionIdentification )
    {
        FinancialInstitutionIdentification = reqFinancialInstitutionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_TFB1Qtp-Ed-ak6NoX_4Aeg_1304823831")]
    [DisplayName("Financial Institution Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstnId")]
    #endif
    [IsoXmlTag("FinInstnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification8 FinancialInstitutionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification8 FinancialInstitutionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification8 FinancialInstitutionIdentification { get; init; } 
    #else
    public FinancialInstitutionIdentification8 FinancialInstitutionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_TFB1Q9p-Ed-ak6NoX_4Aeg_-1458035858")]
    [DisplayName("Branch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrnchId")]
    #endif
    [IsoXmlTag("BrnchId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchData2? BranchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchData2? BranchIdentification { get; init; } 
    #else
    public BranchData2? BranchIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
