// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the account and the role of the party.
/// </summary>
[IsoId("_ApDrEC_9EeOKib24wnHaFg")]
[DisplayName("Account And Parties")]
public partial record AccountAndParties2
{
    #nullable enable
    
    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_IIeC8C_9EeOKib24wnHaFg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount1 Account { get; init; } 
    
    /// <summary>
    /// Specifies the role related to the account.
    /// </summary>
    [IsoId("_clKesC__EeOKib24wnHaFg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public ValueList<AccountRole1> Role { get; init; } = new ValueList<AccountRole1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _clKesC__EeOKib24wnHaFg
    
    /// <summary>
    /// Additional information.
    /// </summary>
    [IsoId("_dQJnUC_9EeOKib24wnHaFg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
