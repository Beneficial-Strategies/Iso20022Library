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
/// Identification of a party.
/// </summary>
[IsoId("_yTl6cad9EeuEcqP2FGAFaA")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification257
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial institution-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_yZE3Yad9EeuEcqP2FGAFaA")]
    [DisplayName("Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FI")]
    #endif
    [IsoXmlTag("FI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitution7? FinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitution7? FinancialInstitution { get; init; } 
    #else
    public FinancialInstitution7? FinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Customer-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_yZE3Y6d9EeuEcqP2FGAFaA")]
    [DisplayName("Customer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cstmr")]
    #endif
    [IsoXmlTag("Cstmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Customer7? Customer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Customer7? Customer { get; init; } 
    #else
    public Customer7? Customer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
