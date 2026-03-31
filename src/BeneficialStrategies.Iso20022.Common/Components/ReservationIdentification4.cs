// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reservation Identification4.
/// </summary>
[IsoId("_0vVvETEyEe6g-ffJsqGiSA")]
[DisplayName("Reservation Identification4")]
public record ReservationIdentification4
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Reservation Identification.
    /// </summary>
    [DisplayName("Reservation Identification")]
    [IsoXmlTag("RsvatnId")]
    public IsoMax35Text? ReservationIdentification { get; init; }

    /// <summary>
    /// System Identification.
    /// </summary>
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReservationType2Choice_ Type { get; init; }
}
