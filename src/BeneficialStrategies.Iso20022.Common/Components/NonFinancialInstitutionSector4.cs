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
/// Provides detailed information concerning non financial counterparties.
/// </summary>
[IsoId("_MU138QbWEeqrW7Meu5r3kQ")]
[DisplayName("Non Financial Institution Sector")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonFinancialInstitutionSector4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonFinancialInstitutionSector4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonFinancialInstitutionSector4( NoReasonCode reqNonFinancialInstitution )
    {
        NonFinancialInstitution = reqNonFinancialInstitution;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that reporting party is a central counterparty.
    /// </summary>
    [IsoId("_MdCKqQbWEeqrW7Meu5r3kQ")]
    [DisplayName("Non Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NFI")]
    #endif
    [IsoXmlTag("NFI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NoReasonCode NonFinancialInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NoReasonCode NonFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NoReasonCode NonFinancialInstitution { get; init; } 
    #else
    public NoReasonCode NonFinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the non-financial institution.
    /// </summary>
    [IsoId("_VWgswAbWEeqrW7Meu5r3kQ")]
    [DisplayName("Non Financial Institution Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NFIIdr")]
    #endif
    [IsoXmlTag("NFIIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; init; } 
    #else
    public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
