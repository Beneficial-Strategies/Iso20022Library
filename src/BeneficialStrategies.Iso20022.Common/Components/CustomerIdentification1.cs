// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a customer identification as the search criteria for the financial institution to do the investigation.
/// </summary>
[IsoId("_cgxhY0yuEeGcV5yVhSZuNw")]
[DisplayName("Customer Identification")]
public partial record CustomerIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the customer for the investigation.
    /// </summary>
    [IsoId("_fQKf7EyuEeGcV5yVhSZuNw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification43 Party { get; init; } 
    
    /// <summary>
    /// Specifies the authority request related to the identified investigation party.
    /// </summary>
    [IsoId("_jP3PoUyuEeGcV5yVhSZuNw")]
    [DisplayName("Authority Request")]
    [IsoXmlTag("AuthrtyReq")]
    public ValueList<AuthorityInvestigation2> AuthorityRequest { get; init; } = [];
    // ID for the above is _jP3PoUyuEeGcV5yVhSZuNw
    
    
    #nullable disable
    
}
