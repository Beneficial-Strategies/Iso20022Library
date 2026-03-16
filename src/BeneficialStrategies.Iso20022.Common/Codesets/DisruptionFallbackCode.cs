// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the method used to determine a settlement rate when a disruption event has occurred.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awUtBtp-Ed-ak6NoX_4Aeg_627416917")]
[Description(
    @"Identifies the method used to determine a settlement rate when a disruption event has occurred."
)]
public enum DisruptionFallbackCode
{
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;AOCL&quot;.
    /// </summary>
    [EnumMember(Value = "AOCL")]
    [IsoId("_awUtB9p-Ed-ak6NoX_4Aeg_627416918")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    AssignmentOfClaim,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;CADS&quot;.
    /// </summary>
    [EnumMember(Value = "CADS")]
    [IsoId("_awUtCNp-Ed-ak6NoX_4Aeg_627417183")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    CalculationAgentDeterminationOfSettlementRate,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;DLVS&quot;.
    /// </summary>
    [EnumMember(Value = "DLVS")]
    [IsoId("_awd28Np-Ed-ak6NoX_4Aeg_627417184")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    DeliverableSubstitute,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("_awd28dp-Ed-ak6NoX_4Aeg_627417192")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    EscrowArrangement,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;FBRP&quot;.
    /// </summary>
    [EnumMember(Value = "FBRP")]
    [IsoId("_awd28tp-Ed-ak6NoX_4Aeg_627417193")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    FallbackReferencePrice,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;LASG&quot;.
    /// </summary>
    [EnumMember(Value = "LASG")]
    [IsoId("_awd289p-Ed-ak6NoX_4Aeg_627417194")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    LocalAssetSubstituteGross,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;LASN&quot;.
    /// </summary>
    [EnumMember(Value = "LASN")]
    [IsoId("_awd29Np-Ed-ak6NoX_4Aeg_627417195")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    LocalAssetSubstituteNet,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;LCYS&quot;.
    /// </summary>
    [EnumMember(Value = "LCYS")]
    [IsoId("_awd29dp-Ed-ak6NoX_4Aeg_627417196")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    LocalCurrencySubstitute,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;NFTR&quot;.
    /// </summary>
    [EnumMember(Value = "NFTR")]
    [IsoId("_awd29tp-Ed-ak6NoX_4Aeg_627417197")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    NoFaultTermination,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;NDLS&quot;.
    /// </summary>
    [EnumMember(Value = "NDLS")]
    [IsoId("_awd299p-Ed-ak6NoX_4Aeg_627417206")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    NonDeliverableSubstitute,

    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// Encoded/decoded by serializers as &quot;STPP&quot;.
    /// </summary>
    [EnumMember(Value = "STPP")]
    [IsoId("_awd2-Np-Ed-ak6NoX_4Aeg_627417207")]
    [Description(
        @"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee."
    )]
    SettlementPostponement,
}
