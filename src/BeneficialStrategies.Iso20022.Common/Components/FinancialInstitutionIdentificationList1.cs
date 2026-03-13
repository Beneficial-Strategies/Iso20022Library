// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of centralised branch identifiers.
/// </summary>
[IsoId("_3iqTICD0Eeav65mEytrgaA")]
[DisplayName("Financial Institution Identification List")]
public partial record FinancialInstitutionIdentificationList1
{
    #nullable enable
    
    /// <summary>
    /// Repeated identifiers.
    /// </summary>
    [IsoId("_Bwxs8CD1Eeav65mEytrgaA")]
    [DisplayName("List")]
    [IsoXmlTag("List")]
    public ValueList<FinancialInstitutionIdentification9> List { get; init; } = [];
    // ID for the above is _Bwxs8CD1Eeav65mEytrgaA
    
    
    #nullable disable
    
}
