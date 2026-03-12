// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party. The party can be identified by providing the party&apos;s name and optionally, the BIC, account number, address, clearing system identification or LEI can also be provided.
/// </summary>
[IsoId("_BdWGVwN1Ee2-vqzwMUAewg")]
[DisplayName("Party Identification")]
public partial record PartyIdentification266
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party expressed as the party&apos;s name.
    /// </summary>
    [IsoId("_BjNdwwN1Ee2-vqzwMUAewg")]
    [DisplayName("Party Name")]
    [IsoXmlTag("PtyNm")]
    [IsoSimpleType(IsoSimpleType.Max34Text)]
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    public IsoMax34Text? PartyName { get; init; } 
    
    /// <summary>
    /// Identification of the party expressed as a BIC and an optional alternative identifier.
    /// </summary>
    [IsoId("_BjNdxQN1Ee2-vqzwMUAewg")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    public PartyIdentification265? AnyBIC { get; init; } 
    
    /// <summary>
    /// Provides the party&apos;s account number.
    /// </summary>
    [IsoId("_BjNdxwN1Ee2-vqzwMUAewg")]
    [DisplayName("Account Number")]
    [IsoXmlTag("AcctNb")]
    [IsoSimpleType(IsoSimpleType.Max34Text)]
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    public IsoMax34Text? AccountNumber { get; init; } 
    
    /// <summary>
    /// Provides the party&apos;s address.
    /// </summary>
    [IsoId("_BjNdyQN1Ee2-vqzwMUAewg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? Address { get; init; } 
    
    /// <summary>
    /// Choice of a clearing system identifier.
    /// </summary>
    [IsoId("_BjNdywN1Ee2-vqzwMUAewg")]
    [DisplayName("Clearing System Identification")]
    [IsoXmlTag("ClrSysId")]
    public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; } 
    
    /// <summary>
    /// Provides the Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_BjNdzQN1Ee2-vqzwMUAewg")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    
    #nullable disable
    
}
