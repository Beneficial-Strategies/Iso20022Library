// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities proceeds; whether they are defeased or non-defeased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FoqgQCp5EeO3oOoGGWHH4A")]
[Description(
    @"Specifies the type of securities proceeds; whether they are defeased or non-defeased."
)]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
public enum NewSecuritiesIssuanceType3Code
{
    /// <summary>
    /// Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as &quot;DEFE&quot;.
    /// </summary>
    [EnumMember(Value = "DEFE")]
    [IsoId("_NdThQSp5EeO3oOoGGWHH4A")]
    [Description(
        @"Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event."
    )]
    DefeasedSecurityIndicator = NewSecuritiesIssuanceTypeCode.DefeasedSecurityIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as &quot;NDEF&quot;.
    /// </summary>
    [EnumMember(Value = "NDEF")]
    [IsoId("_NmX9sSp5EeO3oOoGGWHH4A")]
    [Description(
        @"Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event."
    )]
    NonDefeasedSecurityIndicator = NewSecuritiesIssuanceTypeCode.NonDefeasedSecurityIndicator, // same ordinal as derivation source for type conversions
}
