// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Method and data intended to be verified as well as the related results.
/// </summary>
[IsoId("_W7ApQWl_EfCyxsm1jzUNug")]
[DisplayName("Verification9")]
public record Verification9
{
    /// <summary>
    /// Type of authentication or verification. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_W9QE8Wl_EfCyxsm1jzUNug")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalAuthenticationMethod1Code? Type { get; init; }

    /// <summary>
    /// Type of authentication for a given method (for example, three domain authentication, scheme proprietary solution, type of cryptogram, etc.).
    /// </summary>
    [IsoId("_W9QE9Wl_EfCyxsm1jzUNug")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Entity who actually performed the verification. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_W9QE92l_EfCyxsm1jzUNug")]
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public VerificationEntity3Code? Entity { get; init; }

    /// <summary>
    /// Result of the verification. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_W9QE-2l_EfCyxsm1jzUNug")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification4Code? Result { get; init; }

    /// <summary>
    /// Details of the result.
    /// </summary>
    [IsoId("_W9QE_2l_EfCyxsm1jzUNug")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public SimpleValueList<IsoATICALaxProcessing> ResultDetails { get; init; } = [];

    /// <summary>
    /// Additional information about the verification.
    /// </summary>
    [IsoId("_W9QFAWl_EfCyxsm1jzUNug")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax35Text? AdditionalInformation { get; init; }
}
