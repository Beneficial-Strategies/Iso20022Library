// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the voting entitlement.
/// </summary>
[IsoId("_1U8LB1thEeSwKe7KuKvXhg")]
[DisplayName("Eligible Position")]
public partial record EligiblePosition5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_1yZjFVthEeSwKe7KuKvXhg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the party that legally owns the account.
    /// </summary>
    [IsoId("_1yZjF1thEeSwKe7KuKvXhg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification40Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    [IsoId("_1yZjGVthEeSwKe7KuKvXhg")]
    [DisplayName("Holding Balance")]
    [IsoXmlTag("HldgBal")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<HoldingBalance7> HoldingBalance { get; init; } = [];
    
    /// <summary>
    /// Identifies the owner of the voting rights.
    /// </summary>
    [IsoId("_1yZjG1thEeSwKe7KuKvXhg")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification40Choice_> RightsHolder { get; init; } = [];
    
    
    #nullable disable
    
}
