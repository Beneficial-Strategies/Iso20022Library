// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and related authorisation.
/// </summary>
[IsoId("_CtgGAW49EeiU9cctagi5ow")]
[DisplayName("Party And Authorisation")]
public partial record PartyAndAuthorisation4
{
    #nullable enable
    
    /// <summary>
    /// Specifies a party or a group of parties.
    /// </summary>
    [IsoId("_C3CccW49EeiU9cctagi5ow")]
    [DisplayName("Party Or Group")]
    [IsoXmlTag("PtyOrGrp")]
    public required PartyOrGroup2Choice_ PartyOrGroup { get; init; } 
    
    /// <summary>
    /// Order in which the mandate holder has to sign.
    /// </summary>
    [IsoId("_C3Ccc249EeiU9cctagi5ow")]
    [DisplayName("Signature Order")]
    [IsoXmlTag("SgntrOrdr")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; } 
    
    /// <summary>
    /// Authorisation granted to a mandate holder.
    /// </summary>
    [IsoId("_C3CcdW49EeiU9cctagi5ow")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public required Authorisation2 Authorisation { get; init; } 
    
    
    #nullable disable
    
}
