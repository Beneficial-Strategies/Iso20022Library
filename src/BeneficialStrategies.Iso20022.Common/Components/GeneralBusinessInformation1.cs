// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about business information related to a system.
/// </summary>
[IsoId("_Mg4IJZlgEeeE1Ya-LgRsuQ")]
[DisplayName("General Business Information")]
public partial record GeneralBusinessInformation1
{
    #nullable enable
    
    /// <summary>
    /// Further information about the criticality or importance of a general business information system.
    /// </summary>
    [IsoId("_MpLIgZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Qualifier")]
    [IsoXmlTag("Qlfr")]
    public InformationQualifierType1? Qualifier { get; init; } 
    
    /// <summary>
    /// Subject line of an item of general business information, summarizing the topic and intended destination of the information.
    /// </summary>
    [IsoId("_MpLIg5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject")]
    [IsoXmlTag("Sbjt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Subject { get; init; } 
    
    /// <summary>
    /// General business information, in unstructured form.
    /// </summary>
    [IsoId("_MpLIhZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject Details")]
    [IsoXmlTag("SbjtDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? SubjectDetails { get; init; } 
    
    
    #nullable disable
    
}
