// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of identification of a party. The party can be identified by providing a BIC or a proprietary code.
/// Optionally, the client account number can also be provided.
/// </summary>
[IsoId("_AUCy0NokEeC60axPepSq7g_-1700467990")]
[DisplayName("Party Identification")]
public partial record PartyIdentification54
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_AUMj0NokEeC60axPepSq7g_-1814307056")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier BIC { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_AUMj0dokEeC60axPepSq7g_1597426953")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public required GenericIdentification29 ProprietaryIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a party with its name and address in free text.
    /// </summary>
    [IsoId("_AUMj0tokEeC60axPepSq7g_1483587887")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress13? NameAndAddress { get; init; } 
    
    
    #nullable disable
    
}
