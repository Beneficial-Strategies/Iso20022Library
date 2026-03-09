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
/// Set of elements used to identify a person or an organisation.
/// </summary>
[IsoId("_i3sL4PPYEeS_qLctCs2aRQ")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification76
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification76 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification76( PersonOrOrganisation1Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the owner of the investment account which is used to acquire or sell financial instruments.
    /// </summary>
    [IsoId("_qNqT4PPYEeS_qLctCs2aRQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PersonOrOrganisation1Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PersonOrOrganisation1Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonOrOrganisation1Choice_ Identification { get; init; } 
    #else
    public PersonOrOrganisation1Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the branch that received the order from the client or made an investment decision for a client in accordance with a discretionary mandate given to it by the client.
    /// </summary>
    [IsoId("_WCovkfPZEeS_qLctCs2aRQ")]
    [DisplayName("Country Of Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfBrnch")]
    #endif
    [IsoXmlTag("CtryOfBrnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfBranch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfBranch { get; init; } 
    #else
    public string? CountryOfBranch { get; set; } 
    #endif
    
    
    #nullable disable
    
}
