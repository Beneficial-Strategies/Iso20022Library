// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of the issuer CSD (central securities depository).
/// </summary>
[IsoId("_C0Xzk-3rEeaWjpoyrnG6Rw")]
[DisplayName("Issuer CSD Identification")]
public partial record IssuerCSDIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identification code of the Issuer CSD, using LEI; Legal Entity Identifier (LEI) is a code allocated to a party as described in ISO 17442 &apos;Financial Services - Legal Entity Identifier (LEI)&apos;.
    /// </summary>
    [IsoId("_mHn68G5BEeeOy4DIG9NBSQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    /// <summary>
    /// Identifies the jurisdiction relevant for the financial instrument based on the first two characters of its instrument identification code.
    /// </summary>
    [IsoId("_NkUachJnEeiE15g1wPm3UA")]
    [DisplayName("First Two Characters Instrument Identification")]
    [IsoXmlTag("FrstTwoCharsInstrmId")]
    [IsoSimpleType(IsoSimpleType.Exact2UpperCaseAlphaText)]
    public required IsoExact2UpperCaseAlphaText FirstTwoCharactersInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the country code of the Issuer CSD, using ISO 3166 2-character code. 
    /// </summary>
    [IsoId("_C0XzlO3rEeaWjpoyrnG6Rw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
