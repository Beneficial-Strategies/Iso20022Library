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
[IsoId("_PbOdBdp-Ed-ak6NoX_4Aeg_-1456267210")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount3
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_PbOdBtp-Ed-ak6NoX_4Aeg_-1456267208")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification2Choice_ PartyIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_PbOdB9p-Ed-ak6NoX_4Aeg_-1456267175")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification1? AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
