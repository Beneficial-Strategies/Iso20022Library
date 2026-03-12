// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation status about the fraudulent transaction.
/// </summary>
[IsoId("_HhcNkHbNEeef9c2nwgY9Xw")]
[DisplayName("Authorisation Status")]
public partial record AuthorisationStatus1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction was authorised or not.
    /// False: transaction was not authorised
    /// True: transaction was authorised
    /// </summary>
    [IsoId("_yZqtIHbNEeef9c2nwgY9Xw")]
    [DisplayName("Authorisation Indicator")]
    [IsoXmlTag("AuthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AuthorisationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates the entity which authorised the transaction (if relevant).
    /// </summary>
    [IsoId("_9p_x4HbNEeef9c2nwgY9Xw")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public PartyType26Code? AuthorisationEntity { get; init; } 
    
    /// <summary>
    /// Other type of authorisation entity.
    /// </summary>
    [IsoId("_jsIsQHbOEeef9c2nwgY9Xw")]
    [DisplayName("Other Authorisation Entity")]
    [IsoXmlTag("OthrAuthstnNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherAuthorisationEntity { get; init; } 
    
    
    #nullable disable
    
}
