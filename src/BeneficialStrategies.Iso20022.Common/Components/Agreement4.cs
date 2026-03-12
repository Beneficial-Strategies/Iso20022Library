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
[IsoId("_6T7_AYbEEeWguotXa4lFgg")]
[DisplayName("Agreement")]
public partial record Agreement4
{
    #nullable enable
    
    /// <summary>
    /// Full details of the supporting legal agreement under which the margin call can be issued and/or governed.
    /// </summary>
    [IsoId("_6qZXMYbEEeWguotXa4lFgg")]
    [DisplayName("Agreement Details")]
    [IsoXmlTag("AgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text AgreementDetails { get; init; } 
    
    /// <summary>
    /// Common reference to the agreement between the two counterparties.
    /// </summary>
    [IsoId("_6qZXM4bEEeWguotXa4lFgg")]
    [DisplayName("Agreement Identification")]
    [IsoXmlTag("AgrmtId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AgreementIdentification { get; init; } 
    
    /// <summary>
    /// Date on which the collateral agreement was signed.
    /// </summary>
    [IsoId("_6qZXNYbEEeWguotXa4lFgg")]
    [DisplayName("Agreement Date")]
    [IsoXmlTag("AgrmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate AgreementDate { get; init; } 
    
    /// <summary>
    /// Denomination currency as specified in the collateral agreement.
    /// </summary>
    [IsoId("_6qZXN4bEEeWguotXa4lFgg")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required ActiveCurrencyCode BaseCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the underlying master agreement.
    /// </summary>
    [IsoId("_6qZXOYbEEeWguotXa4lFgg")]
    [DisplayName("Agreement Framework")]
    [IsoXmlTag("AgrmtFrmwk")]
    public AgreementFramework1Choice_? AgreementFramework { get; init; } 
    
    
    #nullable disable
    
}
