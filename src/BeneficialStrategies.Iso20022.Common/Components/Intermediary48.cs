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
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_-wFGsXdhEeuvip1zrZRWzw")]
[DisplayName("Intermediary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Intermediary48
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Intermediary48 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Intermediary48( PartyIdentification132 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary or a party related to the transfer.
    /// </summary>
    [IsoId("__CFcs3dhEeuvip1zrZRWzw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification132 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification132 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification132 Identification { get; init; } 
    #else
    public PartyIdentification132 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("__CFctXdhEeuvip1zrZRWzw")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account34? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account34? Account { get; init; } 
    #else
    public Account34? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Function performed by the intermediary or related party.
    /// </summary>
    [IsoId("__CFct3dhEeuvip1zrZRWzw")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Role8Choice_? Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Role8Choice_? Role { get; init; } 
    #else
    public Role8Choice_? Role { get; set; } 
    #endif
    
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("__CFcuXdhEeuvip1zrZRWzw")]
    [DisplayName("Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsn")]
    #endif
    [IsoXmlTag("CtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification2? ContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification2? ContactPerson { get; init; } 
    #else
    public ContactIdentification2? ContactPerson { get; set; } 
    #endif
    
    
    #nullable disable
    
}
