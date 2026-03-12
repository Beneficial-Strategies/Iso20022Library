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
[IsoId("_MhacEQ4ZEeKGXqvMN6jpiw")]
[DisplayName("Party And Authorisation")]
public partial record PartyAndAuthorisation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies a party or a group of parties.
    /// </summary>
    [IsoId("_M3BftQ4ZEeKGXqvMN6jpiw")]
    [DisplayName("Party Or Group")]
    [IsoXmlTag("PtyOrGrp")]
    public required PartyOrGroup1Choice_ PartyOrGroup { get; init; } 
    
    /// <summary>
    /// Order in which the mandate holder has to sign.
    /// </summary>
    [IsoId("_M3BfvA4ZEeKGXqvMN6jpiw")]
    [DisplayName("Signature Order")]
    [IsoXmlTag("SgntrOrdr")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; } 
    
    /// <summary>
    /// Authorisation granted to a mandate holder.
    /// </summary>
    [IsoId("_M3Bfww4ZEeKGXqvMN6jpiw")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public required Authorisation2 Authorisation { get; init; } 
    
    
    #nullable disable
    
}
