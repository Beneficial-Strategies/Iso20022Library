// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other type of party.
/// </summary>
[IsoId("_FDf0zQhDEeSUPbC7DbLJpQ")]
[DisplayName("Extended Party")]
public partial record ExtendedParty7
{
    #nullable enable
    
    /// <summary>
    /// Other type of party&apos;s role.
    /// </summary>
    [IsoId("_Ff6rAQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Extended Party Role")]
    [IsoXmlTag("XtndedPtyRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedPartyRole { get; init; } 
    
    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    [IsoId("_Ff6rAwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Other Party Details")]
    [IsoXmlTag("OthrPtyDtls")]
    public required InvestmentAccountOwnershipInformation10 OtherPartyDetails { get; init; } 
    
    
    #nullable disable
    
}
