// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the securities account.
/// </summary>
[IsoId("_QUTaGdp-Ed-ak6NoX_4Aeg_477135220")]
[DisplayName("Securities Account")]
public partial record SecuritiesAccount6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_QUckANp-Ed-ak6NoX_4Aeg_1319384809")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Idenfitication of the account where financial instruments are maintained.
    /// </summary>
    [IsoId("_QUckAdp-Ed-ak6NoX_4Aeg_1621375386")]
    [DisplayName("Securities Account Identification")]
    [IsoXmlTag("SctiesAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SecuritiesAccountIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_QUckAtp-Ed-ak6NoX_4Aeg_1650930318")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the place of safekeeping.
    /// </summary>
    [IsoId("_QUckA9p-Ed-ak6NoX_4Aeg_1778373950")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required PartyIdentification2Choice_ SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Provides information required for the registration of the security.
    /// </summary>
    [IsoId("_QUckBNp-Ed-ak6NoX_4Aeg_-1394411677")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? RegistrationDetails { get; init; } 
    
    
    #nullable disable
    
}
