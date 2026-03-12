// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// A proprietary or domestic identification scheme that uniquely identifies a financial instrument.
/// </summary>
[IsoId("_SlI0Stp-Ed-ak6NoX_4Aeg_-1692049135")]
[DisplayName("Alternate Financial Instrument Identification")]
public partial record AlternateFinancialInstrumentIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    [IsoId("_SlI0S9p-Ed-ak6NoX_4Aeg_-1692049133")]
    [DisplayName("Domestic Identification Source")]
    [IsoXmlTag("DmstIdSrc")]
    public required CountryCode DomesticIdentificationSource { get; init; } 
    
    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    [IsoId("_SlSlQNp-Ed-ak6NoX_4Aeg_273812165")]
    [DisplayName("Proprietary Identification Source")]
    [IsoXmlTag("PrtryIdSrc")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text ProprietaryIdentificationSource { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_SlSlQdp-Ed-ak6NoX_4Aeg_-1692049134")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    
    #nullable disable
    
}
