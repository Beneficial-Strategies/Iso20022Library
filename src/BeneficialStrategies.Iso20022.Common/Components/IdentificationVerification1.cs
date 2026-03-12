// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information concerning the identification data that is requested to be verified.
/// </summary>
[IsoId("_QpUAwdp-Ed-ak6NoX_4Aeg_1074529982")]
[DisplayName("Identification Verification")]
public partial record IdentificationVerification1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the message.
    /// </summary>
    [IsoId("_QpUAwtp-Ed-ak6NoX_4Aeg_1358295924")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Party and/or account identification information for which verification is requested.
    /// </summary>
    [IsoId("_QpUAw9p-Ed-ak6NoX_4Aeg_29260419")]
    [DisplayName("Party And Account Identification")]
    [IsoXmlTag("PtyAndAcctId")]
    public required IdentificationInformation1 PartyAndAccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
