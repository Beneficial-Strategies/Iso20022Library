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
[IsoId("_DrQZ4cg4Eeu4ecZgAYuz5w")]
[DisplayName("Counterparty Identification")]
public partial record CounterpartyIdentification12
{
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_DtZH4cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification236Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identification of the branch of the counterparty, when the transaction concludes a transaction through a branch office.
    /// </summary>
    [IsoId("_DtZH48g4Eeu4ecZgAYuz5w")]
    [DisplayName("Branch")]
    [IsoXmlTag("Brnch")]
    public Branch6Choice_? Branch { get; init; } 
    
    /// <summary>
    /// Country where the registered office of the counterparty is located or country of residence in case that the counterparty is a natural person.
    /// </summary>
    [IsoId("_DtZH5cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public CountryCode? CountryCode { get; init; } 
    
    
    #nullable disable
    
}
