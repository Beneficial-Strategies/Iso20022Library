// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the identification of an individual person.
/// </summary>
[IsoId("_En0lnQhDEeSUPbC7DbLJpQ")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification55
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    [IsoId("_FDf0wwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the identification.
    /// </summary>
    [IsoId("_FDf0xQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OtherIdentification2Choice_ Type { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_FDf0xwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    /// <summary>
    /// Date at which the identification was issued.
    /// </summary>
    [IsoId("_FDf0yQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; } 
    
    /// <summary>
    /// Date at which the identification expires.
    /// </summary>
    [IsoId("_FDf0ywhDEeSUPbC7DbLJpQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Country that issued the identification document.
    /// </summary>
    [IsoId("_ZdMRwAhDEeSUPbC7DbLJpQ")]
    [DisplayName("Issuer Country")]
    [IsoXmlTag("IssrCtry")]
    public CountryCode? IssuerCountry { get; init; } 
    
    
    #nullable disable
    
}
