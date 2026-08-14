// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the system party type, as published in an external system party type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_N1TgkT5hEemZvp0oiT0MWg")]
[Description(@"Specifies the system party type, as published in an external system party type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalSystemPartyTypeCode>))]
public readonly struct ExternalSystemPartyTypeCode : IIsoExternalCode, IEquatable<ExternalSystemPartyTypeCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given system party type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalSystemPartyTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalSystemPartyTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalSystemPartyTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalSystemPartyTypeCode"/>.</summary>
    public static implicit operator ExternalSystemPartyTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalSystemPartyTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalSystemPartyTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalSystemPartyTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalSystemPartyTypeCode a, ExternalSystemPartyTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalSystemPartyTypeCode a, ExternalSystemPartyTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalSystemPartyTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalSystemPartyTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalSystemPartyTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalSystemPartyTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>System in which payments and/or financial instruments are exchanged and/or cleared or recorded, while the ensuing monetary obligations are settled in another system, typically an RTGS system</summary>
    [IsoId("_U3TsAPXXEe-Ig-GynGPh9A")]
    [Description(@"System in which payments and/or financial instruments are exchanged and/or cleared or recorded, while the ensuing monetary obligations are settled in another system, typically an RTGS system")]
    public static readonly ExternalSystemPartyTypeCode AncillarySystem = new("ANSY");

    /// <summary>Legal entity or, as the case may be, an individual having a contractual relationship with the CSD for the processing of its securities settlement-related activities in T2S.</summary>
    [IsoId("_U3UTEfXXEe-Ig-GynGPh9A")]
    [Description(@"Legal entity or, as the case may be, an individual having a contractual relationship with the CSD for the processing of its securities settlement-related activities in T2S.")]
    public static readonly ExternalSystemPartyTypeCode CentralSecuritiesDepositoryParticipant = new("CSDP");

    /// <summary>Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records.</summary>
    [IsoId("_U3UTEPXXEe-Ig-GynGPh9A")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records.")]
    public static readonly ExternalSystemPartyTypeCode CentralSecuritiesDepository = new("CSDY");

    /// <summary>Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records. The infrastructure is external to the system executing the instruction.</summary>
    [IsoId("_U3U6IPXXEe-Ig-GynGPh9A")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records. The infrastructure is external to the system executing the instruction.")]
    public static readonly ExternalSystemPartyTypeCode ExternalCentralSecuritiesDepository = new("ECSD");

    /// <summary>As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.</summary>
    [IsoId("_U3TE8PXXEe-Ig-GynGPh9A")]
    [Description(@"As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.")]
    public static readonly ExternalSystemPartyTypeCode NationalCentralBank = new("NCBK");

    /// <summary>Commercial bank used to effect money settlements.</summary>
    [IsoId("_U3TE8fXXEe-Ig-GynGPh9A")]
    [Description(@"Commercial bank used to effect money settlements.")]
    public static readonly ExternalSystemPartyTypeCode PaymentBank = new("PMBK");

    /// <summary>Party that owns an account in the system, but only supports a limited range of available use cases in interaction with counterparties.</summary>
    [IsoId("_y2Fo8I9tEe6qf99bCU7sXQ")]
    [Description(@"Party that owns an account in the system, but only supports a limited range of available use cases in interaction with counterparties.")]
    public static readonly ExternalSystemPartyTypeCode StandardParticipantRestricted = new("STPR");

    /// <summary>Party that owns an account in the system and can interact with the system or counterparties using all use cases available to standard participants.</summary>
    [IsoId("_qrWcII9tEe6qf99bCU7sXQ")]
    [Description(@"Party that owns an account in the system and can interact with the system or counterparties using all use cases available to standard participants.")]
    public static readonly ExternalSystemPartyTypeCode StandardParticipantUnrestricted = new("STPU");

    /// <summary>Party that defines the eligibility criteria of the system and is responsible for monitoring, controlling and, if necessary, operating the system. All authorizations are available to the system manager when interacting with the system.</summary>
    [IsoId("_TtgAUI9tEe6qf99bCU7sXQ")]
    [Description(@"Party that defines the eligibility criteria of the system and is responsible for monitoring, controlling and, if necessary, operating the system. All authorizations are available to the system manager when interacting with the system.")]
    public static readonly ExternalSystemPartyTypeCode SystemManager = new("SYMG");

    /// <summary>Party that operates the system on behalf of the system manager (if different from the system manager) and is provided with specific authorizations by the system manager for this purpose.</summary>
    [IsoId("_jcOjAI9tEe6qf99bCU7sXQ")]
    [Description(@"Party that operates the system on behalf of the system manager (if different from the system manager) and is provided with specific authorizations by the system manager for this purpose.")]
    public static readonly ExternalSystemPartyTypeCode SystemOperator = new("SYOP");
}
