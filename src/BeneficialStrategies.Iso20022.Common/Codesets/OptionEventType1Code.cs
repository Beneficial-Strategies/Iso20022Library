// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of event for an option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DbpVoMR1EeOg-a7zWL_U0A")]
[Description(@"Specifies the type of event for an option.")]
[DerivedFrom(typeof(OptionEventTypeCode))]
public enum OptionEventType1Code
{
    /// <summary>
    /// Notice of a close out of the position.
    /// Encoded/decoded by serializers as &quot;CLST&quot;.
    /// </summary>
    [EnumMember(Value = "CLST")]
    [IsoId("_FFj5wcR1EeOg-a7zWL_U0A")]
    [Description(@"Notice of a close out of the position.")]
    CloseOut = OptionEventTypeCode.CloseOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// First confirmation.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_FNK9ocR1EeOg-a7zWL_U0A")]
    [Description(@"First confirmation.")]
    FirstConfirmation = OptionEventTypeCode.FirstConfirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notice of a knock-in. The option has a specified spot level, which, if touched during the knock-in period, triggers the option into existence. Prior to that level being touched, no option exists.
    /// Encoded/decoded by serializers as &quot;KNIN&quot;.
    /// </summary>
    [EnumMember(Value = "KNIN")]
    [IsoId("_FbHTAcR1EeOg-a7zWL_U0A")]
    [Description(@"Notice of a knock-in. The option has a specified spot level, which, if touched during the knock-in period, triggers the option into existence. Prior to that level being touched, no option exists.")]
    KnockIn = OptionEventTypeCode.KnockIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notice of a knock-out. The option has a specified spot level, which, if touched during the knock-out period, terminates the option.
    /// Encoded/decoded by serializers as &quot;KNOC&quot;.
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_FiiwscR1EeOg-a7zWL_U0A")]
    [Description(@"Notice of a knock-out. The option has a specified spot level, which, if touched during the knock-out period, terminates the option.")]
    KnockOut = OptionEventTypeCode.KnockOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type of event.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_FqH_YcR1EeOg-a7zWL_U0A")]
    [Description(@"Another type of event.")]
    Other = OptionEventTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notice of a trigger hit.
    /// Encoded/decoded by serializers as &quot;TRIG&quot;.
    /// </summary>
    [EnumMember(Value = "TRIG")]
    [IsoId("_FxfLocR1EeOg-a7zWL_U0A")]
    [Description(@"Notice of a trigger hit.")]
    Trigger = OptionEventTypeCode.Trigger, // same ordinal as derivation source for type conversions
    
}
