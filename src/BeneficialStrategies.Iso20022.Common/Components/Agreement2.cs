// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement details for the over the counter market.
/// </summary>
[IsoId("_Un-Otdp-Ed-ak6NoX_4Aeg_-902133760")]
[DisplayName("Agreement")]
public partial record Agreement2
{
    #nullable enable
    
    /// <summary>
    /// Full details of the supporting legal agreement under which the margin call can be issued and/or governed.
    /// </summary>
    [IsoId("_Un-Ottp-Ed-ak6NoX_4Aeg_-898359592")]
    [DisplayName("Agreement Details")]
    [IsoXmlTag("AgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text AgreementDetails { get; init; } 
    
    /// <summary>
    /// Common reference to the agreement between the two counterparties.
    /// </summary>
    [IsoId("_Un-Ot9p-Ed-ak6NoX_4Aeg_-1464759032")]
    [DisplayName("Agreement Identification")]
    [IsoXmlTag("AgrmtId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AgreementIdentification { get; init; } 
    
    /// <summary>
    /// Date on which the collateral agreement was signed.
    /// </summary>
    [IsoId("_Un-OuNp-Ed-ak6NoX_4Aeg_-508672237")]
    [DisplayName("Agreement Date")]
    [IsoXmlTag("AgrmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate AgreementDate { get; init; } 
    
    /// <summary>
    /// Denomination currency as specified in the collateral agreement.
    /// </summary>
    [IsoId("_Un-Oudp-Ed-ak6NoX_4Aeg_1780700591")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required CurrencyCode BaseCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the underlying master agreement.
    /// </summary>
    [IsoId("_Un-Outp-Ed-ak6NoX_4Aeg_1837622011")]
    [DisplayName("Agreement Framework")]
    [IsoXmlTag("AgrmtFrmwk")]
    public AgreementFramework1Choice_? AgreementFramework { get; init; } 
    
    
    #nullable disable
    
}
