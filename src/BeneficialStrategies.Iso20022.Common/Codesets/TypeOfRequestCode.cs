// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_92aNUNvdEeqxGfKJubfhIw")]
[Description(@"Specifies a type of request.")]
[Derivations(typeof(TypeOfRequest1Code))]
public enum TypeOfRequestCode
{
    /// <summary>
    /// Request for status.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("__q5pwNvdEeqxGfKJubfhIw")]
    [Description(@"Request for status.")]
    Status,

    /// <summary>
    /// Request for information.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_BILgENveEeqxGfKJubfhIw")]
    [Description(@"Request for information.")]
    Information,
}
