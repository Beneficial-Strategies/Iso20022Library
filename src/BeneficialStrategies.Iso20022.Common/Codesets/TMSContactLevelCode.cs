// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Level of urgency in contacting the terminal management system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVWQAgEcEeCQm6a_G2yO_w_1626572766")]
[Description(@"Level of urgency in contacting the terminal management system.")]
[Derivations(typeof(TMSContactLevel1Code),typeof(TMSContactLevel2Code))]
public enum TMSContactLevelCode
{
    /// <summary>
    /// Terminal management system has to be contacted before the next transaction.
    /// Encoded/decoded by serializers as &quot;CRIT&quot;.
    /// </summary>
    [EnumMember(Value = "CRIT")]
    [IsoId("_TVWQAwEcEeCQm6a_G2yO_w_59106587")]
    [Description(@"Terminal management system has to be contacted before the next transaction.")]
    Critical,
    
    /// <summary>
    /// Terminal management system has to be contacted as soon as possible (for example after reconciliation).
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_TVWQBAEcEeCQm6a_G2yO_w_-695643287")]
    [Description(@"Terminal management system has to be contacted as soon as possible (for example after reconciliation).")]
    AsSoonAsPossible,
    
    /// <summary>
    /// Terminal management system has to be contacted at the date and time provided.
    /// Encoded/decoded by serializers as &quot;DTIM&quot;.
    /// </summary>
    [EnumMember(Value = "DTIM")]
    [IsoId("_TVWQBQEcEeCQm6a_G2yO_w_-639992749")]
    [Description(@"Terminal management system has to be contacted at the date and time provided.")]
    DateTime,
    
    /// <summary>
    /// After the end of the customer session.
    /// Encoded/decoded by serializers as &quot;ENCS&quot;.
    /// </summary>
    [EnumMember(Value = "ENCS")]
    [IsoId("_YrKcMIqKEeSRT5rEzcAHEw")]
    [Description(@"After the end of the customer session.")]
    EndCustomerSession,
    
}
