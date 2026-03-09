// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of leg structuring a swap.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aeSh1tp-Ed-ak6NoX_4Aeg_336256659")]
[Description(@"Indicates the type of leg structuring a swap.")]
[Derivations(typeof(LegSwapType1Code))]
public enum LegSwapTypeCode
{
    /// <summary>
    /// Type of leg involved in a swap whose purpose is to exchange principal.
    /// Encoded/decoded by serializers as &quot;PFPR&quot;.
    /// </summary>
    [EnumMember(Value = "PFPR")]
    [IsoId("_aeSh19p-Ed-ak6NoX_4Aeg_336256660")]
    [Description(@"Type of leg involved in a swap whose purpose is to exchange principal.")]
    ParForPar,
    
    /// <summary>
    /// Type of leg involved in a swap whose purpose is to exchange price volatility.
    /// Encoded/decoded by serializers as &quot;MODU&quot;.
    /// </summary>
    [EnumMember(Value = "MODU")]
    [IsoId("_aeSh2Np-Ed-ak6NoX_4Aeg_336256661")]
    [Description(@"Type of leg involved in a swap whose purpose is to exchange price volatility.")]
    ModifiedDuration,
    
    /// <summary>
    /// Type of leg involved in a swap whose purpose is to increase the credit quality and reduce the default risk. Also known as quality swap.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_aecS0Np-Ed-ak6NoX_4Aeg_336256662")]
    [Description(@"Type of leg involved in a swap whose purpose is to increase the credit quality and reduce the default risk. Also known as quality swap.")]
    Risk,
    
    /// <summary>
    /// Type of leg involved in a swap structured in the sale of a financial instrument and the simultaneous purchase of another instrument with the proceeds from the sale.
    /// Encoded/decoded by serializers as &quot;PRCD&quot;.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_aecS0dp-Ed-ak6NoX_4Aeg_336256663")]
    [Description(@"Type of leg involved in a swap structured in the sale of a financial instrument and the simultaneous purchase of another instrument with the proceeds from the sale.")]
    Proceeds,
    
}
