// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account information.
/// </summary>
[IsoId("_tkfD8zouEeOr__K5A0LSog")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount96
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [IsoId("_tkfD9TouEeOr__K5A0LSog")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification64 PartyIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_tkfD9DouEeOr__K5A0LSog")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification26 AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
