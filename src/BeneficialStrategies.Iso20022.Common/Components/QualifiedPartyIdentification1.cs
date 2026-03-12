// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines and associates identifications for a party as a list of other global or qualified relative identifiers.
/// It is assumed that customers of a party can be referenced by an identifier local to the party. The party together with the local identifier can be used to reference the customer.
/// Multiple references can be given to identify the same party.
/// A short identification can be used for display purposes.
/// </summary>
[IsoId("_OTgzMjEy-AOSNFX-8224491")]
[DisplayName("Qualified Party Identification")]
public partial record QualifiedPartyIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Schema ID to be used in IDREF values.
    /// </summary>
    [IsoId("_OTgzMjU0-AOSNFX-8224494")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ID)]
    public required IsoID Identification { get; init; } 
    
    /// <summary>
    /// List of identifications for the same party.
    /// </summary>
    [IsoId("_OTgzMjU1-AOSNFX-8224494")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public ValueList<SingleQualifiedPartyIdentification1> Party { get; init; } = new ValueList<SingleQualifiedPartyIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _OTgzMjU1-AOSNFX-8224494
    
    /// <summary>
    /// Short identification of the resulting party as a control mechanism for humans.
    /// </summary>
    [IsoId("_OTgzMjU2-AOSNFX-8224494")]
    [DisplayName("Short Identification")]
    [IsoXmlTag("ShrtId")]
    public PartyIdentification2Choice_? ShortIdentification { get; init; } 
    
    /// <summary>
    /// Formally defined role qualifying the party.
    /// </summary>
    [IsoId("_OTgzMjU3-AOSNFX-8224494")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public GenericIdentification1? Role { get; init; } 
    
    /// <summary>
    /// Free form description of the party&apos;s role.
    /// </summary>
    [IsoId("_OTgzMjU4-AOSNFX-8224494")]
    [DisplayName("Role Description")]
    [IsoXmlTag("RoleDesc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? RoleDescription { get; init; } 
    
    
    #nullable disable
    
}
