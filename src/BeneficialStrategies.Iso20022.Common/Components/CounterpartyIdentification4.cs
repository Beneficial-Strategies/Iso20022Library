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
[IsoId("_-IVbJ6n9EemdLtwzt4CWxg")]
[DisplayName("Counterparty Identification")]
public partial record CounterpartyIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_-N5Qkan9EemdLtwzt4CWxg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification9Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Nature of the reporting counterparty in accordance with the local regulation.
    /// </summary>
    [IsoId("_-N5Qk6n9EemdLtwzt4CWxg")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public CounterpartyTradeNature7Choice_? Nature { get; init; } 
    
    /// <summary>
    /// Identification of the branch of the counterparty, when the transaction concludes a transaction through a branch office.
    /// </summary>
    [IsoId("_-N5Qlan9EemdLtwzt4CWxg")]
    [DisplayName("Branch")]
    [IsoXmlTag("Brnch")]
    public Branch2Choice_? Branch { get; init; } 
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
    /// </summary>
    [IsoId("_-N5Ql6n9EemdLtwzt4CWxg")]
    [DisplayName("Side")]
    [IsoXmlTag("Sd")]
    public CollateralRole1Code? Side { get; init; } 
    
    
    #nullable disable
    
}
