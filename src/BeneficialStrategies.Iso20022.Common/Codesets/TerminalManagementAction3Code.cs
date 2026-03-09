// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pzYu4I34EeWRwov1g9WL_A")]
[Description(@"Type of action to perform.")]
[DerivedFrom(typeof(TerminalManagementActionCode))]
public enum TerminalManagementAction3Code
{
    /// <summary>
    /// Request to create or add the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;CREA&quot;.
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_r33vIY34EeWRwov1g9WL_A")]
    [Description(@"Request to create or add the element identified inside the message exchange.")]
    Create = TerminalManagementActionCode.Create, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_sBQUoY34EeWRwov1g9WL_A")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete = TerminalManagementActionCode.Delete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_sMIu8Y34EeWRwov1g9WL_A")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update = TerminalManagementActionCode.Update, // same ordinal as derivation source for type conversions
    
}
