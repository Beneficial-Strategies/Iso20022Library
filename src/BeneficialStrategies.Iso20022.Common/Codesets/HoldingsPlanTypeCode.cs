// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the holdings plan of the assets to transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1TJzwwnwEeGRcv5_yGDZOA")]
[Description(@"Specifies the holdings plan of the assets to transfer.")]
[Derivations(typeof(HoldingsPlanType1Code))]
public enum HoldingsPlanTypeCode
{
    /// <summary>
    /// Holding to be transferred belongs to an investment plan.
    /// Encoded/decoded by serializers as &quot;INVP&quot;.
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_Hu7LgAnxEeGRcv5_yGDZOA")]
    [Description(@"Holding to be transferred belongs to an investment plan.")]
    InvestmentPlan,
    
    /// <summary>
    /// Holding to be transferred belongs to a switch plan.
    /// Encoded/decoded by serializers as &quot;SWIP&quot;.
    /// </summary>
    [EnumMember(Value = "SWIP")]
    [IsoId("_N0whUAnxEeGRcv5_yGDZOA")]
    [Description(@"Holding to be transferred belongs to a switch plan.")]
    SwitchPlan,
    
    /// <summary>
    /// Holding to be transferred belongs to a withdrawal plan.
    /// Encoded/decoded by serializers as &quot;PLAR&quot;.
    /// </summary>
    [EnumMember(Value = "PLAR")]
    [IsoId("_SZt6QAnxEeGRcv5_yGDZOA")]
    [Description(@"Holding to be transferred belongs to a withdrawal plan.")]
    WithdrawalPlan,
    
}
