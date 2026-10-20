// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the statement is an accounting or a custody statement.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0aYMCQJ3EfGAP_FOfstLIw")]
[Description(
    @"Specifies whether the statement is an accounting or a custody statement.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalSecuritiesStatementType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalSecuritiesStatementTypeCode>))]
public enum ExternalSecuritiesStatementTypeCode
{
    /// <summary>
    /// Statement is a registered holder names(s) and address statement.
    /// Encoded/decoded by serializers as &quot;RGAD&quot;.
    /// </summary>
    [EnumMember(Value = "RGAD")]
    [IsoId("_pqqEgAJ4EfGAP_FOfstLIw")]
    [Description(@"Statement is a registered holder names(s) and address statement.")]
    RegisteredHolderNamesAndAddress,

    /// <summary>
    /// Statement is a security holder reference number and registration statement.
    /// Encoded/decoded by serializers as &quot;SRNR&quot;.
    /// </summary>
    [EnumMember(Value = "SRNR")]
    [IsoId("_pzGO0AJ4EfGAP_FOfstLIw")]
    [Description(@"Statement is a security holder reference number and registration statement.")]
    SecurityHolderReferenceNumberAndRegistration,
}
