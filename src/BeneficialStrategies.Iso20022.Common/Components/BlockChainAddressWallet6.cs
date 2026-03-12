// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital account where digital assets or digital tokens can be stored and where an entry is made.
/// </summary>
[IsoId("_FeMnwUYnEeyIDL5Gtobnyw")]
[DisplayName("Block Chain Address Wallet")]
public partial record BlockChainAddressWallet6
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.”.
    /// </summary>
    [IsoId("_Ful0M0YnEeyIDL5Gtobnyw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax140Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_Ful0R0YnEeyIDL5Gtobnyw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PurposeCode7Choice_? Type { get; init; } 
    
    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_Ful0W0YnEeyIDL5Gtobnyw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax70Text? Name { get; init; } 
    
    
    #nullable disable
    
}
