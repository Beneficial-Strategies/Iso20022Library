// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Strong Customer Authentication2.
/// </summary>
[IsoId("_JHxqYZqHEe6bZt44gtg6XQ")]
[DisplayName("Strong Customer Authentication2")]
public partial record StrongCustomerAuthentication2
{
    #nullable enable

    /// <summary>
    /// Delegated Authority.
    /// </summary>
    [DisplayName("Delegated Authority")]
    [IsoXmlTag("DlgtdAuthrty")]
    public AttestationValue1Code? DelegatedAuthority { get; init; } 

    /// <summary>
    /// Exemption.
    /// </summary>
    [DisplayName("Exemption")]
    [IsoXmlTag("Xmptn")]
    public ValueList<Exemption2> Exemption { get; init; } = [];

    /// <summary>
    /// Reason Authentication Not Performed.
    /// </summary>
    [DisplayName("Reason Authentication Not Performed")]
    [IsoXmlTag("RsnAuthntcnNotPrfrmd")]
    public IsoMax4Text? ReasonAuthenticationNotPerformed { get; init; } 

    /// <summary>
    /// Subject To SCA.
    /// </summary>
    [DisplayName("Subject To SCA")]
    [IsoXmlTag("SbjtToSCA")]
    public IsoTrueFalseIndicator? SubjectToSCA { get; init; } 

    /// <summary>
    /// Waiver.
    /// </summary>
    [DisplayName("Waiver")]
    [IsoXmlTag("Wvr")]
    public AttestationValue1Code? Waiver { get; init; } 

    
    #nullable disable
    
}
