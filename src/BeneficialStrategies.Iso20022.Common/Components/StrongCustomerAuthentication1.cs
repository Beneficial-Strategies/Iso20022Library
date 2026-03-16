// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// EU PSD2 Strong Consumer Authentication data.
/// </summary>
[IsoId("_umTNkAMfEeujMs2LsB3mMw")]
[DisplayName("Strong Customer Authentication")]
public record StrongCustomerAuthentication1
{
    /// <summary>
    /// Boolean flag indicating whether the transaction is subject to Strong Customer Authentication requirements (True) or not (False).
    /// </summary>
    [IsoId("_6dGccAMfEeujMs2LsB3mMw")]
    [DisplayName("Subject To SCA")]
    [IsoXmlTag("SbjtToSCA")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SubjectToSCA { get; init; }

    /// <summary>
    /// Strong customer authentication exemption detail.
    /// </summary>
    [IsoId("_gEuy0AMlEeujMs2LsB3mMw")]
    [DisplayName("Exemption")]
    [IsoXmlTag("Xmptn")]
    public Exemption1? Exemption { get; init; }

    /// <summary>
    /// Authentication performed by a delegated authority (for example by a wallet solution).
    /// </summary>
    [IsoId("_5g2V8AMnEeubkNI1IXQTVQ")]
    [DisplayName("Delegated Authority")]
    [IsoXmlTag("DlgtdAuthrty")]
    public AttestationValue1Code? DelegatedAuthority { get; init; }

    /// <summary>
    /// Waiver claimed for a transaction subject to Strong Customer Authentication.
    /// </summary>
    [IsoId("_DuufMAMoEeubkNI1IXQTVQ")]
    [DisplayName("Waiver")]
    [IsoXmlTag("Wvr")]
    public AttestationValue1Code? Waiver { get; init; }

    /// <summary>
    /// Reason why authentication was not performed.
    /// </summary>
    [IsoId("_PuZWMAMoEeubkNI1IXQTVQ")]
    [DisplayName("Reason Authentication Not Performed")]
    [IsoXmlTag("RsnAuthntcnNotPrfrmd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? ReasonAuthenticationNotPerformed { get; init; }
}
