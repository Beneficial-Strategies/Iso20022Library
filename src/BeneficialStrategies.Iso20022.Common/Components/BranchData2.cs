// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific branch of a financial institution.
/// </summary>
[IsoId("_TFLmQNp-Ed-ak6NoX_4Aeg_-1953949955")]
[DisplayName("Branch Data")]
public partial record BranchData2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a branch of a financial institution.
    /// </summary>
    [IsoId("_TFLmQdp-Ed-ak6NoX_4Aeg_-1953949945")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Name by which an agent is known and which is usually used to identify that agent.
    /// </summary>
    [IsoId("_TFLmQtp-Ed-ak6NoX_4Aeg_-1953949925")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_TFLmQ9p-Ed-ak6NoX_4Aeg_-1953949848")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; } 
    
    
    #nullable disable
    
}
