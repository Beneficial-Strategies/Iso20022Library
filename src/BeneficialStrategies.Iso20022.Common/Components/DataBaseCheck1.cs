// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a database.
/// </summary>
[IsoId("_0wzDEQjWEeS5F6qHcKOrew")]
[DisplayName("Data Base Check")]
public partial record DataBaseCheck1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the individual or organisation is listed in an on-line global Know Your Customer (KYC) database.
    /// </summary>
    [IsoId("_YoeRAAjXEeS5F6qHcKOrew")]
    [DisplayName("Database Check")]
    [IsoXmlTag("DBChck")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator DatabaseCheck { get; init; } 
    
    /// <summary>
    /// Identification of the database.
    /// </summary>
    [IsoId("_eCrP4AjXEeS5F6qHcKOrew")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    
    #nullable disable
    
}
