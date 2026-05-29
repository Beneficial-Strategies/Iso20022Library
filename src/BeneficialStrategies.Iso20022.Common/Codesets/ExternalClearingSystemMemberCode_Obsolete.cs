// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external clearing system member code in the format of character string with a maximum length of 35 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amVqltp-Ed-ak6NoX_4Aeg_-1092960871")]
[Description(
    @"Specifies the external clearing system member code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Obsolete("Marked obsolete in the ISO 20022 2026-05-11 snapshot. No removal date recorded.")]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalClearingSystemMemberCode_Obsolete>))]
public enum ExternalClearingSystemMemberCode_Obsolete { }
