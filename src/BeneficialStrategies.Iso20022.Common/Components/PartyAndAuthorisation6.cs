// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party And Authorisation6.
/// </summary>
[IsoId("_yYnIRTEyEe6g-ffJsqGiSA")]
[DisplayName("Party And Authorisation6")]
public partial record PartyAndAuthorisation6
{
    #nullable enable

    /// <summary>
    /// Authorisation.
    /// </summary>
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public required Authorisation2 Authorisation { get; init; } 

    /// <summary>
    /// Modification Code.
    /// </summary>
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; } 

    /// <summary>
    /// Party Or Group.
    /// </summary>
    [DisplayName("Party Or Group")]
    [IsoXmlTag("PtyOrGrp")]
    public required PartyOrGroup3Choice_ PartyOrGroup { get; init; } 

    /// <summary>
    /// Signature Order.
    /// </summary>
    [DisplayName("Signature Order")]
    [IsoXmlTag("SgntrOrdr")]
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; } 

    
    #nullable disable
    
}
