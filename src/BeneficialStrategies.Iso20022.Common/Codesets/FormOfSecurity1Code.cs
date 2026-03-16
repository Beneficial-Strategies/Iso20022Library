// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Form of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arP_wdp-Ed-ak6NoX_4Aeg_1608809377")]
[Description(@"Form of a financial instrument.")]
[DerivedFrom(typeof(FormOfSecurityCode))]
public enum FormOfSecurity1Code
{
    /// <summary>
    /// The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate.
    /// Encoded/decoded by serializers as &quot;BEAR&quot;.
    /// </summary>
    [EnumMember(Value = "BEAR")]
    [IsoId("_1Gk9wN1OEeGAp99n2TKigg_1287612204")]
    [Description(
        @"The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate."
    )]
    Bearer = FormOfSecurityCode.Bearer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shareholder name of the financial instrument appears in the corporation/funds books.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_3TsVkN1OEeGAp99n2TKigg_1858924413")]
    [Description(
        @"Shareholder name of the financial instrument appears in the corporation/funds books."
    )]
    Registered = FormOfSecurityCode.Registered, // same ordinal as derivation source for type conversions
}
