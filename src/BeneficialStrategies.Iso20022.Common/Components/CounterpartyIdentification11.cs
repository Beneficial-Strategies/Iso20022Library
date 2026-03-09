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
/// Identifies the reporting counterparty.
/// </summary>
[IsoId("_4MnMWcg3EeuGrNSsxk3B0A")]
[DisplayName("Counterparty Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyIdentification11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyIdentification11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyIdentification11( OrganisationIdentification15Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_4ODWwcg3EeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification15Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification15Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_ Identification { get; init; } 
    #else
    public OrganisationIdentification15Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Nature of the reporting counterparty in accordance with the local regulation.
    /// </summary>
    [IsoId("_4ODWw8g3EeuGrNSsxk3B0A")]
    [DisplayName("Nature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntr")]
    #endif
    [IsoXmlTag("Ntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyTradeNature7Choice_? Nature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyTradeNature7Choice_? Nature { get; init; } 
    #else
    public CounterpartyTradeNature7Choice_? Nature { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the branch of the counterparty, when the transaction concludes a transaction through a branch office.
    /// </summary>
    [IsoId("_4ODWxcg3EeuGrNSsxk3B0A")]
    [DisplayName("Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnch")]
    #endif
    [IsoXmlTag("Brnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Branch5Choice_? Branch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Branch5Choice_? Branch { get; init; } 
    #else
    public Branch5Choice_? Branch { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
    /// </summary>
    [IsoId("_4ODWx8g3EeuGrNSsxk3B0A")]
    [DisplayName("Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sd")]
    #endif
    [IsoXmlTag("Sd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralRole1Code? Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralRole1Code? Side { get; init; } 
    #else
    public CollateralRole1Code? Side { get; set; } 
    #endif
    
    
    #nullable disable
    
}
