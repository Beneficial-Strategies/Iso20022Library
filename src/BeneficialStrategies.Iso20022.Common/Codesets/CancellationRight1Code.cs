// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYjKpdp-Ed-ak6NoX_4Aeg_-1019449690")]
[Description(
    @"Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel."
)]
[DerivedFrom(typeof(CancellationRightCode))]
public enum CancellationRight1Code
{
    /// <summary>
    /// Investor is entitled to a &quot;cooling off&quot; period with cancellation rights under compliance rules.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_bYjKptp-Ed-ak6NoX_4Aeg_533511288")]
    [Description(
        @"Investor is entitled to a ""cooling off"" period with cancellation rights under compliance rules."
    )]
    Entitled = CancellationRightCode.Entitled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution&apos;s only client.
    /// Encoded/decoded by serializers as &quot;NOXO&quot;.
    /// </summary>
    [EnumMember(Value = "NOXO")]
    [IsoId("_bYjKp9p-Ed-ak6NoX_4Aeg_533511383")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution's only client."
    )]
    ExecutionOnly = CancellationRightCode.ExecutionOnly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights.
    /// Encoded/decoded by serializers as &quot;NOWA&quot;.
    /// </summary>
    [EnumMember(Value = "NOWA")]
    [IsoId("_bYjKqNp-Ed-ak6NoX_4Aeg_533511443")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights."
    )]
    WaiverAgreement = CancellationRightCode.WaiverAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution.
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_bYs7oNp-Ed-ak6NoX_4Aeg_533511503")]
    [Description(
        @"Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution."
    )]
    Institutional = CancellationRightCode.Institutional, // same ordinal as derivation source for type conversions
}
