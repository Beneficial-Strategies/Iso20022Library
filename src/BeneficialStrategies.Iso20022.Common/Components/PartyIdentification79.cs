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
/// Set of elements used to identify an account owner and the associated decision maker.
/// </summary>
[IsoId("_5DtlUFCiEeWdp9NcseTlOw")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification79
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the account which is used to acquire or sell financial instruments.
    /// </summary>
    [IsoId("_O_0QQFCjEeWdp9NcseTlOw")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    public ValueList<PartyIdentification76> AccountOwner { get; init; } = new ValueList<PartyIdentification76>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _O_0QQFCjEeWdp9NcseTlOw
    
    /// <summary>
    /// Identifies the person who makes the decision on the financial instrument, acquire in case the of a buyer or to sell in case of the seller.
    /// </summary>
    [IsoId("_5c13BVCiEeWdp9NcseTlOw")]
    [DisplayName("Decision Maker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcsnMakr")]
    #endif
    [IsoXmlTag("DcsnMakr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonOrOrganisation2Choice_? DecisionMaker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonOrOrganisation2Choice_? DecisionMaker { get; init; } 
    #else
    public PersonOrOrganisation2Choice_? DecisionMaker { get; set; } 
    #endif
    
    
    #nullable disable
    
}
