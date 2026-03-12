// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of the settlement internaliser.
/// </summary>
[IsoId("_8dG-QO3kEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Identification")]
public partial record SettlementInternaliserIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identification code of the settlement internaliser; Legal Entity Identifier (LEI) is a code allocated to a party as described in ISO 17442 &apos;Financial Services - Legal Entity Identifier (LEI)&apos;.
    /// </summary>
    [IsoId("_BYNmUO3lEeaWjpoyrnG6Rw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier LEI { get; init; } 
    
    /// <summary>
    /// Identification of the liaison at the Settlement Internaliser.
    /// </summary>
    [IsoId("_C2FSgO3lEeaWjpoyrnG6Rw")]
    [DisplayName("Responsible Person")]
    [IsoXmlTag("RspnsblPrsn")]
    public required ContactDetails4 ResponsiblePerson { get; init; } 
    
    /// <summary>
    /// Identifies the country code of the place of establishment of the Settlement Internaliser (i.e. head-office), relating to the data that the report concerns, using ISO 3166 2-character code.
    /// </summary>
    [IsoId("_lbE-wImwEeeMqMRHD1a9dQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Identifies the code of the place of operation of the settlement internaliser (that is the branch), relating to the data that the report concerns.
    /// </summary>
    [IsoId("_wgfUUhJlEeiE15g1wPm3UA")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    [IsoSimpleType(IsoSimpleType.Exact2UpperCaseAlphaText)]
    public IsoExact2UpperCaseAlphaText? BranchIdentification { get; init; } 
    
    
    #nullable disable
    
}
