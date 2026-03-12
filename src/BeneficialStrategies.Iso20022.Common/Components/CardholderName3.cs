// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Complete name of the cardholder.
/// </summary>
[IsoId("_s6MQgcriEeuQjLd-KKZrCg")]
[DisplayName("Cardholder Name")]
public partial record CardholderName3
{
    #nullable enable
    
    /// <summary>
    /// Name of the cardholder, which is usually the full name.
    /// </summary>
    [IsoId("_s_YSgcriEeuQjLd-KKZrCg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_s_Y5kcriEeuQjLd-KKZrCg")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; } 
    
    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_s_Y5k8riEeuQjLd-KKZrCg")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; } 
    
    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_s_Y5lcriEeuQjLd-KKZrCg")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LastName { get; init; } 
    
    
    #nullable disable
    
}
