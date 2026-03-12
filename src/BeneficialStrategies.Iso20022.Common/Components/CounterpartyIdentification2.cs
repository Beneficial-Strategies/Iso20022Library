// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_hueBxCPmEem1bPJG0YYPpw")]
[DisplayName("Counterparty Identification")]
public partial record CounterpartyIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_hueBxiPmEem1bPJG0YYPpw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification9Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identification of the branch of the counterparty, when the transaction concludes a transaction through a branch office.
    /// </summary>
    [IsoId("_hueBxSPmEem1bPJG0YYPpw")]
    [DisplayName("Branch")]
    [IsoXmlTag("Brnch")]
    public Branch2Choice_? Branch { get; init; } 
    
    /// <summary>
    /// Country where the registered office of the counterparty is located or country of residence in case that the counterparty is a natural person.
    /// </summary>
    [IsoId("_hueBxyPmEem1bPJG0YYPpw")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public CountryCode? CountryCode { get; init; } 
    
    
    #nullable disable
    
}
