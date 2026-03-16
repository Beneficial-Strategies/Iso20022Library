// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund Identification6.
/// </summary>
[IsoId("_usoBEXfaEe2I4Iip2NEM0A")]
[DisplayName("Fund Identification6")]
public partial record FundIdentification6
{
    #nullable enable

    /// <summary>
    /// Account Identification With Custodian.
    /// </summary>
    [DisplayName("Account Identification With Custodian")]
    [IsoXmlTag("AcctIdWthCtdn")]
    public IsoMax35Text? AccountIdentificationWithCustodian { get; init; } 

    /// <summary>
    /// Custodian Identification.
    /// </summary>
    [DisplayName("Custodian Identification")]
    [IsoXmlTag("CtdnId")]
    public PartyIdentification251Choice_? CustodianIdentification { get; init; } 

    /// <summary>
    /// Fund Identification.
    /// </summary>
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    public required IsoMax35Text FundIdentification { get; init; } 

    
    #nullable disable
    
}
