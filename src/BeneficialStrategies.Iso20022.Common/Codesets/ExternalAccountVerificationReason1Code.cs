// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason codes used by a verification service provider to inform verification statuses and errors.
/// </summary>
/// <remarks>
/// Versioned restriction of <see cref="ExternalAccountVerificationReasonCode"/>. No length facet
/// published by MCP for this codeset; Pattern kept at the conventional 1-4 character range
/// observed across all published member codes (RC01-RC19).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_JNnXoMkjEfCkjbgR87y1_g")]
[Description(@"Reason codes used by a verification service provider to inform verification statuses and errors.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalAccountVerificationReason1Code>))]
public readonly struct ExternalAccountVerificationReason1Code : IIsoExternalCode, IEquatable<ExternalAccountVerificationReason1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalAccountVerificationReason1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalAccountVerificationReason1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalAccountVerificationReason1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalAccountVerificationReason1Code"/>.</summary>
    public static implicit operator ExternalAccountVerificationReason1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalAccountVerificationReason1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalAccountVerificationReason1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalAccountVerificationReason1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalAccountVerificationReason1Code a, ExternalAccountVerificationReason1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalAccountVerificationReason1Code a, ExternalAccountVerificationReason1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalAccountVerificationReason1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalAccountVerificationReason1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalAccountVerificationReason1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalAccountVerificationReason1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Unsupported party identification.</summary>
    /// <remarks>For example: The party identification verification cannot be done as the data provider only supports tax ID and no other types of ID.</remarks>
    [IsoId("_Y393gS53EfGzytFQf72hbg")]
    [Description(@"Unsupported party identification.||For example: The party identification verification cannot be done as the data provider only supports tax ID and no other types of ID.")]
    public static readonly ExternalAccountVerificationReason1Code UnsupportedPartyIdentification = new("RC01");

    /// <summary>Missing party identification.</summary>
    /// <remarks>For example: The account verification cannot be done as party identification is required to perform the account verification.</remarks>
    [IsoId("_Y39QcS53EfGzytFQf72hbg")]
    [Description(@"Missing party identification.|For example: The account verification cannot be done as party identification is required to perform the account verification.")]
    public static readonly ExternalAccountVerificationReason1Code MissingPartyIdentification = new("RC02");

    /// <summary>Missing party name.</summary>
    /// <remarks>For example: The account verification cannot be done as party name is required to perform the account verification.</remarks>
    [IsoId("_Y393gy53EfGzytFQf72hbg")]
    [Description(@"Missing party name.|For example: The account verification cannot be done as party name is required to perform the account verification.")]
    public static readonly ExternalAccountVerificationReason1Code MissingPartyName = new("RC03");

    /// <summary>Name matching engine limitation.</summary>
    /// <remarks>For example: The name matching cannot be done as the data provider supports names with Latin character set only, or there was an error in the matching engine, or the name is protected (for example, a politician) and cannot be checked.</remarks>
    [IsoId("_Y393hS53EfGzytFQf72hbg")]
    [Description(@"Name matching engine limitation.|For example: The name matching cannot be done as the data provider supports names with Latin character set only, or there was an error in the matching engine, or the name is protected (for example, a politician) and cannot be checked.")]
    public static readonly ExternalAccountVerificationReason1Code NameMatchingEngineLimitation = new("RC04");

    /// <summary>Unsupported account format.</summary>
    /// <remarks>For example: The account verification cannot be done as the data provider only supports IBAN accounts.</remarks>
    [IsoId("_Y393hy53EfGzytFQf72hbg")]
    [Description(@"Unsupported account format.|For example: The account verification cannot be done as the data provider only supports IBAN accounts.")]
    public static readonly ExternalAccountVerificationReason1Code UnsupportedAccountFormat = new("RC05");

    /// <summary>This type of account does not accept incoming funds.</summary>
    /// <remarks>For example: The account verification cannot be done as mortgage accounts do not accept incoming funds.</remarks>
    [IsoId("_Y393iS53EfGzytFQf72hbg")]
    [Description(@"This type of account does not accept incoming funds.|For example: The account verification cannot be done as mortgage accounts do not accept incoming funds.")]
    public static readonly ExternalAccountVerificationReason1Code InvalidAccountType = new("RC06");

    /// <summary>The account is excluded from the business scope.</summary>
    /// <remarks>For example: The account verification was not successful as verification is implemented for corporate accounts only, retail accounts are out of scope.</remarks>
    [IsoId("_Y393iy53EfGzytFQf72hbg")]
    [Description(@"The account is excluded from the business scope.||For example: The account verification was not successful as verification is implemented for corporate accounts only, retail accounts are out of scope.")]
    public static readonly ExternalAccountVerificationReason1Code UnsupportedAccount = new("RC07");

    /// <summary>Account number provided is invalid or missing.</summary>
    [IsoId("_Y393jS53EfGzytFQf72hbg")]
    [Description(@"Account number provided is invalid or missing.")]
    public static readonly ExternalAccountVerificationReason1Code IncorrectAccountNumber = new("RC08");

    /// <summary>The account is closed and cannot accept incoming funds.</summary>
    [IsoId("_Y393jy53EfGzytFQf72hbg")]
    [Description(@"The account is closed and cannot accept incoming funds.")]
    public static readonly ExternalAccountVerificationReason1Code ClosedAccountNumber = new("RC09");

    /// <summary>The account is blocked and cannot accept incoming funds.</summary>
    [IsoId("_Y393kS53EfGzytFQf72hbg")]
    [Description(@"The account is blocked and cannot accept incoming funds.")]
    public static readonly ExternalAccountVerificationReason1Code BlockedAccount = new("RC10");

    /// <summary>Suspected fraud.</summary>
    /// <remarks>For example: The account verification was done, but the account has been labelled fraudulent.</remarks>
    [IsoId("_Y393ky53EfGzytFQf72hbg")]
    [Description(@"Suspected fraud.|||For example: The account verification was done, but the account has been labelled fraudulent.")]
    public static readonly ExternalAccountVerificationReason1Code FraudulentAccount = new("RC11");

    /// <summary>The account number holds information to identify the account holding bank, however this does not correspond with the provided Party Agent (typically Debtor Agent or Creditor Agent).</summary>
    /// <remarks>For example: The BIC of bank A was provided as Party Agent, however the account number contains the  identification of bank B.</remarks>
    [IsoId("_Y393lS53EfGzytFQf72hbg")]
    [Description(@"The account number holds information to identify the account holding bank, however this does not correspond with the provided Party Agent (typically Debtor Agent or Creditor Agent).||For example: The BIC of bank A was provided as Party Agent, however the account number contains the  identification of bank B.")]
    public static readonly ExternalAccountVerificationReason1Code MismatchAccountPartyAgent = new("RC12");

    /// <summary>Party Agent  (typically Debtor Agent or Creditor Agent) is not registered under this Account Verification Scheme.</summary>
    [IsoId("_Y3-eky53EfGzytFQf72hbg")]
    [Description(@"Party Agent  (typically Debtor Agent or Creditor Agent) is not registered under this Account Verification Scheme.")]
    public static readonly ExternalAccountVerificationReason1Code PartyAgentNotRegistered = new("RC13");

    /// <summary>Party Agent  (typically Debtor Agent or Creditor Agent) is not valid under this Account Verification Scheme.</summary>
    [IsoId("_Y3-elS53EfGzytFQf72hbg")]
    [Description(@"Party Agent  (typically Debtor Agent or Creditor Agent) is not valid under this Account Verification Scheme.")]
    public static readonly ExternalAccountVerificationReason1Code PartyAgentNotValid = new("RC14");

    /// <summary>Unsupported requestor scope.</summary>
    /// <remarks>For example: The account verification cannot be done as the data provider only services requesting agent from South East Asia.</remarks>
    [IsoId("_Y3-ekS53EfGzytFQf72hbg")]
    [Description(@"Unsupported requestor scope.||For example: The account verification cannot be done as the data provider only services requesting agent from South East Asia.")]
    public static readonly ExternalAccountVerificationReason1Code UnsupportedRequestorScope = new("RC15");

    /// <summary>Requestor is not registered under this Account Verification Scheme.</summary>
    [IsoId("_Y3-ely53EfGzytFQf72hbg")]
    [Description(@"Requestor is not registered under this Account Verification Scheme.")]
    public static readonly ExternalAccountVerificationReason1Code RequestorBankNotRegistered = new("RC16");

    /// <summary>The verification is executed by the proprietary solution offered by the Account Verification Scheme, independent of the account holding bank.</summary>
    /// <remarks>For example: The verification response was generated based on a proprietary algorithm using observed data.</remarks>
    [IsoId("_Y3-emS53EfGzytFQf72hbg")]
    [Description(@"The verification is executed by the proprietary solution offered by the Account Verification Scheme, independent of the account holding bank.||For example: The verification response was generated based on a proprietary algorithm using observed data.")]
    public static readonly ExternalAccountVerificationReason1Code SchemeResponse = new("RC17");

    /// <summary>The Party Agent  (typically Debtor Agent or Creditor Agent) is registered to the Account Verification Scheme but is temporarily unavailable. The Account Verification Scheme proprietary solution executed the verification of the account instead.</summary>
    [IsoId("_Y3-emy53EfGzytFQf72hbg")]
    [Description(@"The Party Agent  (typically Debtor Agent or Creditor Agent) is registered to the Account Verification Scheme but is temporarily unavailable. The Account Verification Scheme proprietary solution executed the verification of the account instead.")]
    public static readonly ExternalAccountVerificationReason1Code SchemeResponseUnvailablePartyAgent = new("RC18");

    /// <summary>The Account Verification Scheme proprietary solution executed the verification of the account because the request was invalid for the registered Party Agent  (typically Debtor Agent or Creditor Agent).</summary>
    [IsoId("_Y3-enS53EfGzytFQf72hbg")]
    [Description(@"The Account Verification Scheme proprietary solution executed the verification of the account because the request was invalid for the registered Party Agent  (typically Debtor Agent or Creditor Agent).")]
    public static readonly ExternalAccountVerificationReason1Code SchemeResponseInvalidRequest = new("RC19");
}
