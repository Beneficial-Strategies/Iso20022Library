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
/// Unique and unambiguous identifier of a financial institution or a branch of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
/// </summary>
[IsoId("_WHL-wNp-Ed-ak6NoX_4Aeg_578284907")]
[DisplayName("Financial Institution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitution3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstitution3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstitution3( FinancialInstitutionIdentification5 reqFinancialInstitutionIdentification )
    {
        FinancialInstitutionIdentification = reqFinancialInstitutionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_WHVvsNp-Ed-ak6NoX_4Aeg_578285544")]
    [DisplayName("Financial Institution Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstnId")]
    #endif
    [IsoXmlTag("FinInstnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification5 FinancialInstitutionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification5 FinancialInstitutionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification5 FinancialInstitutionIdentification { get; init; } 
    #else
    public FinancialInstitutionIdentification5 FinancialInstitutionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
