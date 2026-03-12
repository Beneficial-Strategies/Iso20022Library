// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_QOMLCdp-Ed-ak6NoX_4Aeg_-1686201292")]
[DisplayName("Intermediary")]
public partial record Intermediary11
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_QOMLCtp-Ed-ak6NoX_4Aeg_-1686201162")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification2Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QOMLC9p-Ed-ak6NoX_4Aeg_-1685280716")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account7? Account { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOV8ANp-Ed-ak6NoX_4Aeg_-1686201085")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole2Code? Role { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_QOV8Adp-Ed-ak6NoX_4Aeg_-1686201067")]
    [DisplayName("Extended Role")]
    [IsoXmlTag("XtndedRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedRole { get; init; } 
    
    
    #nullable disable
    
}
