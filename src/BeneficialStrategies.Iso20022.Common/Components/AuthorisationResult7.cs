// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the authorisation.
/// </summary>
[IsoId("_z8kU8XtBEeSTS7uHCe8FPQ")]
[DisplayName("Authorisation Result")]
public partial record AuthorisationResult7
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_0Jv1UXtBEeSTS7uHCe8FPQ")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification75? AuthorisationEntity { get; init; } 
    
    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_0Jv1U3tBEeSTS7uHCe8FPQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType2 TransactionResponse { get; init; } 
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_0Jv1VXtBEeSTS7uHCe8FPQ")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    
    /// <summary>
    /// Additional information relevant for the destination.
    /// </summary>
    [IsoId("_q7dNMIO6EeSWSLYdc10LRg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ActionMessage3? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
