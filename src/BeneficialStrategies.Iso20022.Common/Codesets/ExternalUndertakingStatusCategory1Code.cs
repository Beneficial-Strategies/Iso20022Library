// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKBG7iEeKo25nLKvGr8w_-479292299")]
[Description(@"Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUndertakingStatusCategoryCode))]
public enum ExternalUndertakingStatusCategory1Code
{
    /// <summary>
    /// Status is related to an undertaking amendment.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_uRhQ2_RYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amendment.")]
    Amendment = ExternalUndertakingStatusCategoryCode.Amendment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to a counter-undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTC&quot;.
    /// </summary>
    [EnumMember(Value = "AMTC")]
    [IsoId("_uRrB0vRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to a counter-undertaking amount.")]
    CounterUndertakingAmountStatus = ExternalUndertakingStatusCategoryCode.CounterUndertakingAmountStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to an undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTU&quot;.
    /// </summary>
    [EnumMember(Value = "AMTU")]
    [IsoId("_uRrB1fRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amount.")]
    UndertakingAmountStatus = ExternalUndertakingStatusCategoryCode.UndertakingAmountStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to an undertaking application.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uRrB2PRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking application.")]
    Application = ExternalUndertakingStatusCategoryCode.Application, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to an undertaking amendment requested by the beneficiary.
    /// Encoded/decoded by serializers as &quot;BAMD&quot;.
    /// </summary>
    [EnumMember(Value = "BAMD")]
    [IsoId("_uRrB2_RYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amendment requested by the beneficiary.")]
    BeneficiaryAmendment = ExternalUndertakingStatusCategoryCode.BeneficiaryAmendment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to an undertaking confirmation.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uRrB3vRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking confirmation.")]
    Confirmation = ExternalUndertakingStatusCategoryCode.Confirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to an undertaking demand.
    /// Encoded/decoded by serializers as &quot;DEMD&quot;.
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_uR0LwvRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking demand.")]
    Demand = ExternalUndertakingStatusCategoryCode.Demand, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to an undertaking non-extension request.
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_uR0LxfRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking non-extension request.")]
    NonExtension = ExternalUndertakingStatusCategoryCode.NonExtension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is related to an undertaking termination.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_uR0LyPRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking termination.")]
    Termination = ExternalUndertakingStatusCategoryCode.Termination, // same ordinal as derivation source for type conversions
    
}
