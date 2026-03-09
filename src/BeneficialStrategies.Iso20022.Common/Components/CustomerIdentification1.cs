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
/// Identifies a customer identification as the search criteria for the financial institution to do the investigation.
/// </summary>
[IsoId("_cgxhY0yuEeGcV5yVhSZuNw")]
[DisplayName("Customer Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerIdentification1( PartyIdentification43 reqParty )
    {
        Party = reqParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the customer for the investigation.
    /// </summary>
    [IsoId("_fQKf7EyuEeGcV5yVhSZuNw")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Party { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Party { get; init; } 
    #else
    public PartyIdentification43 Party { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the authority request related to the identified investigation party.
    /// </summary>
    [IsoId("_jP3PoUyuEeGcV5yVhSZuNw")]
    [DisplayName("Authority Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrtyReq")]
    #endif
    [IsoXmlTag("AuthrtyReq")]
    public ValueList<AuthorityInvestigation2> AuthorityRequest { get; init; } = new ValueList<AuthorityInvestigation2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _jP3PoUyuEeGcV5yVhSZuNw
    
    
    #nullable disable
    
}
