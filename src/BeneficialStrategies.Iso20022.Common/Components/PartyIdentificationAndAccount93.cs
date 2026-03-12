// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party involved in the settlement chain.
/// </summary>
[IsoId("_jbWzAxgDEeKqWJINzXcn5g")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount93
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_53wuoBgDEeKqWJINzXcn5g")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public PartyIdentification2Choice_? PartyIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_Mu9eIBgEEeKqWJINzXcn5g")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification1? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_VzsOABgEEeKqWJINzXcn5g")]
    [DisplayName("Place Of Settlement")]
    [IsoXmlTag("PlcOfSttlm")]
    public required PartyIdentification2Choice_ PlaceOfSettlement { get; init; } 
    
    
    #nullable disable
    
}
