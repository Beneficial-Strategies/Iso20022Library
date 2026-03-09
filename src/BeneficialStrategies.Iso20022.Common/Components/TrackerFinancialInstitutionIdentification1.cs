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
/// Unique and unambiguous identification of a financial institution.
/// </summary>
[IsoId("_XaFUtfWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Financial Institution Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerFinancialInstitutionIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerFinancialInstitutionIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerFinancialInstitutionIdentification1( FinancialInstitutionIdentification20 reqFinancialInstitutionIdentification )
    {
        FinancialInstitutionIdentification = reqFinancialInstitutionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_XaFUt_WfEemtd4wHZYvFUQ")]
    [DisplayName("Financial Institution Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstnId")]
    #endif
    [IsoXmlTag("FinInstnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification20 FinancialInstitutionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification20 FinancialInstitutionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification20 FinancialInstitutionIdentification { get; init; } 
    #else
    public FinancialInstitutionIdentification20 FinancialInstitutionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
