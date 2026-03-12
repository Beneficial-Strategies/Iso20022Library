// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_1VTtxTL3EeKU9IrkkToqcw_1362987129")]
[DisplayName("Party Identification SD")]
public partial record PartyIdentificationSD3
{
    #nullable enable
    
    /// <summary>
    /// Name and address by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_1VdewDL3EeKU9IrkkToqcw_1161094766")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required NameAndAddress5 NameAndAddress { get; init; } 
    
    
    #nullable disable
    
}
