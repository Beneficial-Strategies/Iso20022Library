// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains company related information for Temporary Services.
/// </summary>
[IsoId("_eYF2ccWnEeuhguwJmlgagQ")]
[DisplayName("Temporary Services Company")]
public partial record TemporaryServicesCompany2
{
    #nullable enable
    
    /// <summary>
    /// Contains the name of the individual at the contracting company that has requested temporary services.
    /// </summary>
    [IsoId("_ecf1UcWnEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Contains the name of the department at the contracting company in which the temporary staff will be working. 
    /// </summary>
    [IsoId("_ecf1U8WnEeuhguwJmlgagQ")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; } 
    
    /// <summary>
    /// Identification of the temporary services company.
    /// </summary>
    [IsoId("_ecf1VcWnEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification258? Identification { get; init; } 
    
    /// <summary>
    /// Contains the name of the individual at the contracting company that is supervising the temporary staff. 
    /// </summary>
    [IsoId("_ecf1V8WnEeuhguwJmlgagQ")]
    [DisplayName("Supervisor")]
    [IsoXmlTag("Sprvsr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Supervisor { get; init; } 
    
    
    #nullable disable
    
}
