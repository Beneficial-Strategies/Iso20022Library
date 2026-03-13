// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total amount of charges.
/// </summary>
[IsoId("_WI09c9p-Ed-ak6NoX_4Aeg_628420775")]
[DisplayName("Total Charges")]
public partial record TotalCharges5
{
    #nullable enable
    
    /// <summary>
    /// Information related to a specific charge.
    /// </summary>
    [IsoId("_WI09dNp-Ed-ak6NoX_4Aeg_628420899")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    [MinLength(1)]
    [MaxLength(4)]
    public ValueList<Charge23> ChargeDetails { get; init; } = [];
    
    
    #nullable disable
    
}
