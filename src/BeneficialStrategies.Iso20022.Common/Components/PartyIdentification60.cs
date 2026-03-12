// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party by fund name, name and address or an LEI.
/// </summary>
[IsoId("_f3RSvZT-EeKShbaq9ixROw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification60
{
    #nullable enable
    
    /// <summary>
    /// Identification of a fund.
    /// </summary>
    [IsoId("_xNsHsJXJEeK3CZeLifG0eA")]
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text FundIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the party expressed as name and an optional address and an optional alternative identifier.
    /// </summary>
    [IsoId("_f3RSyJT-EeKShbaq9ixROw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress8? NameAndAddress { get; init; } 
    
    /// <summary>
    /// Identification of the Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_1rPVUJT-EeKShbaq9ixROw")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    
    #nullable disable
    
}
