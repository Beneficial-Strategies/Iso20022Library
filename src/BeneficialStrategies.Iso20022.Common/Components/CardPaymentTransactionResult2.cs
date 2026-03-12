// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the transaction.
/// </summary>
[IsoId("_no7iIWkDEeS7zPBpvm732w")]
[DisplayName("Card Payment Transaction Result")]
public partial record CardPaymentTransactionResult2
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_n19RgWkDEeS7zPBpvm732w")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public GenericIdentification70? AuthorisationEntity { get; init; } 
    
    /// <summary>
    /// Response to an authorisation from the acquirer.
    /// </summary>
    [IsoId("_n19Rg2kDEeS7zPBpvm732w")]
    [DisplayName("Response To Authorisation")]
    [IsoXmlTag("RspnToAuthstn")]
    public required ResponseType1 ResponseToAuthorisation { get; init; } 
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_n19RhWkDEeS7zPBpvm732w")]
    [DisplayName("Authorisation Code")]
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 6)]
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    
    
    #nullable disable
    
}
