// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the Common Reporting Status (CRS) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_L4GYEENsEeaS-NnwLNvMPg")]
[Description(@"Specifies the Common Reporting Status (CRS) status.")]
[DerivedFrom(typeof(CRSStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CRSStatus1Code>))]
#endif
public enum CRSStatus1Code
{
    /// <summary>
    /// Account holder type is a passive non-financial entity with one or more controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as &quot;C101&quot;.
    /// </summary>
    [EnumMember(Value = "C101")]
    [IsoId("_N1X9EUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is a passive non-financial entity with one or more controlling persons that are foreign persons."
    )]
    CRS101 = CRSStatusCode.CRS101, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a foreign person.
    /// Encoded/decoded by serializers as &quot;C102&quot;.
    /// </summary>
    [EnumMember(Value = "C102")]
    [IsoId("_N_8OUUNsEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a foreign person.")]
    CRS102 = CRSStatusCode.CRS102, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a passive foreign non-financial entity without controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as &quot;C103&quot;.
    /// </summary>
    [EnumMember(Value = "C103")]
    [IsoId("_ODDzwUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is a passive foreign non-financial entity without controlling persons that are foreign persons."
    )]
    CRS103 = CRSStatusCode.CRS103, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a financial institution such as a depositary, a custodial institution or a specified insurance company.
    /// Encoded/decoded by serializers as &quot;C104&quot;.
    /// </summary>
    [EnumMember(Value = "C104")]
    [IsoId("_ONeUAUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is a financial institution such as a depositary, a custodial institution or a specified insurance company."
    )]
    CRS104 = CRSStatusCode.CRS104, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution without one or more controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as &quot;C105&quot;.
    /// </summary>
    [EnumMember(Value = "C105")]
    [IsoId("_OW2ScUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution without one or more controlling persons that are foreign persons."
    )]
    CRS105 = CRSStatusCode.CRS105, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution with one or more controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as &quot;C106&quot;.
    /// </summary>
    [EnumMember(Value = "C106")]
    [IsoId("_OhQysUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution with one or more controlling persons that are foreign persons."
    )]
    CRS106 = CRSStatusCode.CRS106, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a financial institution such as another investment entity.
    /// Encoded/decoded by serializers as &quot;C107&quot;.
    /// </summary>
    [EnumMember(Value = "C107")]
    [IsoId("_OkY_MUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is a financial institution such as another investment entity."
    )]
    CRS107 = CRSStatusCode.CRS107, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is an active non-financial entity such as a corporation for which the stock is regularly traded on an established securities market.
    /// Encoded/decoded by serializers as &quot;C108&quot;.
    /// </summary>
    [EnumMember(Value = "C108")]
    [IsoId("_Ot6HkUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is an active non-financial entity such as a corporation for which the stock is regularly traded on an established securities market."
    )]
    CRS108 = CRSStatusCode.CRS108, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is an active non-financial entity such as a corporation which is a related entity of a corporation for which the stock is regularly traded on an established securities market.
    /// Encoded/decoded by serializers as &quot;C109&quot;.
    /// </summary>
    [EnumMember(Value = "C109")]
    [IsoId("_O4Ld4UNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is an active non-financial entity such as a corporation which is a related entity of a corporation for which the stock is regularly traded on an established securities market."
    )]
    CRS109 = CRSStatusCode.CRS109, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is an active non-financial entity such as a government entity.
    /// Encoded/decoded by serializers as &quot;C110&quot;.
    /// </summary>
    [EnumMember(Value = "C110")]
    [IsoId("_PB2XQUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is an active non-financial entity such as a government entity."
    )]
    CRS110 = CRSStatusCode.CRS110, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is an active non-financial entity such as a central bank.
    /// Encoded/decoded by serializers as &quot;C111&quot;.
    /// </summary>
    [EnumMember(Value = "C111")]
    [IsoId("_PLXfoUNsEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is an active non-financial entity such as a central bank.")]
    CRS111 = CRSStatusCode.CRS111, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is an active non-financial entity such as an international organisation.
    /// Encoded/decoded by serializers as &quot;C112&quot;.
    /// </summary>
    [EnumMember(Value = "C112")]
    [IsoId("_PVoO4UNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is an active non-financial entity such as an international organisation."
    )]
    CRS112 = CRSStatusCode.CRS112, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is not a foreign person.
    /// Encoded/decoded by serializers as &quot;C113&quot;.
    /// </summary>
    [EnumMember(Value = "C113")]
    [IsoId("_PYwbYUNsEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is not a foreign person.")]
    CRS113 = CRSStatusCode.CRS113, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a financial institution such as an investment entity of a participating jurisdiction and managed by another financial institution.
    /// Encoded/decoded by serializers as &quot;C114&quot;.
    /// </summary>
    [EnumMember(Value = "C114")]
    [IsoId("_PiRjwUNsEeaS-NnwLNvMPg")]
    [Description(
        @"Account holder type is a financial institution such as an investment entity of a participating jurisdiction and managed by another financial institution."
    )]
    CRS114 = CRSStatusCode.CRS114, // same ordinal as derivation source for type conversions
}
