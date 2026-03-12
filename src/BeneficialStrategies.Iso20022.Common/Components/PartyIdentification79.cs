// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify an account owner and the associated decision maker.
/// </summary>
[IsoId("_5DtlUFCiEeWdp9NcseTlOw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification79
{
    #nullable enable
    
    /// <summary>
    /// Identifies the account which is used to acquire or sell financial instruments.
    /// </summary>
    [IsoId("_O_0QQFCjEeWdp9NcseTlOw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public ValueList<PartyIdentification76> AccountOwner { get; init; } = new ValueList<PartyIdentification76>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _O_0QQFCjEeWdp9NcseTlOw
    
    /// <summary>
    /// Identifies the person who makes the decision on the financial instrument, acquire in case the of a buyer or to sell in case of the seller.
    /// </summary>
    [IsoId("_5c13BVCiEeWdp9NcseTlOw")]
    [DisplayName("Decision Maker")]
    [IsoXmlTag("DcsnMakr")]
    public PersonOrOrganisation2Choice_? DecisionMaker { get; init; } 
    
    
    #nullable disable
    
}
