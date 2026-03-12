// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a natural person through identification number, name and domicile.
/// </summary>
[IsoId("_kLdBwT3ZEe2uHKhHp3bXyA")]
[DisplayName("Natural Person Identification")]
public partial record NaturalPersonIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the natural person.
    /// </summary>
    [IsoId("_kMVykT3ZEe2uHKhHp3bXyA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required NaturalPersonIdentification2 Identification { get; init; } 
    
    /// <summary>
    /// Code of country of residence of a natural person.
    /// </summary>
    [IsoId("_P8TLYD3aEe2uHKhHp3bXyA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
