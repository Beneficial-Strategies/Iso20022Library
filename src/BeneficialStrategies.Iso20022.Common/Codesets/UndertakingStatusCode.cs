// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the undertaking status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uQUrMHykEeGWJuGCfvwOsQ")]
[Description(@"Specifies the undertaking status.")]
[Derivations(
    typeof(UndertakingStatus1Code),
    typeof(UndertakingStatus2Code),
    typeof(UndertakingStatus3Code)
)]
public enum UndertakingStatusCode
{
    /// <summary>
    /// Accepted in accordance with technical validation.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_Wf67oHylEeGWJuGCfvwOsQ")]
    [Description(@"Accepted in accordance with technical validation.")]
    AcceptedTechnicalValidation,

    /// <summary>
    /// Accepted.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_f4Ou0HylEeGWJuGCfvwOsQ")]
    [Description(@"Accepted.")]
    Accepted,

    /// <summary>
    /// Pending further processing.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_kdrP8HylEeGWJuGCfvwOsQ")]
    [Description(@"Pending further processing.")]
    Pending,

    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_tiKvQHylEeGWJuGCfvwOsQ")]
    [Description(@"Received.")]
    Received,

    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_0hHeYHylEeGWJuGCfvwOsQ")]
    [Description(@"Rejected.")]
    Rejected,

    /// <summary>
    /// Undertaking not confirmed.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_IeDI0H1UEeGlwNeVP9egyg")]
    [Description(@"Undertaking not confirmed.")]
    NonConfirmation,

    /// <summary>
    /// Demand has been withdrawn.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_5NIuEH1UEeGlwNeVP9egyg")]
    [Description(@"Demand has been withdrawn.")]
    Withdrawn,

    /// <summary>
    /// Change to undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTU&quot;.
    /// </summary>
    [EnumMember(Value = "AMTU")]
    [IsoId("_VkLcAK-xEeGNi5z8K_XPKQ")]
    [Description(@"Change to undertaking amount.")]
    UndertakingAmountChange,

    /// <summary>
    /// Change to counter-undertaking amount.
    /// Encoded/decoded by serializers as &quot;AMTC&quot;.
    /// </summary>
    [EnumMember(Value = "AMTC")]
    [IsoId("_srHiYK-xEeGNi5z8K_XPKQ")]
    [Description(@"Change to counter-undertaking amount.")]
    CounterUndertakingAmountChange,
}
