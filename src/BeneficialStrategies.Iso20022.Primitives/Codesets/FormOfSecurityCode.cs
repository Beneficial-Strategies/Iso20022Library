// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the form of the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yTuAQNu8EeGvDJc6a1miEg_1096213532")]
[Description(@"Specifies the form of the security.")]
[Derivations(typeof(FormOfSecurity1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FormOfSecurityCode>))]
public enum FormOfSecurityCode
{
    /// <summary>
    /// Shareholder name of the financial instrument appears in the corporation/funds books.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_arP_w9p-Ed-ak6NoX_4Aeg_1876631848")]
    [Description(
        @"Shareholder name of the financial instrument appears in the corporation/funds books."
    )]
    Registered,

    /// <summary>
    /// The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate.
    /// Encoded/decoded by serializers as &quot;BEAR&quot;.
    /// </summary>
    [EnumMember(Value = "BEAR")]
    [IsoId("_arP_wtp-Ed-ak6NoX_4Aeg_1839687617")]
    [Description(
        @"The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate."
    )]
    Bearer,

    /// <summary>
    /// Registered security where ownership is determined by account entry by a registrar, CSD or trustee.
    /// Encoded/decoded by serializers as &quot;BKEN&quot;.
    /// </summary>
    [EnumMember(Value = "BKEN")]
    [IsoId("_g01YgFAtEfCpNoeDQdjnVw")]
    [Description(@"Registered security where ownership is determined by account entry by a registrar, CSD or trustee.")]
    BookEntry,

    /// <summary>
    /// Multiple issuers and investors hold a claim in a registered form with holders details.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("_iIHlUFAtEfCpNoeDQdjnVw")]
    [Description(@"Multiple issuers and investors hold a claim in a registered form with holders details.")]
    CollectiveDebtRegisteredClaim,

    /// <summary>
    /// No physical form of the security exists and the owner's details are not recorded in the account entry.
    /// Encoded/decoded by serializers as &quot;DBER&quot;.
    /// </summary>
    [EnumMember(Value = "DBER")]
    [IsoId("_kep-4FAtEfCpNoeDQdjnVw")]
    [Description(@"No physical form of the security exists and the owner's details are not recorded in the account entry.")]
    DematerialisedBearer,

    /// <summary>
    /// The bond exists in the form of an account entry with the owner's details.
    /// Encoded/decoded by serializers as &quot;DBKN&quot;.
    /// </summary>
    [EnumMember(Value = "DBKN")]
    [IsoId("_l3pyIFAtEfCpNoeDQdjnVw")]
    [Description(@"The bond exists in the form of an account entry with the owner's details.")]
    DematerialisedBookEntry,

    /// <summary>
    /// No physical form of the security exists.
    /// Encoded/decoded by serializers as &quot;DEMT&quot;.
    /// </summary>
    [EnumMember(Value = "DEMT")]
    [IsoId("_gGmZgFAtEfCpNoeDQdjnVw")]
    [Description(@"No physical form of the security exists.")]
    Dematerialised,

    /// <summary>
    /// The bond exists in the form of an account entry with the owner's details.
    /// Encoded/decoded by serializers as &quot;DREG&quot;.
    /// </summary>
    [EnumMember(Value = "DREG")]
    [IsoId("_nqg24FAtEfCpNoeDQdjnVw")]
    [Description(@"The bond exists in the form of an account entry with the owner's details.")]
    DematerialisedRegistered,

    /// <summary>
    /// US dollar dominated bonds issued by the US government where ownership is recorded in the federal reserve system.
    /// Encoded/decoded by serializers as &quot;FDBK&quot;.
    /// </summary>
    [EnumMember(Value = "FDBK")]
    [IsoId("_peiZQFAtEfCpNoeDQdjnVw")]
    [Description(@"US dollar dominated bonds issued by the US government where ownership is recorded in the federal reserve system.")]
    FedBookEntry,

    /// <summary>
    /// Physical certificate exists without the owner's details.
    /// Encoded/decoded by serializers as &quot;MBER&quot;.
    /// </summary>
    [EnumMember(Value = "MBER")]
    [IsoId("_rQeQ8FAtEfCpNoeDQdjnVw")]
    [Description(@"Physical certificate exists without the owner's details.")]
    MaterialisedBearer,

    /// <summary>
    /// Physical certificate exists with the owner's details.
    /// Encoded/decoded by serializers as &quot;MREG&quot;.
    /// </summary>
    [EnumMember(Value = "MREG")]
    [IsoId("_tp7boFAtEfCpNoeDQdjnVw")]
    [Description(@"Physical certificate exists with the owner's details.")]
    MaterialisedRegistered,

    /// <summary>
    /// No physical certificate exists and ownership is held through an account entry.
    /// Encoded/decoded by serializers as &quot;UCRB&quot;.
    /// </summary>
    [EnumMember(Value = "UCRB")]
    [IsoId("_zQmwQFAtEfCpNoeDQdjnVw")]
    [Description(@"No physical certificate exists and ownership is held through an account entry.")]
    UncertifiedDematerialisedBookEntry,

    /// <summary>
    /// Registered bond where ownership is determined by account entry by a registrar, CSD or trustee.
    /// Encoded/decoded by serializers as &quot;UCRT&quot;.
    /// </summary>
    [EnumMember(Value = "UCRT")]
    [IsoId("_yTDi4FAtEfCpNoeDQdjnVw")]
    [Description(@"Registered bond where ownership is determined by account entry by a registrar, CSD or trustee.")]
    Uncertified,

    /// <summary>
    /// No physical certificate exists and ownership is held through an account entry.
    /// Encoded/decoded by serializers as &quot;UNCB&quot;.
    /// </summary>
    [EnumMember(Value = "UNCB")]
    [IsoId("_unhsUFAtEfCpNoeDQdjnVw")]
    [Description(@"No physical certificate exists and ownership is held through an account entry.")]
    UncertificatedDematerialisedBookEntry,

    /// <summary>
    /// Ownership is determined by a form of account entry with the owners details.
    /// Encoded/decoded by serializers as &quot;UNCR&quot;.
    /// </summary>
    [EnumMember(Value = "UNCR")]
    [IsoId("_wypgEFAtEfCpNoeDQdjnVw")]
    [Description(@"Ownership is determined by a form of account entry with the owners details.")]
    UncertificatedRegistered,
}
