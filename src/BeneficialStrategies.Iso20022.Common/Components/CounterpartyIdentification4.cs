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
/// Information related to counterparty identification.
/// </summary>
[IsoId("_-IVbJ6n9EemdLtwzt4CWxg")]
[DisplayName("Counterparty Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyIdentification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyIdentification4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyIdentification4( OrganisationIdentification9Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_-N5Qkan9EemdLtwzt4CWxg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification9Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification9Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_ Identification { get; init; } 
    #else
    public OrganisationIdentification9Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Nature of the reporting counterparty in accordance with the local regulation.
    /// </summary>
    [IsoId("_-N5Qk6n9EemdLtwzt4CWxg")]
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
    [IsoId("_-N5Qlan9EemdLtwzt4CWxg")]
    [DisplayName("Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnch")]
    #endif
    [IsoXmlTag("Brnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Branch2Choice_? Branch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Branch2Choice_? Branch { get; init; } 
    #else
    public Branch2Choice_? Branch { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
    /// </summary>
    [IsoId("_-N5Ql6n9EemdLtwzt4CWxg")]
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
